using DataAccess;
using Entity;
using ProductStock.CustomControls;
using Repository;
using System.Linq;
using System.Windows.Forms;
using Util;

namespace ProductStock.Views
{
    public partial class StoredProductForm : EntityForm
    {
        private Context Context;
        private StoreRepository StoreRepository;
        private ProductRepository ProductRepository;
        private StoredProductRepository StoredProductRepository;
        private ComponentRepository ComponentRepository;

        private Product CurrentProduct;
        private Product CurrentComponent;
        private StoredProduct CurrentStoredProduct;

        public StoredProductForm(Context Context)
        {
            InitializeComponent();

            this.Context = Context;

            Init();
        }

        private void Init()
        {
            StoreRepository = new StoreRepository(Context);
            ProductRepository = new ProductRepository(Context);
            StoredProductRepository = new StoredProductRepository(Context);
            ComponentRepository = new ComponentRepository(Context);

            LoadStores();

            ProductCodeTextBox.KeyPress += ProductCodeTextBox_KeyPress;
            ProductNameTextBox.KeyPress += ProductNameTextBox_KeyPress;

            SerialTextBox.KeyPress += SerialTextBox_KeyPress;
            PartNumberTextBox.KeyPress += PartNumberTextBox_KeyPress;
            PartSerialTextBox.KeyPress += PartSerialTextBox_KeyPress;

            ButtonsPanel.Visible = false;
        }

        private void PartSerialTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                bool res = true;
                if(PartSerialTextBox.TextLength == 0)
                {
                    res = MessageBox.Show(
                            "¿Está seguro de agregar una serie vacia?",
                            Text,
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes;
                }

                if(res)
                {
                    Entity.Component component = new Entity.Component()
                    {
                        Buyed = 1,
                        Product = CurrentComponent,
                        SerialNumber = PartSerialTextBox.Text,
                        Stock = 1,
                        StoredProduct = CurrentStoredProduct
                    };
                    ComponentRepository.SaveAndFlush(component);
                    FillComponents();
                    PartSerialTextBox.Text = "";
                    PartNumberTextBox.Text = "";
                    PartNumberTextBox.Focus();
                }
            }
        }

        private void PartNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (PartNumberTextBox.TextLength > 0)
                {
                    CurrentComponent = ProductRepository.GetByCode(PartNumberTextBox.Text);
                    if (CurrentComponent == null)
                    {
                        ProductForm productForm = new ProductForm(ProductRepository);
                        productForm.SetCode(PartNumberTextBox.Text);
                        if(productForm.ShowDialog() == DialogResult.OK)
                        {
                            CurrentComponent = ProductRepository.GetByCode(PartNumberTextBox.Text);
                        }
                    }
                    PartSerialTextBox.Text = "";
                    PartSerialTextBox.Focus();
                }
            }
        }

        private void SerialTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (SerialTextBox.TextLength > 0)
                {
                    CurrentStoredProduct = StoredProductRepository.GetBySerial(SerialTextBox.Text);
                    if (CurrentStoredProduct == null)
                    {
                        CurrentStoredProduct = new StoredProduct()
                        {
                            Buyed = 1,
                            Price = 0,
                            Product = CurrentProduct,
                            SerialNumber = SerialTextBox.Text,
                            Stock = 1,
                            Store = StoreComboBox.SelectedItem as Store
                        };
                        StoredProductRepository.SaveAndFlush(CurrentStoredProduct);
                        ShowSavedDialog();
                        SerialTextBox.Text = "";
                    }
                    else
                    {
                        FillComponents();
                        CurrentComponent = null;
                        PartNumberTextBox.Text = "";
                        PartNumberTextBox.Focus();
                        PartSerialTextBox.Text = "";
                    }
                }
            }
        }

        private void FillComponents()
        {
            if(CurrentStoredProduct != null)
            {
                Grid.DataSource = ComponentRepository.GetByStoredProductAndName(CurrentStoredProduct, "").ToList();

                HideAuditColumns();
            }
        }

        private void ProductNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (ProductNameTextBox.TextLength > 0)
                {
                    if (CurrentProduct == null)
                    {
                        CurrentProduct = new Product()
                        {
                            AddOnElectronicDocument = true,
                            Code = ProductCodeTextBox.Text,
                            MinStock = 0,
                            Name = ProductNameTextBox.Text,
                            NominalValue = 0,
                            Perecible = false,
                            SunatCode = ""
                        };
                        ProductRepository.SaveAndFlush(CurrentProduct);
                        ShowSavedDialog();
                    }
                }
            }
        }

        private void ProductCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if(ProductCodeTextBox.TextLength > 0)
                {
                    CurrentProduct = ProductRepository.GetByCode(ProductCodeTextBox.Text);
                    if(CurrentProduct == null)
                    {
                        MessageBox.Show(
                            "No se ha registrado el producto, por favor ingrese el nombre y luego presione enter", 
                            Text, 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
                        ProductNameTextBox.Text = "";
                        ProductNameTextBox.Focus();
                    }
                    else
                    {
                        ProductNameTextBox.Text = CurrentProduct.Name;
                        SerialTextBox.Text = "";
                        SerialTextBox.Focus();
                        CurrentStoredProduct = null;
                        CurrentComponent = null;
                        PartNumberTextBox.Text = "";
                        PartSerialTextBox.Text = "";
                    }
                }
            }
        }

        public void LoadStores()
        {
            StoreComboBox.DisplayMember = "Name";
            StoreComboBox.ValueMember = "Id";
            StoreComboBox.FillComboBox(StoreRepository.GetStores("", 0).ToList());

            if (StoreComboBox.Items.Count > 0)
            {
                StoreComboBox.SelectedIndex = 0;
            }
        }

        private void HideAuditColumns()
        {
            string[] defaultColumnsToHide = new string[] { "Id", "active",
                "IdInsert", "IpInsert", "DateInsert",
                "IdUpdate", "IpUpdate", "DateUpdate",
                "IdDelete", "IpDelete", "DateDelete"};

            for (int i = 0; i < defaultColumnsToHide.Length; i++)
            {
                if (Grid.Columns.Contains(defaultColumnsToHide[i]))
                {
                    Grid.Columns[defaultColumnsToHide[i]].Visible = false;
                }
            }
        }
    }
}
