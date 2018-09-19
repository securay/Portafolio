using System;
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
        
        private void BoxButton_Click(object sender, EventArgs e)
        {
            CustomControls.BaseForm f = new CustomControls.BaseForm();
            f.MdiParent = this;
            f.Refresh();
            f.Visible = true;
        }
    }
}
