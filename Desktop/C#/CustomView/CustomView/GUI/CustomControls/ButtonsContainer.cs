using System.Windows.Forms;

namespace GUI.CustomControls
{
    public partial class ButtonsContainer : UserControl
    {
        public ButtonsContainer()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            SaveButton.Enabled = false;
            CancelButton.Enabled = false;
        }
    }
}
