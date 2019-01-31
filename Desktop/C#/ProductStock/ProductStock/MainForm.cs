using DataAccess;
using ProductStock.CustomControls;
using ProductStock.Views;
using Repository;
using System;
using System.Windows.Forms;

namespace ProductStock
{
    public partial class MainForm : Form
    {
        private Context Context;

        public MainForm(Context Context)
        {
            InitializeComponent();

            this.Context = Context;
            Util.WindowUtil.AssignMouseDown(Handle, TopPanel);

            WindowState = FormWindowState.Maximized;
        }

        private void LoadListForm(ListForm ListForm)
        {
            ListForm.MdiParent = this;
            ListForm.Refresh();
            ListForm.Visible = true;
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            LoadListForm(new ProductListForm(new ProductRepository(Context)));
        }

        private void CloseBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StoredProductButton_Click(object sender, EventArgs e)
        {
            LoadListForm(new StoredProductListForm(Context));
        }
    }
}
