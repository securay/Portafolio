using Entity.Coolers;
using Entity.Coolers.Extra;
using GUI.CustomControls;
using Repository.Coolers;
using System;
using System.Windows.Forms;

namespace GUI.View.CoolerView
{
    public partial class CoolerListForm : BaseForm, Util.ILoadData
    {
        protected CoolerRepository CoolerRepository;
        private PaginableDataGrid<CoolerRow> PaginableDataGrid;
        private ToolStripButton GetImageButton;
        public CoolerListForm()
        {
            CoolerRepository = new CoolerRepository();

            InitializeComponent();
            Text = "Coolers";

            InitializeGrid();
            StartPosition = FormStartPosition.CenterScreen;
            Refresh();
            LoadData();
        }

        protected void InitializeGrid()
        {
            PaginableDataGrid = new PaginableDataGrid<CoolerRow>(this);
            PaginableDataGrid.Grid.ReadOnly = true;
            PaginableDataGrid.CastSourceQueryToList = true;
            PaginableDataGrid.AddToolStripButton.Click += new EventHandler(BtnAdd_Click);
            PaginableDataGrid.ReloadToolStripButton.Click += new EventHandler(BtnRefresh_Click);
            PaginableDataGrid.DeleteToolStripButton.Click += new EventHandler(BtnDelete_Click);
            PaginableDataGrid.ReactivateToolStripButton.Click += new EventHandler(BtnActivate_Click);
            PaginableDataGrid.EditToolStripButton.Click += new EventHandler(BtnEdit_Click);


            PaginableDataGrid.Grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PaginableDataGrid.Grid.CellFormatting += Grid_CellFormatting;

            PaginableDataGrid.HeaderTexts["Code"] = "Código";
            PaginableDataGrid.HeaderTexts["Barcode"] = "Barcode";
            PaginableDataGrid.HeaderTexts["Color"] = "Color";
            PaginableDataGrid.HeaderTexts["Capacity"] = "Capacidad";
            PaginableDataGrid.HeaderTexts["MeasureUnit"] = "Unidad de Medida";


            GetImageButton = new ToolStripButton("", ImagePictureBox.Image, new EventHandler(BtnBarcode_Click));
            PaginableDataGrid.MainToolStrip.Items.Add(GetImageButton);

            GridPanel.Controls.Add(PaginableDataGrid);
        }

        private void BtnBarcode_Click(object sender, EventArgs e)
        {
            if (PaginableDataGrid.SelectedEntity == null)
            {
                MessageDialog(Util.MessageUtil.GlobalSelectRow, MessageBoxIcon.Exclamation);
                return;
            }

            Cooler dt = CoolerRepository.findById(PaginableDataGrid.SelectedEntity.Id);
            new BarcodeForm(dt.Barcode, dt.Code, dt.Capacity, dt.MeasureUnit.Acronym).ShowDialog();
        }

        private void Grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex != PaginableDataGrid.Grid.Columns["Color"].Index) return;

            System.Drawing.Color BackColor = System.Drawing.Color.FromArgb(int.Parse(e.Value.ToString()));
            e.CellStyle.BackColor = BackColor;
            e.CellStyle.ForeColor = BackColor;
        }

        public void LoadData()
        {
            var res = CoolerRepository.FindAllRow(QueryTextBox.Text, PaginableDataGrid.ShowActive, 0);
            PaginableDataGrid.SourceQuery = res;
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            CoolerForm Form = new CoolerForm(CoolerRepository);
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

            Cooler Cooler = CoolerRepository.findById(PaginableDataGrid.SelectedEntity.Id);
            CoolerRepository.SoftDelete(Cooler);
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

            Cooler Cooler = CoolerRepository.findById(PaginableDataGrid.SelectedEntity.Id);
            CoolerRepository.Reactivate(Cooler);
            LoadData();
        }

        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            if (PaginableDataGrid.SelectedEntity == null)
            {
                MessageDialog(Util.MessageUtil.GlobalSelectRow, MessageBoxIcon.Exclamation);
                return;
            }

            Cooler dt = CoolerRepository.findById(PaginableDataGrid.SelectedEntity.Id);
            CoolerForm form = new CoolerForm(CoolerRepository);
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
