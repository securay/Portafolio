using CustomView;
using Entity.Auth;
using System;
using System.Windows.Forms;
using System.Linq;
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
            Logger.Log("Completed " + Visible.ToString(), Logger.INFO);
            if(!Visible)
            {
                new MainForm().Show();
            }
            LoginButton.Enabled = true;
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
            /*
            using (var context = new Context.ApplicationContext())
            {
                var dependency_level = context.DependencyLevels.FirstOrDefault(dl => dl.Name == "Administración");
                if (dependency_level == null)
                {
                    dependency_level = new DependencyLevel()
                    {
                        Active = true,
                        DateInsert = DateTime.Now,
                        Id = Guid.NewGuid(),
                        IdInsert = Guid.Empty,
                        IPInsert = Util.NetworkUtil.LocalIPAddress(),
                        Name = "Administración"
                    };
                    context.DependencyLevels.Add(dependency_level);
                    context.SaveChanges();
                }
                var dependency = context.Dependencies.FirstOrDefault(d => d.Acronym == "TI");
                if (dependency == null)
                {
                    dependency = new Dependency()
                    {
                        Active = true,
                        Acronym = "TI",
                        DependencyLevel = dependency_level,
                        Name = "TI",
                        DateInsert = DateTime.Now,
                        Id = Guid.NewGuid(),
                        IdInsert = Guid.Empty,
                        IPInsert = Util.NetworkUtil.LocalIPAddress()
                    };
                    context.Dependencies.Add(dependency);
                    context.SaveChanges();
                }
                var document_type = context.DocumentTypes.FirstOrDefault(dt => dt.Acronym == "DNI");
                if (document_type == null)
                {
                    document_type = new DocumentType()
                    {
                        Active = true,
                        Acronym = "DNI",
                        Name = "Documento Nacional de Identidad",
                        DateInsert = DateTime.Now,
                        Id = Guid.NewGuid(),
                        IdInsert = Guid.Empty,
                        IPInsert = Util.NetworkUtil.LocalIPAddress()
                    };
                    context.DocumentTypes.Add(document_type);
                    context.SaveChanges();
                }
                var position = context.Positions.FirstOrDefault(p => p.Name == "Gerente");
                if (position == null)
                {
                    position = new Position()
                    {
                        Active = true,
                        Name = "Gerente",
                        DateInsert = DateTime.Now,
                        Id = Guid.NewGuid(),
                        IdInsert = Guid.Empty,
                        IPInsert = Util.NetworkUtil.LocalIPAddress()
                    };
                    context.Positions.Add(position);
                    context.SaveChanges();
                }
                var admin_e = context.Employees.FirstOrDefault(e => e.PersonName == "sa");
                if (admin_e == null)
                {
                    admin_e = new Employee()
                    {
                        Active = true,
                        Address = "None",
                        Dependency = dependency,
                        DocumentNumber = "00000000",
                        PaternalSurname = "Super",
                        MaternalSurname = "Admin",
                        PersonName = "SA",
                        Email = "",
                        Phone = "",
                        DocumentType = document_type,
                        Position = position,
                        DateInsert = DateTime.Now,
                        Id = Guid.NewGuid(),
                        IdInsert = Guid.Empty,
                        IPInsert = Util.NetworkUtil.LocalIPAddress()
                    };
                    context.Employees.Add(admin_e);
                    context.SaveChanges();
                }
                var admin = context.SystemUsers.FirstOrDefault(su => su.Username == "sa");
                if (admin == null)
                {
                    admin = new SystemUser()
                    {
                        Active = true,
                        Employee = admin_e,
                        Enabled = true,
                        ExpirationDate = DateTime.MaxValue,
                        MultiSession = true,
                        Password = Util.PasswordUtil.encryptPassword("Passw0rd123"),
                        Username = "sa",
                        DateInsert = DateTime.Now,
                        Id = Guid.NewGuid(),
                        IdInsert = Guid.Empty,
                        IPInsert = Util.NetworkUtil.LocalIPAddress()
                    };
                    context.SystemUsers.Add(admin);
                    context.SaveChanges();
                }
            }
            */
            Cursor = Cursors.WaitCursor;
            if (UserNameTextBox.Text.Length > 0 && UserNameTextBox.ForeColor == System.Drawing.Color.LightGray)
            {
                Logger.Log("User Exist " + Program.Security.UserExists(UserNameTextBox.Text).ToString(), Logger.INFO);
                if (Program.Security.UserExists(UserNameTextBox.Text))
                {
                    Logger.Log("User Is Active", Logger.INFO);
                    if (Program.Security.UserIsActive(UserNameTextBox.Text))
                    {
                        if (PasswordTextBox.Text.Length > 0)
                        {
                            Logger.Log("Request Login", Logger.INFO);
                            if (Program.Security.RequestLogin(UserNameTextBox.Text, PasswordTextBox.Text))
                            {
                                Logger.Log("User Exist", Logger.INFO);
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
