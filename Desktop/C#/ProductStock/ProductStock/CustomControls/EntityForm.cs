using System.Windows.Forms;

namespace ProductStock.CustomControls
{
    public partial class EntityForm : Form
    {
        public EntityForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        public void ShowSavedDialog()
        {
            MessageBox.Show("Se guardó el registro correctamente", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
