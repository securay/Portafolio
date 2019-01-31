using ProductStock.CustomControls;
using Repository;
using System.Linq;

namespace ProductStock.Views
{
    public partial class ProductListForm : ListForm
    {
        private ProductRepository ProductRepository;

        public ProductListForm(ProductRepository ProductRepository)
        {
            InitializeComponent();

            this.ProductRepository = ProductRepository;

            Init();
        }

        private void Init()
        {
            AddButton.Click += AddButton_Click;

            Titles.Add("ProductName", "PRODUCTO");
            Titles.Add("ProductCode", "CODIGO");
            Titles.Add("SunatProductCode", "CODIGO SUNAT");
            Titles.Add("Perecible", "PERECIBLE");
            Titles.Add("MinStock", "STOCK MIN");
            Titles.Add("NominalValue", "PRECIO REFERENCIAL");
            Titles.Add("AddOnElectronicDocument", "DOC. ELECTRONICO");

            LoadProducts();
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            if (new ProductForm(ProductRepository).ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LoadProducts();
            }
        }

        public void LoadProducts()
        {
            Grid.DataSource = ProductRepository.FindAllProductRow(true).ToList();

            HideAuditColumns();
        }
    }
}
