using CustomView;
using System.Windows.Forms;
using Util;

namespace GUI.Start
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Util.WindowUtil.AssignMouseDown(this.Handle, LogoPictureBox);
            Util.WindowUtil.AssignMouseDown(this.Handle, this);
            Util.WindowUtil.AssignMouseDown(this.Handle, TitleLabel);
            Program.Security = new Authentication.Security(); ;
        }

        private void ClosePictureBox_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, System.EventArgs e)
        {
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
                                Cursor = Cursors.WaitCursor;

                                new MainForm().Show();
                                Visible = false;

                                Cursor = Cursors.Default;
                            }
                            else
                            {
                                ShowMessage("La contraseña ingresada es incorrecta.");
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
        }

        public void ShowMessage(string Message)
        {
            MessageBox.Show(this, Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                LoginButton_Click(sender, e);
        }

        private void UserNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                LoginButton_Click(sender, e);
        }
    }
}
