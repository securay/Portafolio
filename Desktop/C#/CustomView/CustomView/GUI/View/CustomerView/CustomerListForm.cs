using Entity.Coolers;
using GUI.CustomControls;
using Repository.Coolers;
using System;
using System.Windows.Forms;

namespace GUI.View.CustomerView
{
    public partial class CustomerListForm : BaseForm, Util.ILoadData
    {
        protected CustomerRepository CustomerRepository;
        private PaginableDataGrid<Customer> PaginableDataGrid;
        public CustomerListForm()
        {
            CustomerRepository = new CustomerRepository();

            InitializeComponent();

            InitializeGrid();
            StartPosition = FormStartPosition.CenterScreen;
            Refresh();
            LoadData();
        }

        protected void InitializeGrid()
        {
            PaginableDataGrid = new PaginableDataGrid<Customer>(this);
            PaginableDataGrid.Grid.ReadOnly = true;
            PaginableDataGrid.CastSourceQueryToList = true;
            PaginableDataGrid.AddToolStripButton.Click += new EventHandler(BtnAdd_Click);
            PaginableDataGrid.ReloadToolStripButton.Click += new EventHandler(BtnRefresh_Click);
            PaginableDataGrid.DeleteToolStripButton.Click += new EventHandler(BtnDelete_Click);
            PaginableDataGrid.ReactivateToolStripButton.Click += new EventHandler(BtnActivate_Click);
            PaginableDataGrid.EditToolStripButton.Click += new EventHandler(BtnEdit_Click);


            PaginableDataGrid.Grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            PaginableDataGrid.HeaderTexts["RUC"] = "RUC";
            PaginableDataGrid.HeaderTexts["Name"] = "Nombre";
            PaginableDataGrid.HeaderTexts["Description"] = "Descripción";

            GridPanel.Controls.Add(PaginableDataGrid);
        }
        public void LoadData()
        {
            var res = CustomerRepository.FindAllRow(QueryTextBox.Text, PaginableDataGrid.ShowActive, 0);
            PaginableDataGrid.SourceQuery = res;
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            CustomerForm Form = new CustomerForm(CustomerRepository);
            Form.Create();
            if (Form.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                LoadData();
            }
        }

        protected void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            if (PaginableDataGrid.SelectedEntity == null)
            {
                MessageDialog(Util.MessageUtil.GlobalSelectRow, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageDialog(String.Format(Util.MessageUtil.GlobalDeleteConfirm,
                PaginableDataGrid.SelectedEntity.Name), MessageBoxIcon.Question, MessageBoxButtons.YesNo)
                == DialogResult.No)
                return;

            Customer Customer = CustomerRepository.findById(PaginableDataGrid.SelectedEntity.Id);
            CustomerRepository.SoftDelete(Customer);
            LoadData();
        }

        protected void BtnActivate_Click(object sender, EventArgs e)
        {
            if (PaginableDataGrid.SelectedEntity == null)
            {
                MessageDialog(Util.MessageUtil.GlobalSelectRow, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageDialog(String.Format(Util.MessageUtil.GlobalActivateConfirm,
                PaginableDataGrid.SelectedEntity.Name), MessageBoxIcon.Question, MessageBoxButtons.YesNo)
                == DialogResult.No)
                return;

            Customer Customer = CustomerRepository.findById(PaginableDataGrid.SelectedEntity.Id);
            CustomerRepository.Reactivate(Customer);
            LoadData();
        }

        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            if (PaginableDataGrid.SelectedEntity == null)
            {
                MessageDialog(Util.MessageUtil.GlobalSelectRow, MessageBoxIcon.Exclamation);
                return;
            }

            Customer dt = CustomerRepository.findById(PaginableDataGrid.SelectedEntity.Id);
            CustomerForm form = new CustomerForm(CustomerRepository);
            form.Edit(dt);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                LoadData();
            }
        }
        
        private void QueryTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SearchPictureBox_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
