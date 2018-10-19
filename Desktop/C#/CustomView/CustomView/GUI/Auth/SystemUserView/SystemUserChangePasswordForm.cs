using Entity.Auth;
using GUI.CustomControls;
using Repository.Auth;
using System;
using System.Windows.Forms;
using Util;

namespace GUI.Auth.SystemUserView
{
    public partial class SystemUserChangePasswordForm : BaseForm
    {
        public SystemUserChangePasswordForm()
        {
            InitializeComponent();
            ButtonsContainer panelButtons = new ButtonsContainer();
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.SaveButton.Click += new EventHandler(this.BtnOk_click);
            panelButtons.CancelButton.Click += new EventHandler(this.BtnCancel_Click);
            ButtonsPanel.Controls.Add(panelButtons);
            StartPosition = FormStartPosition.CenterScreen;
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

        protected bool ValidateEntity()
        {
            return ValidateForm(
                ValidateAssertNotZeroString(CurrentPasswordTextBox, "Ingrese la contraseña actual", CurrentPasswordTextBox.Text.Trim()) &&
                ValidateAssertNotZeroString(NewPasswordTextBox, "Ingrese la nueva contraseña", NewPasswordTextBox.Text.Trim()) &&
                ValidateAssertNotZeroString(NewPasswordRTextBox, "Vuelva a ingresar la nueva contraseña", NewPasswordRTextBox.Text.Trim()) &&
                ValidateAssertEqual(NewPasswordRTextBox, "La nueva contraseña no coincide", NewPasswordTextBox.Text, NewPasswordRTextBox.Text)
            );
        }

        protected bool Save()
        {
            if (ValidateEntity())
            {
                if (CustomView.Program.Security.Session.User != null)
                {
                    if (CustomView.Program.Security.Session.User.Password.Equals(PasswordUtil.encryptPassword(CurrentPasswordTextBox.Text)))
                    {
                        using (SystemUserRepository SystemUserRepository = new SystemUserRepository())
                        {
                            SystemUser su = CustomView.Program.Security.Session.User;
                            su.Password = PasswordUtil.encryptPassword(NewPasswordTextBox.Text);
                            SystemUserRepository.Update(su);
                            MailUtil.SendMail(su.Employee.Email, "Cambio de contraseña.",
                                String.Format("Se ha cambiado la contraseña para el usuario <b>{0}</b> desde <b>{1}</b>.", su.Username, su.IPUpdate));
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
