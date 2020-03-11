using Entity.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI.Start
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Util.WindowUtil.AssignMouseDown(this.Handle, HeadPanel);

            UserLabel.Text = String.Format("{0} / {1}",
                                            CustomView.Program.Security.Session.User.Username.ToUpper(),
                                            CustomView.Program.Security.Session.User.Employee.FullName.ToUpper());
            LastConnectionLabel.Text = CustomView.Program.Security.Session.User.LastAccess.Value.ToString("dd/MM/yyyy HH:mm");
            //AddMenues();
            LoadPermissions();
        }

        private void ClosePictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaximizePictureBox_Click(object sender, EventArgs e)
        {
            MaximizePictureBox.Visible = false;
            RestorePictureBox.Visible = true;
            WindowState = FormWindowState.Maximized;
        }

        private void MinimizePictureBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void RestorePictureBox_Click(object sender, EventArgs e)
        {
            MaximizePictureBox.Visible = true;
            RestorePictureBox.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void MenuPictureBox_Click(object sender, EventArgs e)
        {
            MenuPanel.Width = MenuPanel.Width == 250 ? 60 : 250;
        }

        private void LoadPermissions()
        {
            using (Repository.Auth.SystemUserMenuPermissionRepository SystemUserMenuPermissionRepository =
                                                                        new Repository.Auth.SystemUserMenuPermissionRepository())
            using (Repository.Auth.SystemMenuRepository SystemMenuRepository = new Repository.Auth.SystemMenuRepository())
            {
                List<Entity.Auth.SystemUserMenuPermission> Permissions = 
                                SystemUserMenuPermissionRepository.ListByUser(CustomView.Program.Security.Session.User).ToList();
                List<CustomView.GUI.CustomControls.MenuButton> Buttons = new List<CustomView.GUI.CustomControls.MenuButton>();
                Dictionary<String, CustomView.GUI.CustomControls.MenuButton> Menus = new Dictionary<string, CustomView.GUI.CustomControls.MenuButton>();
                CustomView.GUI.CustomControls.MenuButton CurrentMenuButton;
                foreach (var Control in MenuPanel.Controls)
                {
                    if (Control is CustomView.GUI.CustomControls.MenuButton)
                    {
                        CurrentMenuButton = (CustomView.GUI.CustomControls.MenuButton)Control;
                        Util.Logger.Log(CurrentMenuButton.EntityName, Util.Logger.INFO);
                        Menus.Add(CurrentMenuButton.EntityName, CurrentMenuButton);
                    }
                }
                foreach (var Permission in Permissions)
                {
                    if (Menus.ContainsKey(Permission.SystemMenu.Name))
                    {
                        Util.Logger.Log(Permission.Active.ToString(), Util.Logger.INFO);
                        Menus[Permission.SystemMenu.Name].Enabled = Permission.Allow;
                    }
                }
            }
        }

        private void AddMenues()
        {
            using (var SystemUserRepository = new Repository.Auth.SystemUserRepository())
            using (var SystemMenuRepository = new Repository.Auth.SystemMenuRepository())
            using (var SystemUserMenuPermissionRepository = new Repository.Auth.SystemUserMenuPermissionRepository())
            {
                CustomView.GUI.CustomControls.MenuButton CurrentMenuButton;
                var SA = SystemUserRepository.GetByName("sa");
                foreach (var Control in MenuPanel.Controls)
                {
                    if (Control is CustomView.GUI.CustomControls.MenuButton)
                    {
                        CurrentMenuButton = (CustomView.GUI.CustomControls.MenuButton)Control;
                        if (SystemMenuRepository.GetByName(CurrentMenuButton.EntityName) == null)
                        {
                            var SystemMenu = new SystemMenu()
                            {
                                Caption = CurrentMenuButton.Text,
                                Name = CurrentMenuButton.EntityName
                            };
                            SystemMenuRepository.SaveAndFlush(SystemMenu);
                            var SystemUserMenuPermission = new SystemUserMenuPermission()
                            {
                                Activate = true,
                                Allow = true,
                                Delete = true,
                                Export = true,
                                Extras = true,
                                Insert = true,
                                List = true,
                                Update = true,
                                SystemMenu = SystemMenu,
                                SystemUser = SA
                            };
                            SystemUserMenuPermissionRepository.SaveAndFlush(SystemUserMenuPermission);
                        }
                    }
                }
            }
        }
        
        private void LoadForm(CustomControls.BaseForm Form)
        {
            Form.MdiParent = this;
            Form.Refresh();
            Form.Visible = true;
        }

        private void CoolersButton_Click(object sender, EventArgs e)
        {
            LoadForm(new View.CoolerView.CoolerListForm());
        }

        private void HeadPanel_DoubleClick(object sender, EventArgs e)
        {

        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            LoadForm(new View.CustomerView.CustomerListForm());
        }

        private void ServiceOrderButton_Click(object sender, EventArgs e)
        {
            LoadForm(new View.ServiceOrderView.ServiceOrderListForm());
        }

        private void ServiceOrderCoolerButton_Click(object sender, EventArgs e)
        {
            LoadForm(new View.ServiceOrderDetailView.ServiceOrderDetailListForm());
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            LoadForm(new Auth.EmployeeView.EmployeeListForm());
        }

        private void SystemUserButton_Click(object sender, EventArgs e)
        {
            LoadForm(new Auth.SystemUserView.SystemUserListForm());
        }

        private void PermissionsButton_Click(object sender, EventArgs e)
        {
            LoadForm(new Auth.PermissionsView.PermissionsForm());
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            LoadForm(new Auth.SystemUserView.SystemUserChangePasswordForm());
        }
    }
}
