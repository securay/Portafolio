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
                        Menus.Add(CurrentMenuButton.EntityName, CurrentMenuButton);
                    }
                }
                foreach (var Permission in Permissions)
                {
                    if(Menus.ContainsKey(Permission.SystemMenu.Name))
                    {
                        Menus[Permission.SystemMenu.Name].Enabled = Permission.Allow;
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
    }
}
