using Entity.Coolers;
using Entity.Coolers.Extra;
using GUI.CustomControls;
using Repository.Coolers;
using System;
using System.Windows.Forms;

namespace GUI.View.ServiceOrderView
{
    public partial class ServiceOrderListForm : BaseForm, Util.ILoadData
    {
        protected ServiceOrderRepository ServiceOrderRepository;
        private PaginableDataGrid<ServiceOrderRow> PaginableDataGrid;
        public ServiceOrderListForm()
        {
            ServiceOrderRepository = new ServiceOrderRepository();

            InitializeComponent();

            InitializeGrid();
            StartPosition = FormStartPosition.CenterScreen;
            Refresh();
            LoadData();
        }

        protected void InitializeGrid()
        {
            PaginableDataGrid = new PaginableDataGrid<ServiceOrderRow>(this);
            PaginableDataGrid.Grid.ReadOnly = true;
            PaginableDataGrid.CastSourceQueryToList = true;
            PaginableDataGrid.AddToolStripButton.Click += new EventHandler(BtnAdd_Click);
            PaginableDataGrid.ReloadToolStripButton.Click += new EventHandler(BtnRefresh_Click);
            PaginableDataGrid.DeleteToolStripButton.Click += new EventHandler(BtnDelete_Click);
            PaginableDataGrid.ReactivateToolStripButton.Click += new EventHandler(BtnActivate_Click);
            PaginableDataGrid.EditToolStripButton.Click += new EventHandler(BtnEdit_Click);


            PaginableDataGrid.Grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            PaginableDataGrid.HeaderTexts["Code"] = "Códgo";
            PaginableDataGrid.HeaderTexts["Customer"] = "Cliente";
            PaginableDataGrid.HeaderTexts["Closed"] = "Cerrada";

            GridPanel.Controls.Add(PaginableDataGrid);
        }
        public void LoadData()
        {
            var res = ServiceOrderRepository.FindAllRow(QueryTextBox.Text, PaginableDataGrid.ShowActive, 0);
            PaginableDataGrid.SourceQuery = res;
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            ServiceOrderForm Form = new ServiceOrderForm(ServiceOrderRepository);
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
                PaginableDataGrid.SelectedEntity.Code), MessageBoxIcon.Question, MessageBoxButtons.YesNo)
                == DialogResult.No)
                return;

            ServiceOrder ServiceOrder = ServiceOrderRepository.findById(PaginableDataGrid.SelectedEntity.Id);
            ServiceOrderRepository.SoftDelete(ServiceOrder);
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
                PaginableDataGrid.SelectedEntity.Code), MessageBoxIcon.Question, MessageBoxButtons.YesNo)
                == DialogResult.No)
                return;

            ServiceOrder ServiceOrder = ServiceOrderRepository.findById(PaginableDataGrid.SelectedEntity.Id);
            ServiceOrderRepository.Reactivate(ServiceOrder);
            LoadData();
        }

        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            if (PaginableDataGrid.SelectedEntity == null)
            {
                MessageDialog(Util.MessageUtil.GlobalSelectRow, MessageBoxIcon.Exclamation);
                return;
            }

            ServiceOrder dt = ServiceOrderRepository.findById(PaginableDataGrid.SelectedEntity.Id);
            ServiceOrderForm form = new ServiceOrderForm(ServiceOrderRepository);
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
