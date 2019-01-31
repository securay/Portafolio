using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhotoSelector
{
    public partial class InputBox : Form
    {
        public InputBox(string Title, string Message, int Min, int Max)
        {
            InitializeComponent();
            ValueTextBox.Minimum = Min;
            ValueTextBox.Maximum = Max;
            MessageLabel.Text = Message;
            Text = Title;
        }

        public int ShowInputDialog()
        {
            ValueTextBox.Value = ValueTextBox.Minimum;
            ShowDialog();
            return (int)ValueTextBox.Value;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Visible = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Visible = false;
        }
    }
}
