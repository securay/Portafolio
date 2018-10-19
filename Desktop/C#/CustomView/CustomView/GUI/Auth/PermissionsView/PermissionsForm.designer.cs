namespace GUI.Auth.PermissionsView
{
    partial class PermissionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PermissionsForm));
            this.PermissionsTabControl = new System.Windows.Forms.TabControl();
            this.MenuPermissionTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SystemUserMenuAccessComboBox = new GUI.CustomControls.ComboBoxWaterMark();
            this.MenuPermissionPanel = new System.Windows.Forms.Panel();
            this.MenuAccessDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acceso = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Listar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Agregar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Actualizar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Reactivar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Exportar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Extra = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TabImageList = new System.Windows.Forms.ImageList(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.PermissionsTabControl.SuspendLayout();
            this.MenuPermissionTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuAccessDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PermissionsTabControl
            // 
            this.PermissionsTabControl.Controls.Add(this.MenuPermissionTabPage);
            this.PermissionsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PermissionsTabControl.ImageList = this.TabImageList;
            this.PermissionsTabControl.Location = new System.Drawing.Point(0, 37);
            this.PermissionsTabControl.Name = "PermissionsTabControl";
            this.PermissionsTabControl.SelectedIndex = 0;
            this.PermissionsTabControl.Size = new System.Drawing.Size(723, 495);
            this.PermissionsTabControl.TabIndex = 2;
            // 
            // MenuPermissionTabPage
            // 
            this.MenuPermissionTabPage.Controls.Add(this.tableLayoutPanel1);
            this.MenuPermissionTabPage.ImageIndex = 2;
            this.MenuPermissionTabPage.Location = new System.Drawing.Point(4, 25);
            this.MenuPermissionTabPage.Name = "MenuPermissionTabPage";
            this.MenuPermissionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MenuPermissionTabPage.Size = new System.Drawing.Size(715, 466);
            this.MenuPermissionTabPage.TabIndex = 2;
            this.MenuPermissionTabPage.Text = "Acceso a Menús";
            this.MenuPermissionTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37F));
            this.tableLayoutPanel1.Controls.Add(this.SystemUserMenuAccessComboBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MenuPermissionPanel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.MenuAccessDataGridView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(709, 460);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // SystemUserMenuAccessComboBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.SystemUserMenuAccessComboBox, 2);
            this.SystemUserMenuAccessComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SystemUserMenuAccessComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SystemUserMenuAccessComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SystemUserMenuAccessComboBox.FormattingEnabled = true;
            this.SystemUserMenuAccessComboBox.Location = new System.Drawing.Point(3, 3);
            this.SystemUserMenuAccessComboBox.Name = "SystemUserMenuAccessComboBox";
            this.SystemUserMenuAccessComboBox.QueryText = "";
            this.SystemUserMenuAccessComboBox.Size = new System.Drawing.Size(703, 24);
            this.SystemUserMenuAccessComboBox.TabIndex = 1;
            this.SystemUserMenuAccessComboBox.WaterMarkText = null;
            this.SystemUserMenuAccessComboBox.SelectedIndexChanged += new System.EventHandler(this.SystemUserMenuAccessComboBox_SelectedIndexChanged);
            // 
            // MenuPermissionPanel
            // 
            this.MenuPermissionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPermissionPanel.Location = new System.Drawing.Point(449, 393);
            this.MenuPermissionPanel.Name = "MenuPermissionPanel";
            this.MenuPermissionPanel.Size = new System.Drawing.Size(257, 64);
            this.MenuPermissionPanel.TabIndex = 3;
            // 
            // MenuAccessDataGridView
            // 
            this.MenuAccessDataGridView.AllowUserToAddRows = false;
            this.MenuAccessDataGridView.AllowUserToDeleteRows = false;
            this.MenuAccessDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuAccessDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Entidad,
            this.Acceso,
            this.Listar,
            this.Agregar,
            this.Actualizar,
            this.Eliminar,
            this.Reactivar,
            this.Exportar,
            this.Extra});
            this.tableLayoutPanel1.SetColumnSpan(this.MenuAccessDataGridView, 2);
            this.MenuAccessDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuAccessDataGridView.Location = new System.Drawing.Point(3, 42);
            this.MenuAccessDataGridView.Name = "MenuAccessDataGridView";
            this.MenuAccessDataGridView.Size = new System.Drawing.Size(703, 345);
            this.MenuAccessDataGridView.TabIndex = 4;
            this.MenuAccessDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MenuAccessDataGridView_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            // 
            // Entidad
            // 
            this.Entidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Entidad.HeaderText = "Entidad";
            this.Entidad.Name = "Entidad";
            this.Entidad.ReadOnly = true;
            this.Entidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Entidad.Width = 62;
            // 
            // Acceso
            // 
            this.Acceso.HeaderText = "Acceso";
            this.Acceso.Name = "Acceso";
            this.Acceso.Width = 75;
            // 
            // Listar
            // 
            this.Listar.HeaderText = "Listar";
            this.Listar.Name = "Listar";
            this.Listar.Width = 65;
            // 
            // Agregar
            // 
            this.Agregar.HeaderText = "Agregar";
            this.Agregar.Name = "Agregar";
            this.Agregar.Width = 78;
            // 
            // Actualizar
            // 
            this.Actualizar.HeaderText = "Actualizar";
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Width = 87;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 77;
            // 
            // Reactivar
            // 
            this.Reactivar.HeaderText = "Reactivar";
            this.Reactivar.Name = "Reactivar";
            this.Reactivar.Width = 83;
            // 
            // Exportar
            // 
            this.Exportar.HeaderText = "Exportar";
            this.Exportar.Name = "Exportar";
            this.Exportar.Width = 79;
            // 
            // Extra
            // 
            this.Extra.HeaderText = "Extra";
            this.Extra.Name = "Extra";
            this.Extra.Width = 60;
            // 
            // TabImageList
            // 
            this.TabImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TabImageList.ImageStream")));
            this.TabImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.TabImageList.Images.SetKeyName(0, "app-permission.png");
            this.TabImageList.Images.SetKeyName(1, "casino-permission.png");
            this.TabImageList.Images.SetKeyName(2, "menu-permission.png");
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Entidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Listar";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn2.HeaderText = "Agregar";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn3.HeaderText = "Actualizar";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn4.HeaderText = "Eliminar";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn5.HeaderText = "Exportar";
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn6
            // 
            this.dataGridViewCheckBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn6.HeaderText = "Extra";
            this.dataGridViewCheckBoxColumn6.Name = "dataGridViewCheckBoxColumn6";
            // 
            // PermissionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 532);
            this.Controls.Add(this.PermissionsTabControl);
            this.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PermissionsForm";
            this.Text = "Permisos";
            this.Controls.SetChildIndex(this.PermissionsTabControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.PermissionsTabControl.ResumeLayout(false);
            this.MenuPermissionTabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuAccessDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl PermissionsTabControl;
        private System.Windows.Forms.ImageList TabImageList;
        private System.Windows.Forms.TabPage MenuPermissionTabPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomControls.ComboBoxWaterMark SystemUserMenuAccessComboBox;
        private System.Windows.Forms.Panel MenuPermissionPanel;
        private System.Windows.Forms.DataGridView MenuAccessDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Acceso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Listar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Agregar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Actualizar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Reactivar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Exportar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Extra;

    }
}