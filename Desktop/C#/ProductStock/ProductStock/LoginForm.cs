using DataAccess;
using Entity;
using Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProductStock
{
    public partial class LoginForm : Form
    {
        private Context Context;
        private SystemUserRepository SystemUserRepository;

        public LoginForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            Context = new Context();
            SystemUserRepository = new SystemUserRepository(Context);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(UserTextBox.Text.Length > 0)
            {
                if(PasswordTextBox.Text.Length > 0)
                {
                    IQueryable<SystemUser> res = SystemUserRepository.ValidateUser(UserTextBox.Text, PasswordTextBox.Text);
                    if(res.Count() == 1)
                    {
                        new MainForm(Context).Visible = true;
                        Visible = false;
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
            else
            {

            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                LoginButton_Click(sender, e);
        }

        private void UserTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                LoginButton_Click(sender, e);
        }
    }
}
