using Entity;
using ProductStock.CustomControls;
using Repository;
using System;
using System.Windows.Forms;

namespace ProductStock.Views
{
    public partial class ProductForm : EntityForm
    {
        private ProductRepository ProductRepository;

        public ProductForm(ProductRepository ProductRepository)
        {
            InitializeComponent();

            this.ProductRepository = ProductRepository;

            Init();
        }

        public void SetCode(string Code)
        {
            CodeTextBox.Text = Code;
        }

        private void Init()
        {
            MinStockTextBox.KeyPress += Util.OnlyNumbers.OnlyNumbers_KeyPress;
            PriceTextBox.KeyPress += Util.OnlyDecimalNumbers.OnlyDecimalNumbers_KeyPress;
            CodeTextBox.KeyPress += CodeTextBox_KeyPress;
            SaveButton.Click += SaveButton_Click;
        }

        private void CodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                SaveButton.Focus();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(NameTextBox.TextLength > 0 && CodeTextBox.TextLength > 0)
            {
                Product product = new Product()
                {
                    AddOnElectronicDocument = ElectronicDocumentCheckBox.Checked,
                    Code = CodeTextBox.Text,
                    MinStock = int.Parse(MinStockTextBox.Text),
                    Name = NameTextBox.Text,
                    NominalValue = decimal.Parse(PriceTextBox.Text),
                    SunatCode = SunatCodeTextBox.Text
                };
                ProductRepository.SaveAndFlush(product);
                ShowSavedDialog();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Complete los datos requeridos", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
