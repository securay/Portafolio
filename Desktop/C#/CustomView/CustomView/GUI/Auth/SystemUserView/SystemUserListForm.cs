using Entity.Auth;
using Entity.Auth.Extra;
using GUI.CustomControls;
using Repository.Auth;
using System;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Windows.Forms;
using Util;

namespace GUI.Auth.SystemUserView
{
    public partial class SystemUserListForm : BaseForm, ILoadData
    {
        private PaginableDataGrid<SystemUserRow> Grid;
        private SystemUserRepository SystemUserRepository;
        private ToolStripButton ResetPasswordButton;

        public SystemUserListForm()
        {
            SystemUserRepository = new SystemUserRepository();
            InitializeComponent();
            InitializeGrid();
            StartPosition = FormStartPosition.CenterScreen;
            Refresh();
            LoadData();
        }

        protected void InitializeGrid()
        {
            Grid = new PaginableDataGrid<SystemUserRow>(this);
            Grid.CastSourceQueryToList = true;
            Grid.AddToolStripButton.Click += new EventHandler(BtnAdd_Click);
            Grid.ReloadToolStripButton.Click += new EventHandler(BtnRefresh_Click);
            Grid.DeleteToolStripButton.Click += new EventHandler(BtnDelete_Click);
            Grid.ReactivateToolStripButton.Click += new EventHandler(BtnActivate_Click);
            Grid.EditToolStripButton.Click += new EventHandler(BtnEdit_Click);

            ResetPasswordButton = new ToolStripButton("", ResetPassworPictureBox.Image, new EventHandler(BtnReset_Password_Click));
            Grid.MainToolStrip.Items.Add(ResetPasswordButton);

            Grid.HeaderTexts["Username"] = "Usuario";
            Grid.HeaderTexts["EntityName"] = "Nombre";
            GridPanel.Controls.Add(Grid);
        }

        public void LoadData()
        {
            var result = SystemUserRepository.findAllSystemUserRow(FindTextBox.Text, Grid.ShowActive, 0);
            Grid.SourceQuery = result;
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            SystemUserForm Form = new SystemUserForm(SystemUserRepository);
            Form.Create();
            if (Form.ShowDialog(this) == DialogResult.OK)
            {
                LoadData();
            }
        }

        protected void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            if (Grid.SelectedEntity == null)
            {
                MessageDialog(MessageUtil.GlobalSelectRow, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageDialog(String.Format(MessageUtil.GlobalDeleteConfirm, 
                Grid.SelectedEntity.EntityName), MessageBoxIcon.Question, MessageBoxButtons.YesNo) 
                == DialogResult.No)
                return;
            SystemUser SystemUser = SystemUserRepository.findById(Grid.SelectedEntity.Id);
            SystemUserRepository.SoftDelete(SystemUser);
            LoadData();
        }

        protected void BtnActivate_Click(object sender, EventArgs e)
        {
            if (Grid.SelectedEntity == null)
            {
                MessageDialog(MessageUtil.GlobalSelectRow, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageDialog(String.Format(MessageUtil.GlobalActivateConfirm,
                Grid.SelectedEntity.EntityName), MessageBoxIcon.Question, MessageBoxButtons.YesNo)
                == DialogResult.No)
                return;
            SystemUser SystemUser = SystemUserRepository.findById(Grid.SelectedEntity.Id);
            SystemUserRepository.Reactivate(SystemUser);
            LoadData();
        }

        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            if (Grid.SelectedEntity == null)
            {
                MessageDialog(MessageUtil.GlobalSelectRow, MessageBoxIcon.Exclamation);
                return;
            }
            
            SystemUserForm form = new SystemUserForm(SystemUserRepository);
            form.Edit(Grid.SelectedEntity.Id);
            if (form.ShowDialog(this) == DialogResult.OK)
                LoadData();
        }

        protected void BtnReset_Password_Click(object sender, EventArgs e)
        {
            SystemUserRow dt = Grid.SelectedEntity;
            if (dt != null)
            {
                if (MessageDialog(MessageUtil.GlobalResetPassword, 
                    MessageBoxIcon.Question, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                    byte[] bytes = new byte[5];
                    rng.GetBytes(bytes);

                    BigInteger p = new BigInteger(bytes);
                    if (p.Sign == -1)
                    {
                        p = p * BigInteger.MinusOne;
                    }
                    SystemUser SystemUser = SystemUserRepository.findById(dt.Id);
                    SystemUser.Password = PasswordUtil.encryptPassword(p.ToString());

                    SystemUserRepository.Update(SystemUser);

                    MailUtil.SendMail(SystemUser.Employee.Email,
                        "Cambio de contraseña.",
                        String.Format("Se ha asignado una nueva contraseña para acceder al sistema de Cupones. " + 
                        "<br/> <table border=0><tr><td style=\"text - align:right\">Usuario:</td><td>{0}</td></tr>" + 
                        "<tr><td style=\"text - align:right\">Contraseña:</td><td>{1}</td></tr></table>", SystemUser.Username, p.ToString()));
                    MessageDialog(MessageUtil.GlobalRecordSaved, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageDialog(MessageUtil.GlobalSelectRow, MessageBoxIcon.Exclamation);
            }
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
