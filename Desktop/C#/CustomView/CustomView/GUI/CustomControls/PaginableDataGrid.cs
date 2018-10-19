using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI.CustomControls
{
    public partial class PaginableDataGrid<T> : UserControl where T : BaseEntity<Guid>
    {
        #region Hidden Properties

        protected Type Type = typeof(T);
        protected IQueryable<T> _sourceQuery;
        protected Util.ILoadData LoadData;
        protected int _pageNumber = 1, _pageSize = 10;
        protected bool _showEntityId, _showAuditColumns;
        protected bool _refreshing = false;
        protected bool _paginable = true;
        protected bool _loaded = false;

        #endregion

        #region Properties

        public bool ShowDeleteButton { get; set; }
        public bool ShowActivateColumn { get; set; }

        private bool _EnableEntityInsert;
        public bool EnableEntityInsert
        {
            get
            {
                return _EnableEntityInsert;
            }
            set
            {
                _EnableEntityInsert = value;
                AddToolStripButton.Enabled = value;
            }
        }

        private bool _EnableEntityUpdate;
        public bool EnableEntityUpdate
        {
            get
            {
                return _EnableEntityUpdate;
            }
            set
            {
                _EnableEntityUpdate = value;
                EditToolStripButton.Enabled = value;
            }
        }

        private bool _EnableEntityDelete;
        public bool EnableEntityDelete
        {
            get
            {
                return _EnableEntityDelete;
            }
            set
            {
                _EnableEntityDelete = value;
                DeleteToolStripButton.Enabled = value;
            }
        }

        public bool EnableEntityList { get; set; }

        private bool _EnableEntityExport;
        public bool EnableEntityExport
        {
            get
            {
                return _EnableEntityExport;
            }
            set
            {
                _EnableEntityExport = value;
                ExportToolStripButton.Enabled = value;
            }
        }
        public bool EnableEntityExtra { get; set; }

        private bool _EnableEntityActivate;
        public bool EnableEntityActivate
        {
            get
            {
                return _EnableEntityActivate;
            }
            set
            {
                _EnableEntityActivate = value;
                ReactivateToolStripButton.Enabled = value;
            }
        }
        public bool CastSourceQueryToList { get; set; }

        public bool Paginable
        {
            get { return _paginable; }
            set
            {
                _paginable = value;
                FirstToolStripButton.Visible =
                    PreviousToolStripButton.Visible =
                    NextToolStripButton.Visible =
                    LastToolStripButton.Visible =
                    PageToolStripTextBox.Visible =
                    RowCountToolStripLabel.Visible =
                    toolStripSeparator1.Visible =
                    toolStripSeparator2.Visible =
                    toolStripSeparator3.Visible = 
                    PageSizeToolStripComboBox.Visible = value;
            }
        }

        public bool ShowActive
        {
            get { return StatusToolStripComboBox.SelectedIndex == 0; }
            set { StatusToolStripComboBox.SelectedIndex = (value ? 0 : 1); }
        }

        public object SelectedId
        {
            get
            {
                DataGridViewRow row = Grid.CurrentRow;
                if (row == null) return null;
                return row.Cells["Id"].Value;
            }
        }

        public T SelectedEntity
        {
            get
            {
                DataGridViewRow row = Grid.CurrentRow;
                if (row == null) return null;
                return (T)row.DataBoundItem;
            }
        }

        public Dictionary<string, string> HeaderTexts { get; set; }

        public DataGridViewColumnCollection Columns { get { return Grid.Columns; } }

        public bool ShowEntityId
        {
            get { return _showEntityId; }
            set
            {
                _showEntityId = value;
                if (Grid.Columns.Count > 0)
                    Grid.Columns["Id"].Visible = value;
            }
        }

        public bool ShowAuditColumns
        {
            get { return _showAuditColumns; }
            set
            {
                _showAuditColumns = value;
                if (Grid.Columns.Count > 0)
                {
                    SetVisibleColumns(value, "active",
                    "IdInsert", "IpInsert", "DateInsert",
                    "IdUpdate", "IpUpdate", "DateUpdate",
                    "IdDelete", "IpDelete", "DateDelete");
                }
            }
        }

        public List<string> HiddenColumns { get; set; }

        public IQueryable<T> SourceQuery
        {
            get { return _sourceQuery; }
            set
            {
                if (EnableEntityList)
                {
                    _sourceQuery = value;
                    RefreshGrid();
                    ShowEntityId = ShowEntityId;
                    ShowAuditColumns = ShowAuditColumns;
                    HideColumns(HiddenColumns.ToArray());

                    //Actualizar los encabezados de columnas
                    foreach (string ht in HeaderTexts.Keys)
                    {
                        Columns[ht].HeaderText = HeaderTexts[ht];
                    }
                }
            }
        }

        public int RecordCount { get; protected set; }
        public int TotalPages { get; protected set; }

        public int PageNumber
        {
            get { return _pageNumber; }
            set
            {
                if (value <= 0) return;
                int oldValue = _pageNumber;
                _pageNumber = value;
                if (!RefreshGrid()) _pageNumber = oldValue;
            }
        }

        public int PageSize
        {
            get { return _pageSize; }
            set
            {
                if (value <= 0) return;
                _pageSize = value;
                RefreshGrid();
            }
        }

        #endregion

        #region Refresh
        public override void Refresh()
        {
            base.Refresh();
            RefreshGrid();
        }

        public bool RefreshGrid()
        {
            if (_refreshing) return true;
            _refreshing = true;
            bool r = _RefreshGrid();
            _refreshing = false;
            return r;
        }

        protected bool _RefreshGrid()
        {
            if (SourceQuery == null || !EnableEntityList) return false;

            RecordCount = SourceQuery.Count();
            TotalPages = (int)Math.Ceiling((float)RecordCount / (float)PageSize);

            if (RecordCount < PageSize)
            {
                _pageNumber = 1;
                //return true;
            }

            IQueryable<T> dataSource = SourceQuery;

            if (Paginable)
            {
                int skip = PageSize * (PageNumber - 1);
                if (skip >= RecordCount && RecordCount > 0) return false;

                dataSource = dataSource.Skip(skip).Take(PageSize);
            }

            if (CastSourceQueryToList)
            {
                try
                {
                    Grid.DataSource = dataSource.Where(t => t.Active == ShowActive).ToList();
                }
                catch (System.Data.Entity.Core.EntityCommandExecutionException ex)
                {
                    MessageBox.Show(ex.Message, "Custom", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                Grid.DataSource = dataSource.Where(t => t.Active == ShowActive);

            PageToolStripTextBox.Text = PageNumber.ToString();
            RowCountToolStripLabel.Text = string.Format("{0} registro{1}", RecordCount, RecordCount == 1 ? "" : "s");
            PageSizeToolStripComboBox.Text = PageSize.ToString();

            return true;
        }

        #endregion

        #region Generic Get Object

        public T GetEntityAt(int index)
        {
            return (T)Grid.Rows[index].DataBoundItem;
        }

        public List<T> GetSelectedEntityList()
        {
            List<T> ret = new List<T>();
            foreach (DataGridViewRow row in Grid.SelectedRows)
            {
                ret.Add((T)row.DataBoundItem);
            }
            return ret;
        }

        #endregion

        #region Helpers

        public void SetVisibleColumns(bool show, params string[] c)
        {
            foreach (String cn in c)
            {
                DataGridViewColumn dgvc = Grid.Columns[cn];
                if (dgvc != null)
                    dgvc.Visible = show;
            }
        }

        public DataGridViewColumn GetColumn(String ColumnName)
        {
            DataGridViewColumn dgvc = Grid.Columns[ColumnName];
            return dgvc;
        }

        public void HideColumns(params string[] c)
        {
            SetVisibleColumns(false, c);
        }

        public void ShowColumns(params string[] c)
        {
            SetVisibleColumns(true, c);
        }

        public void HideAuditColumns()
        {
            HideColumns("RegistrationDate", "RecordStatus", "CreatedBy", "UpdatedBy",
                "DeletedBy", "UpdatedAt", "DeletedAt");
        }

        #endregion

        #region Special Methods

        public void HideColums(String[] columnsToHide)
        {
            String[] defaultColumnsToHide = new String[] { "active",
                "IdInsert", "IpInsert", "DateInsert",
                "IdUpdate", "IpUpdate", "DateUpdate",
                "IdDelete", "IpDelete", "DateDelete"};

            defaultColumnsToHide = defaultColumnsToHide.Union(columnsToHide).ToArray();

            for (int i = 0; i < defaultColumnsToHide.Length; i++)
            {
                if (Grid.Columns.Contains(defaultColumnsToHide[i]))
                {
                    Grid.Columns[defaultColumnsToHide[i]].Visible = false;
                }
            }
        }

        #endregion
        
        #region Control Events

        private void First_Click(object sender, EventArgs e)
        {
            PageNumber = 1;
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            PageNumber--;
        }

        private void Page_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
                return;
            if (e.KeyChar == 13) PageNumber = int.Parse(PageToolStripTextBox.Text);
            e.Handled = true;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            PageNumber++;
        }

        private void Last_Click(object sender, EventArgs e)
        {
            PageNumber = TotalPages;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }


        private void Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteToolStripButton.Visible = ShowActive && ShowDeleteButton;
            ReactivateToolStripButton.Visible = !ShowActive && ShowActivateColumn;
            if (_loaded)
                LoadData.LoadData();
            RefreshGrid();
        }

        private void PageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            PageSize = int.Parse(PageSizeToolStripComboBox.Text);
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            new ExportForm<T>(_sourceQuery.Where(x => x.Active == ShowActive), PageSize, TotalPages, HeaderTexts, "Id", "Active",
                    "IdInsert", "IPInsert", "DateInsert",
                    "IdUpdate", "IPUpdate", "DateUpdate",
                    "IdDelete", "IPDelete", "DateDelete").ShowDialog();
        }

        #endregion

        public PaginableDataGrid(Util.ILoadData LoadData)
        {
            this.LoadData = LoadData;
            HiddenColumns = new List<string>();
            HeaderTexts = new Dictionary<string, string>();

            InitializeComponent();

            using (Repository.Auth.SystemUserMenuPermissionRepository SystemUserMenuPermissionRepository = new Repository.Auth.SystemUserMenuPermissionRepository())
            {
                Entity.Auth.SystemMenu SystemMenu = new Repository.Auth.SystemMenuRepository().GetByName(Type.Name);
                Entity.Auth.SystemUserMenuPermission SystemUserMenuPermission = SystemUserMenuPermissionRepository.GetByUserAndMenu(CustomView.Program.Security.Session.User, SystemMenu);

                EnableEntityInsert = SystemUserMenuPermission.Insert;
                EnableEntityUpdate = SystemUserMenuPermission.Update;
                ShowDeleteButton = EnableEntityDelete = SystemUserMenuPermission.Delete;
                EnableEntityList = SystemUserMenuPermission.List;
                EnableEntityExport = SystemUserMenuPermission.Export;
                EnableEntityExtra = SystemUserMenuPermission.Extras;
                ShowActivateColumn = EnableEntityActivate = SystemUserMenuPermission.Activate;
            }

            StatusToolStripComboBox.SelectedIndex = 0;
            Dock = DockStyle.Fill;
            _loaded = true;
        }
    }
}
