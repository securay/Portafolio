using Entity.Coolers;
using Entity.Coolers.Extra;
using GUI.CustomControls;
using Repository.Coolers;
using System;
using System.Windows.Forms;

namespace GUI.View.ServiceOrderDetailView
{
    public partial class ServiceOrderDetailListForm : BaseForm, Util.ILoadData
    {
        protected ServiceOrderDetailRepository ServiceOrderDetailRepository;
        private PaginableDataGrid<ServiceOrderCoolerRow> PaginableDataGrid;
        public ServiceOrderDetailListForm()
        {
            ServiceOrderDetailRepository = new ServiceOrderDetailRepository();

            InitializeComponent();

            InitializeGrid();
            StartPosition = FormStartPosition.CenterScreen;
            Refresh();
            LoadData();
        }

        protected void InitializeGrid()
        {
            PaginableDataGrid = new PaginableDataGrid<ServiceOrderCoolerRow>(this);
            PaginableDataGrid.Grid.ReadOnly = true;
            PaginableDataGrid.CastSourceQueryToList = true;
            PaginableDataGrid.AddToolStripButton.Image = PaginableDataGrid.ReactivateToolStripButton.Image;
            PaginableDataGrid.AddToolStripButton.ToolTipText = "Confirmar recepción";
            PaginableDataGrid.AddToolStripButton.Click += new EventHandler(BtnAdd_Click);
            PaginableDataGrid.ReloadToolStripButton.Click += new EventHandler(BtnRefresh_Click);
            PaginableDataGrid.ShowDeleteButton = false;
            PaginableDataGrid.DeleteToolStripButton.Visible = false;
            PaginableDataGrid.ShowActivateColumn = false;
            PaginableDataGrid.EditToolStripButton.Visible = false;

            PaginableDataGrid.Grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            PaginableDataGrid.HeaderTexts["Customer"] = "Cliente";
            PaginableDataGrid.HeaderTexts["ServiceOrder"] = "Orden de Servicio";
            PaginableDataGrid.HeaderTexts["Code"] = "Códgo";
            PaginableDataGrid.HeaderTexts["Barcode"] = "Código de Barras";

            GridPanel.Controls.Add(PaginableDataGrid);
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            if (PaginableDataGrid.SelectedEntity == null)
            {
                MessageDialog(Util.MessageUtil.GlobalSelectRow, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageDialog(String.Format("¿Está seguro de confirmar la recepción del cooler {0}?",
                PaginableDataGrid.SelectedEntity.Code), MessageBoxIcon.Question, MessageBoxButtons.YesNo)
                == DialogResult.No)
                return;

            ServiceOrderDetail ServiceOrderDetail = ServiceOrderDetailRepository.findById(PaginableDataGrid.SelectedEntity.Id);
            ServiceOrderDetail.Returned = true;
            ServiceOrderDetailRepository.Reactivate(ServiceOrderDetail);
            LoadData();
        }

        public void LoadData()
        {
            var res = ServiceOrderDetailRepository.FindAllRow(QueryTextBox.Text, PaginableDataGrid.ShowActive, 0);
            PaginableDataGrid.SourceQuery = res;
        }

        protected void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
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
