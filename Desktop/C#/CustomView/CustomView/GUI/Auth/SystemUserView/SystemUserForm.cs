using Entity.Auth;
using GUI.CustomControls;
using Repository.Auth;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Windows.Forms;
using Util;

namespace GUI.Auth.SystemUserView
{
    public partial class SystemUserForm : BaseForm
    {
        protected SystemUser SystemUser_;
        private SystemUserRepository SystemUserRepository;
        public SystemUser SystemUser 
        {
            get 
            {
                return SystemUser_;
            }
            set 
            { 
                SystemUser_= value;
                RefreshControls(); 
            }
        }

        public SystemUserForm(SystemUserRepository SystemUserRepository)
        {
            this.SystemUserRepository = SystemUserRepository;

            InitializeComponent();
            ButtonsContainer panelButtons = new ButtonsContainer();
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.SaveButton.Click += new EventHandler(this.BtnOk_click);
            panelButtons.CancelButton.Click += new EventHandler(this.BtnCancel_Click);
            ButtonsPanel.Controls.Add(panelButtons);
            StartPosition = FormStartPosition.CenterScreen;

            EmployeeComboBox.Init("FullName", "Id", "Empleado", FillEmployeeComboBox);
        }

        public void BtnOk_click(object sender, EventArgs e)
        {
            if (Save())
            {
                MessageDialog(MessageUtil.GlobalRecordSaved, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Hide();
            }
        }

        public void BtnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void Create()
        {
            SystemUser = new SystemUser();
        }

        public void Edit(Guid id)
        {
            SystemUser idt = SystemUserRepository.findById(id);
            SystemUser = idt;
            EmployeeComboBox.Enabled = false;
        }

        protected void RefreshForm()
        {
            SystemUser.Username = UsernameTextBox.Text.Trim();
            SystemUser.Employee = EmployeeComboBox.SelectedItem as Employee;
            SystemUser.ExpirationDate = ExpirationDateTimePicker.Value;
            SystemUser.MultiSession = MultiSessionCheckBox.Checked;
            SystemUser.UserExpires = ExpirationDateTimePicker.Value == null;
        }

        protected void RefreshControls()
        {
            UsernameTextBox.Text = SystemUser.Username;
            if (SystemUser.Employee != null)
            {
                EmployeeComboBox.QueryText = SystemUser.Employee.FullName;
                EmployeeComboBox.FillComboBox();
                EmployeeComboBox.SelectedItem = SystemUser.Employee;
            }
            ExpirationDateTimePicker.Value = SystemUser.ExpirationDate == null ? DateTime.Now : SystemUser.ExpirationDate.GetValueOrDefault();
            MultiSessionCheckBox.Checked = SystemUser.MultiSession;
        }

        protected bool ValidateEntity()
        {
            return ValidateForm(
                ValidateAssertNotZeroString(UsernameTextBox, "Ingrese el nombre de usuario", UsernameTextBox.Text.Trim()) &&
                ValidateAssertNotNull(EmployeeComboBox, "Seleccione un empleado", EmployeeComboBox.SelectedItem)
            );
        }

        protected bool Save()
        {
            if (ValidateEntity())
            {
                RefreshForm();
                Entity.Exceptions.DuplicatedExceptionResult<SystemUser> Duplicated = SystemUserRepository.findDuplicate(SystemUser);
                if (Duplicated.Reason == Entity.Exceptions.Reason.None)
                {
                    if (SystemUser.Id == Guid.Empty)
                    {
                        RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                        byte[] bytes = new byte[5];
                        rng.GetBytes(bytes);

                        BigInteger p = new BigInteger(bytes);
                        if (p.Sign == -1)
                        {
                            p = p * BigInteger.MinusOne;
                        }
                        SystemUser.Password = PasswordUtil.encryptPassword(p.ToString());
                        SystemUser.Enabled = true;

                        SystemUserRepository.SaveAndFlush(SystemUser);

                        MailUtil.SendMail(SystemUser.Employee.Email, "Nueva contraseña",
                            String.Format("La nueva contraseña para el usuario <b>{0}</b> es <b>{1}</b>", SystemUser.Username, p.ToString()));
                    }
                    else
                    {
                        SystemUserRepository.Update(SystemUser);
                    }
                    return true;
                }
                else
                {
                    if (Duplicated.Reason == Entity.Exceptions.Reason.Duplicated)
                    {
                        MessageDialog(Duplicated.Message, MessageBoxIcon.Exclamation);
                    }
                    else if (Duplicated.Reason == Entity.Exceptions.Reason.DuplicatedAndDeleted)
                    {
                        MessageDialog(Duplicated.Message, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageDialog(Duplicated.Message, MessageBoxIcon.Information);
                    }
                }
            }
            return false;
        }

        protected void FillEmployeeComboBox()
        {
            using (EmployeeRepository EmployeeRepository = new EmployeeRepository())
            {
                IQueryable<Employee> Employees = EmployeeRepository.FindForComboBox(EmployeeComboBox.QueryText, true, 20);
                EmployeeComboBox.FillComboBox<Employee>(Employees);
            }
        }
    }
}
