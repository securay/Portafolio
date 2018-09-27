using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Util;

namespace GUI.CustomControls
{
    public partial class BaseForm : Form
    {
        #region Properties

        public override string Text
        {
            get
            {
                return base.Text;
            }

            set
            {
                base.Text = value;
                TitleLabel.Text = value;
            }
        }
        /*public Panel MainPanel
        {
            get
            {
                return _MainPanel;
            }
            set
            {
                _MainPanel = value;
            }
        }*/
        public Authentication.Security Security { get; set; }

        #endregion

        #region Hidden Properties

        protected ErrorProvider ErrorProvider;

        #endregion

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public BaseForm()
        {
            StartPosition = FormStartPosition.CenterScreen;

            ErrorProvider = new ErrorProvider(this);
            FormClosing += new FormClosingEventHandler(BaseForm_FormClosing);
            Load += new EventHandler(BaseForm_Load);
            VisibleChanged += new EventHandler(BaseForm_VisibleChanged);
            Security = CustomView.Program.Security;

            InitializeComponent();
        }

        public DialogResult ShowDialog(Form owner)
        {
            if (Modal) throw new InvalidOperationException("El formulario ya es un diálogo modal");
            this.MdiParent = null;
            if (Visible) Hide();
            return base.ShowDialog(owner);
        }

        #region Window Actions

        private void TitleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        protected void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                e.Cancel = true;
            }
        }

        protected void BaseForm_Load(object sender, EventArgs e)
        {
            new System.Threading.Thread(() =>
            {
                foreach (Control c in this.Controls)
                {
                    AssignAuditToButtonsRecursive(c);
                }
            }).Start();
        }

        protected void BaseForm_VisibleChanged(object sender, EventArgs e)
        {
            new System.Threading.Thread(() =>
            {
                if (Visible && Security != null)
                Security.Audit(this, "LoadForm", "Abrir formulario");
            }).Start();
        }

        public void AssignControlStylesRecursive(Control control)
        {
            Label lbl = control as Label;
            if (lbl != null)
            {
                lbl.BackColor = Color.Transparent;
                return;
            }

            TextBox txt = control as TextBox;
            ComboBox cbo = control as ComboBox;
            if (txt != null || cbo != null)
            {
                control.ForeColor = Color.FromArgb(76, 116, 164);
                return;
            }

            foreach (Control c in control.Controls)
            {
                AssignControlStylesRecursive(c);
            }
        }

        private void AssignAuditToButtonsRecursive(Control control)
        {
            Button btn = control as Button;
            if (btn != null)
            {
                btn.Click += new EventHandler(AuditButton_Click);
            }
            else
            {
                foreach (Control c in control.Controls)
                {
                    AssignAuditToButtonsRecursive(c);
                }
            }
        }

        #endregion

        #region Control Actions
        
        private void MinimizePictureBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ClosePictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected void AuditButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Security.Audit(this, btn.Name, btn.Text);
        }

        #endregion

        #region Validación

        protected void ShowValidationErrorMessage()
        {
            MessageDialog("Han ocurrido errores de validación", MessageBoxIcon.Error);
        }

        protected bool ValidateForm(bool valid)
        {
            if (!valid)
                ShowValidationErrorMessage();
            return valid;
        }

        protected bool ValidateAssertEqual(Control c, string m, object v1, object v2)
        {
            bool set = !DataValidationUtil.AssertEqual(v1, v2);
            ErrorProvider.SetIconPadding(c, -20);
            SetControlErrorMessage(c, set, m);
            return !set;
        }

        protected bool ValidateAssertNotEqual(Control c, string m, object v1, object v2)
        {
            bool set = DataValidationUtil.AssertEqual(v1, v2);
            ErrorProvider.SetIconPadding(c, -20);
            SetControlErrorMessage(c, set, m);
            return !set;
        }

        protected bool ValidateAssertNotZeroString(Control c, string m, string v)
        {
            bool set = !DataValidationUtil.AssertNotZeroString(v);
            ErrorProvider.SetIconPadding(c, -20);
            SetControlErrorMessage(c, set, m);
            return !set;
        }

        protected bool ValidateAssertNotNull(Control c, string m, object v)
        {
            bool set = !DataValidationUtil.AssertNotNull(v);
            ErrorProvider.SetIconPadding(c, -40);
            SetControlErrorMessage(c, set, m);
            return !set;
        }

        protected bool ValidateAssertNotZeroValue(Control c, string m, long v)
        {
            bool set = !DataValidationUtil.AssertNotZeroValue(v);
            ErrorProvider.SetIconPadding(c, -40);
            SetControlErrorMessage(c, set, m);
            return !set;
        }

        protected bool ValidateAssertNotZeroValue(Control c, string m, double v)
        {
            bool set = !DataValidationUtil.AssertNotZeroValue(v);
            ErrorProvider.SetIconPadding(c, -40);
            SetControlErrorMessage(c, set, m);
            return !set;
        }

        protected bool ValidateAssertNotZeroValue(Control c, string m, decimal v)
        {
            bool set = !DataValidationUtil.AssertNotZeroValue(v);
            ErrorProvider.SetIconPadding(c, -40);
            SetControlErrorMessage(c, set, m);
            return !set;
        }

        protected void SetControlErrorMessage(Control c, bool set, string message)
        {
            if (set)
            {
                ErrorProvider.SetError(c, message);
            }
            else
            {
                ErrorProvider.SetError(c, "");
            }
        }

        protected bool ValidateEmail(Control control, string message, string value)
        {
            System.Text.RegularExpressions.Regex regex;
            regex = new System.Text.RegularExpressions.Regex(@"^[\w-.]+@([\w-]+\.)+[\w-]+$");
            ErrorProvider.SetIconPadding(control, -20);
            if (regex.IsMatch(control.Text) || control.Text == "")
            {
                ErrorProvider.SetError(control, "");
                return true;
            }
            else
            {
                ErrorProvider.SetError(control, (message ?? "No es una dirección electrónica válida."));
                return false;
            }
        }

        #endregion
        
        #region Atajos para cuadros de mensajes

        protected DialogResult MessageDialog(string message)
        {
            return MessageBox.Show(this, message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        protected DialogResult MessageDialog(string message, MessageBoxIcon icon)
        {
            return MessageBox.Show(this, message, this.Text, MessageBoxButtons.OK, icon);
        }
        protected DialogResult MessageDialog(string message, MessageBoxIcon icon, MessageBoxButtons buttons)
        {
            return MessageBox.Show(this, message, this.Text, buttons, icon);
        }

        #endregion
    }
}
