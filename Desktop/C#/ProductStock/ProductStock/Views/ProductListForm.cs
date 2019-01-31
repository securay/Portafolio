using ProductStock.CustomControls;
using Repository;
using System;
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
            LoadProducts();
            AddButton.Click += AddButton_Click;
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
