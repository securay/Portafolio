using GUI.CustomControls;
using Repository.Auth;
using Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Entity.Auth;

namespace GUI.Auth.PermissionsView
{
    public partial class PermissionsForm : BaseForm
    {
        public PermissionsForm()
        {
            InitializeComponent();
            
            ButtonsContainer MenuPermissionButtonPanel = new ButtonsContainer();
            MenuPermissionButtonPanel.Dock = DockStyle.Fill;
            MenuPermissionButtonPanel.SaveButton.Click += new EventHandler(this.BtnMenuOk_click);
            MenuPermissionButtonPanel.CancelButton.Click += new EventHandler(this.BtnCancel_Click);
            MenuPermissionPanel.Controls.Add(MenuPermissionButtonPanel);

            for(int i = 2; i < MenuAccessDataGridView.Columns.Count; i++)
            {
                int current_column = i;
                DatagridViewCheckBoxColumnHeaderCell DatagridViewCheckBoxColumnHeaderCell = new DatagridViewCheckBoxColumnHeaderCell();
                DatagridViewCheckBoxColumnHeaderCell.OnCheckBoxClicked += 
                    delegate(bool checked_status)
                    {
                        for(int j = 0; j < MenuAccessDataGridView.Rows.Count; j++)
                        {
                            MenuAccessDataGridView.Rows[j].Cells[current_column].Value = checked_status;
                        }
                    };
                MenuAccessDataGridView.Columns[i].HeaderCell = DatagridViewCheckBoxColumnHeaderCell;
            }
            SystemUserMenuAccessComboBox.Init("Username", "Id", "Usuario", FillSystemUserComboBox);
        }

        #region General
        protected void FillSystemUserComboBox()
        {
            using (SystemUserRepository SystemUserRepository = new SystemUserRepository())
            {
                IQueryable<SystemUser> SystemUsers = SystemUserRepository.ListByName(SystemUserMenuAccessComboBox.QueryText, true, 20);
                SystemUserMenuAccessComboBox.FillComboBox<SystemUser>(SystemUsers);
            }
        }

        public void BtnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        #endregion
        
        #region MenuAccess
        private void SystemUserMenuAccessComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillMenuPermissions();
        }

        protected void FillMenuPermissions()
        {
            int[] all_selected = {0,0,0,0,0,0,0,0};
            MenuAccessDataGridView.Rows.Clear();
            SystemUser SystemUser = SystemUserMenuAccessComboBox.SelectedItem as SystemUser;
            {
                if (SystemUser != null)
                {
                    using (SystemUserMenuPermissionRepository SystemUserMenuPermissionRepository = new SystemUserMenuPermissionRepository())
                    using (SystemMenuRepository SystemMenuRepository = new SystemMenuRepository())
                    {
                        List<SystemMenu> Menues = SystemMenuRepository.findAll(true).ToList();
                        List<SystemUserMenuPermission> Permissions = SystemUserMenuPermissionRepository.ListByUser(SystemUser).ToList();
                        bool found;
                        
                        foreach (SystemMenu Menu in Menues)
                        {
                            found = false;
                            foreach (SystemUserMenuPermission Permission in Permissions)
                            {
                                if(Permission.SystemMenuId == Menu.Id)
                                {
                                    found = true;

                                    MenuAccessDataGridView.Rows.Add();
                                    DataGridViewRow Row = MenuAccessDataGridView.Rows[MenuAccessDataGridView.Rows.Count - 1];
                                    Row.Cells[0].Value = Permission.Id;
                                    Row.Cells[1].Value = Permission.SystemMenu.Caption;
                                    Row.Cells[2].Value = Permission.Allow;
                                    Row.Cells[3].Value = Permission.List;
                                    Row.Cells[4].Value = Permission.Insert;
                                    Row.Cells[5].Value = Permission.Update;
                                    Row.Cells[6].Value = Permission.Delete;
                                    Row.Cells[7].Value = Permission.Activate;
                                    Row.Cells[8].Value = Permission.Export;
                                    Row.Cells[9].Value = Permission.Extras;

                                    for (int i = 2; i < Row.Cells.Count; i++)
                                    {
                                        all_selected[i - 2] += (((bool)Row.Cells[i].Value) ? 1 : 0);
                                    }
                                    break;
                                }
                            }
                            if(!found)
                            {
                                SystemUserMenuPermission Permission = new SystemUserMenuPermission()
                                {
                                    SystemMenu = Menu
                                };
                                SystemUserMenuPermissionRepository.SaveAndFlush(Permission);

                                MenuAccessDataGridView.Rows.Add();
                                DataGridViewRow Row = MenuAccessDataGridView.Rows[MenuAccessDataGridView.Rows.Count - 1];
                                Row.Cells[0].Value = Permission.Id;
                                Row.Cells[1].Value = Permission.SystemMenu.Caption;
                            }
                        }
                    }
                }

                for (int i = 2; i < MenuAccessDataGridView.Columns.Count; i++)
                {
                    DatagridViewCheckBoxColumnHeaderCell DatagridViewCheckBoxColumnHeaderCell = 
                        MenuAccessDataGridView.Columns[i].HeaderCell as DatagridViewCheckBoxColumnHeaderCell;
                    DatagridViewCheckBoxColumnHeaderCell.Checked = (all_selected[i - 2] == MenuAccessDataGridView.Rows.Count);
                }
            }
        }

        public void BtnMenuOk_click(object sender, EventArgs e)
        {
            SystemUser SystemUser = SystemUserMenuAccessComboBox.SelectedItem as SystemUser;
            {
               if (SystemUser != null)
                {
                    using (SystemUserMenuPermissionRepository SystemUserMenuPermissionRepository = new SystemUserMenuPermissionRepository())
                    {
                        for (int i = 0; i < MenuAccessDataGridView.Rows.Count; i++)
                        {
                            DataGridViewRow Row = MenuAccessDataGridView.Rows[i];
                            SystemUserMenuPermission Permission = SystemUserMenuPermissionRepository.findById(new Guid(Row.Cells[0].Value.ToString()));
                            Permission.Allow = (bool)Row.Cells[2].Value;
                            Permission.List = (bool)Row.Cells[3].Value;
                            Permission.Insert = (bool)Row.Cells[4].Value;
                            Permission.Update = (bool)Row.Cells[5].Value;
                            Permission.Delete = (bool)Row.Cells[6].Value;
                            Permission.Activate = (bool)Row.Cells[7].Value;
                            Permission.Export = (bool)Row.Cells[8].Value;
                            Permission.Extras = (bool)Row.Cells[9].Value;
                            SystemUserMenuPermissionRepository.Update(Permission);
                        }
                    }
                }
            }
            MessageDialog(MessageUtil.GlobalRecordSaved, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Hide();
        }

        private void MenuAccessDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex >= 2)
            {
                int all_selected = 0;

                for (int i = 0; i < MenuAccessDataGridView.Rows.Count; i++)
                {
                    all_selected += (MenuAccessDataGridView.Rows[i].Cells[e.ColumnIndex].EditedFormattedValue.ToString().Equals(true.ToString()) ? (i == e.RowIndex) ? 0 : 1 : (i == e.RowIndex) ? 1 : 0);
                }

                (MenuAccessDataGridView.Columns[e.ColumnIndex].HeaderCell as DatagridViewCheckBoxColumnHeaderCell).Checked = (all_selected == MenuAccessDataGridView.Rows.Count);
                MenuAccessDataGridView.Refresh();
            }
        }
        #endregion
    }
}