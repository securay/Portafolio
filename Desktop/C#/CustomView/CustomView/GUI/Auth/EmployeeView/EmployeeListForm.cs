using Entity.Auth;
using Entity.Auth.Extra;
using GUI.CustomControls;
using Repository.Auth;
using System;
using System.Windows.Forms;
using Util;

namespace GUI.Auth.EmployeeView
{
    public partial class EmployeeListForm : BaseForm, ILoadData
    {
        private PaginableDataGrid<EmployeeRow> Grid;
        protected EmployeeRepository EmployeeRepository;

        public EmployeeListForm()
        {
            EmployeeRepository = new EmployeeRepository();
            InitializeComponent();
            InitializeGrid();
            StartPosition = FormStartPosition.CenterScreen;
            Refresh();
            LoadData();
        }

        protected void InitializeGrid()
        {
            Grid = new PaginableDataGrid<EmployeeRow>(this);
            Grid.Grid.ReadOnly = true;
            Grid.CastSourceQueryToList = true;
            Grid.AddToolStripButton.Click += new EventHandler(BtnAdd_Click);
            Grid.ReloadToolStripButton.Click += new EventHandler(BtnRefresh_Click);
            Grid.DeleteToolStripButton.Click += new EventHandler(BtnDelete_Click);
            Grid.ReactivateToolStripButton.Click += new EventHandler(BtnActivate_Click);
            Grid.EditToolStripButton.Click += new EventHandler(BtnEdit_Click);

            Grid.Grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grid.HeaderTexts["EntityName"] = "Nombres";
            Grid.HeaderTexts["Dependency"] = "Área";
            Grid.HeaderTexts["DocumentNumber"] = "Número de Documento";
            Grid.HeaderTexts["DocumentType"] = "Tipo de Documento";
            Grid.HeaderTexts["Position"] = "Cargo";
            GridPanel.Controls.Add(Grid);
        }

        public void LoadData()
        {
            var result = EmployeeRepository.FindAllRow(FindTextBox.Text, Grid.ShowActive, 0);
            Grid.SourceQuery = result;
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            EmployeeForm Form = new EmployeeForm(EmployeeRepository);
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
            if (Grid.SelectedEntity == null)
            {
                MessageDialog(MessageUtil.GlobalSelectRow, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageDialog(String.Format(MessageUtil.GlobalDeleteConfirm, 
                Grid.SelectedEntity.EntityName), MessageBoxIcon.Question, MessageBoxButtons.YesNo) 
                == DialogResult.No)
                return;
            Employee Employee = EmployeeRepository.findById(Grid.SelectedEntity.Id);
            EmployeeRepository.SoftDelete(Employee);
            LoadData();
        }

        protected void BtnActivate_Click(object sender, EventArgs e)
        {
            if (Grid.SelectedEntity == null)
            {
                MessageDialog(MessageUtil.GlobalSelectRow, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageDialog(String.Format(MessageUtil.GlobalActivateConfirm,
                Grid.SelectedEntity.EntityName), MessageBoxIcon.Question, MessageBoxButtons.YesNo)
                == DialogResult.No)
                return;
            Employee Employee = EmployeeRepository.findById(Grid.SelectedEntity.Id);
            EmployeeRepository.Reactivate(Employee);
            LoadData();
        }

        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            if (Grid.SelectedEntity == null)
            {
                MessageDialog(MessageUtil.GlobalSelectRow, MessageBoxIcon.Exclamation);
                return;
            }

            Employee dt = EmployeeRepository.findById(Grid.SelectedEntity.Id);
            EmployeeForm form = new EmployeeForm(EmployeeRepository);
            form.Edit(dt.Id);
            if (form.ShowDialog(this) == DialogResult.OK)
                LoadData();
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
