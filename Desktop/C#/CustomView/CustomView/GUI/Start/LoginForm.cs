using CustomView;
using System.Windows.Forms;
using Util;

namespace GUI.Start
{
    public partial class LoginForm : Form
    {
        System.ComponentModel.BackgroundWorker Worker;
        public LoginForm()
        {
            CheckForIllegalCrossThreadCalls = false;

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Util.WindowUtil.AssignMouseDown(this.Handle, LogoPictureBox);
            Util.WindowUtil.AssignMouseDown(this.Handle, this);
            Util.WindowUtil.AssignMouseDown(this.Handle, TitleLabel);
            Program.Security = new Authentication.Security(); ;

            Worker = new System.ComponentModel.BackgroundWorker();
            Worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            Worker.DoWork += Worker_DoWork; ;
        }

        private void Worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            LoginButton.Enabled = true;
            if(!Visible)
            {
                new MainForm().Show();
            }
        }

        private void Worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            _DoLogin();
        }

        private void ClosePictureBox_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            DoLogin();
        }

        private void DoLogin()
        {
            LoginButton.Enabled = false;
            Worker.RunWorkerAsync();
        }

        private void _DoLogin()
        {
            Cursor = Cursors.WaitCursor;
            if (UserNameTextBox.Text.Length > 0 && UserNameTextBox.ForeColor == System.Drawing.Color.LightGray)
            {
                if (Program.Security.UserExists(UserNameTextBox.Text))
                {
                    if (Program.Security.UserIsActive(UserNameTextBox.Text))
                    {
                        if (PasswordTextBox.Text.Length > 0)
                        {
                            if (Program.Security.RequestLogin(UserNameTextBox.Text, PasswordTextBox.Text))
                            {
                                if (Program.Security.Session.User.UserExpires && 
                                        Program.Security.Session.User.ExpirationDate < Program.Security.ApplicationContext.GetCurrentTime())
                                {
                                    ShowMessage("El usuario ha expirado.");
                                }
                                else
                                {
                                    Visible = false;
                                    
                                }
                            }
                            else
                            {
                                Entity.Auth.SystemUser SystemUser = Program.Security.GetSystemUserByName(UserNameTextBox.Text);
                                if (SystemUser.LoginFailures >= 3)
                                {
                                    ShowMessage(string.Format("La contraseña ingresada es incorrecta. \nLa cuenta ha sido bloqueada hasta {0}", 
                                                                SystemUser.UnLockTime.Value.ToString("dd/MM/yyyy HH:mm:ss")));
                                }
                                else
                                {
                                    ShowMessage("La contraseña ingresada es incorrecta.");
                                }
                            }
                        }
                        else
                        {
                            ShowMessage("Debe ingresar su contraseña");
                        }
                    }
                    else
                    {
                        ShowMessage("El usuario no está activo.");
                    }
                }
                else
                {
                    ShowMessage("El usuario ingresado no existe.");
                }
            }
            else
            {
                if (PasswordTextBox.Text.Length > 0 && PasswordTextBox.ForeColor == System.Drawing.Color.LightGray)
                {
                    ShowMessage("Debe ingresar su nombre de usuario.");
                }
                else
                {
                    ShowMessage("Debe ingresar su nombre de usuario y contraseña.");
                }
            }
            Cursor = Cursors.Default;
        }

        public void ShowMessage(string Message)
        {
            MessageBox.Show(this, Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                DoLogin();
        }

        private void UserNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                DoLogin();
        }
    }
}
