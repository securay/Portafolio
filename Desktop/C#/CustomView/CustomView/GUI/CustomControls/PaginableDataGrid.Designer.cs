namespace GUI.CustomControls
{
    partial class PaginableDataGrid<T>
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new Util.CustomComponentResourceManager(typeof(PaginableDataGrid<>), "PaginableDataGrid"); ;
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.FirstToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PreviousToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PageToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.NextToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LastToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ReloadToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AddToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ReactivateToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.StatusToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.RowCountToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.RowsByPageToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.PageSizeToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.ExportToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.MainLayoutPanel.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.ColumnCount = 1;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayoutPanel.Controls.Add(this.MainToolStrip, 0, 1);
            this.MainLayoutPanel.Controls.Add(this.Grid, 0, 0);
            this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowCount = 2;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(700, 350);
            this.MainLayoutPanel.TabIndex = 0;
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FirstToolStripButton,
            this.PreviousToolStripButton,
            this.PageToolStripTextBox,
            this.NextToolStripButton,
            this.LastToolStripButton,
            this.toolStripSeparator1,
            this.ReloadToolStripButton,
            this.toolStripSeparator2,
            this.AddToolStripButton,
            this.EditToolStripButton,
            this.DeleteToolStripButton,
            this.ReactivateToolStripButton,
            this.StatusToolStripComboBox,
            this.toolStripSeparator3,
            this.RowCountToolStripLabel,
            this.RowsByPageToolStripLabel,
            this.PageSizeToolStripComboBox,
            this.ExportToolStripButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 320);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(700, 30);
            this.MainToolStrip.TabIndex = 0;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // FirstToolStripButton
            // 
            this.FirstToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FirstToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FirstToolStripButton.Image")));
            this.FirstToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FirstToolStripButton.Name = "FirstToolStripButton";
            this.FirstToolStripButton.Size = new System.Drawing.Size(23, 27);
            this.FirstToolStripButton.ToolTipText = "Primera página";
            this.FirstToolStripButton.Click += new System.EventHandler(this.First_Click);
            // 
            // PreviousToolStripButton
            // 
            this.PreviousToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PreviousToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("PreviousToolStripButton.Image")));
            this.PreviousToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PreviousToolStripButton.Name = "PreviousToolStripButton";
            this.PreviousToolStripButton.Size = new System.Drawing.Size(23, 27);
            this.PreviousToolStripButton.ToolTipText = "Página anterior";
            this.PreviousToolStripButton.Click += new System.EventHandler(this.Previous_Click);
            // 
            // PageToolStripTextBox
            // 
            this.PageToolStripTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageToolStripTextBox.MaxLength = 10;
            this.PageToolStripTextBox.Name = "PageToolStripTextBox";
            this.PageToolStripTextBox.Size = new System.Drawing.Size(50, 30);
            this.PageToolStripTextBox.Text = "0";
            this.PageToolStripTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PageToolStripTextBox.ToolTipText = "Página";
            this.PageToolStripTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Page_KeyPress);
            // 
            // NextToolStripButton
            // 
            this.NextToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NextToolStripButton.Image")));
            this.NextToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextToolStripButton.Name = "NextToolStripButton";
            this.NextToolStripButton.Size = new System.Drawing.Size(23, 27);
            this.NextToolStripButton.ToolTipText = "Página siguiente";
            this.NextToolStripButton.Click += new System.EventHandler(this.Next_Click);
            // 
            // LastToolStripButton
            // 
            this.LastToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LastToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("LastToolStripButton.Image")));
            this.LastToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LastToolStripButton.Name = "LastToolStripButton";
            this.LastToolStripButton.Size = new System.Drawing.Size(23, 27);
            this.LastToolStripButton.ToolTipText = "Última página";
            this.LastToolStripButton.Click += new System.EventHandler(this.Last_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // ReloadToolStripButton
            // 
            this.ReloadToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ReloadToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ReloadToolStripButton.Image")));
            this.ReloadToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReloadToolStripButton.Name = "ReloadToolStripButton";
            this.ReloadToolStripButton.Size = new System.Drawing.Size(23, 27);
            this.ReloadToolStripButton.ToolTipText = "Actualizar";
            this.ReloadToolStripButton.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // AddToolStripButton
            // 
            this.AddToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AddToolStripButton.Image")));
            this.AddToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddToolStripButton.Name = "AddToolStripButton";
            this.AddToolStripButton.Size = new System.Drawing.Size(23, 27);
            this.AddToolStripButton.ToolTipText = "Nuevo";
            // 
            // EditToolStripButton
            // 
            this.EditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EditToolStripButton.Image")));
            this.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolStripButton.Name = "EditToolStripButton";
            this.EditToolStripButton.Size = new System.Drawing.Size(23, 27);
            this.EditToolStripButton.ToolTipText = "Editar";
            // 
            // DeleteToolStripButton
            // 
            this.DeleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteToolStripButton.Image")));
            this.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolStripButton.Name = "DeleteToolStripButton";
            this.DeleteToolStripButton.Size = new System.Drawing.Size(23, 27);
            this.DeleteToolStripButton.ToolTipText = "Eliminar";
            // 
            // ReactivateToolStripButton
            // 
            this.ReactivateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ReactivateToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ReactivateToolStripButton.Image")));
            this.ReactivateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReactivateToolStripButton.Name = "ReactivateToolStripButton";
            this.ReactivateToolStripButton.Size = new System.Drawing.Size(23, 27);
            this.ReactivateToolStripButton.ToolTipText = "Reactivar";
            this.ReactivateToolStripButton.Visible = false;
            // 
            // StatusToolStripComboBox
            // 
            this.StatusToolStripComboBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusToolStripComboBox.Items.AddRange(new object[] {
            "Activos",
            "Inactivos"});
            this.StatusToolStripComboBox.Name = "StatusToolStripComboBox";
            this.StatusToolStripComboBox.Size = new System.Drawing.Size(121, 30);
            this.StatusToolStripComboBox.ToolTipText = "Estado de los registros";
            this.StatusToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.Status_SelectedIndexChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 30);
            // 
            // RowCountToolStripLabel
            // 
            this.RowCountToolStripLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.RowCountToolStripLabel.Name = "RowCountToolStripLabel";
            this.RowCountToolStripLabel.Size = new System.Drawing.Size(69, 27);
            this.RowCountToolStripLabel.Text = "{0} registros";
            // 
            // RowsByPageToolStripLabel
            // 
            this.RowsByPageToolStripLabel.Name = "RowsByPageToolStripLabel";
            this.RowsByPageToolStripLabel.Size = new System.Drawing.Size(33, 27);
            this.RowsByPageToolStripLabel.Text = "Filas:";
            // 
            // PageSizeToolStripComboBox
            // 
            this.PageSizeToolStripComboBox.Name = "PageSizeToolStripComboBox";
            this.PageSizeToolStripComboBox.Size = new System.Drawing.Size(121, 30);
            this.PageSizeToolStripComboBox.ToolTipText = "Filas por página";
            this.PageSizeToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.PageSize_SelectedIndexChanged);
            // 
            // ExportToolStripButton
            // 
            this.ExportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExportToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ExportToolStripButton.Image")));
            this.ExportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportToolStripButton.Name = "ExportToolStripButton";
            this.ExportToolStripButton.Size = new System.Drawing.Size(23, 27);
            this.ExportToolStripButton.ToolTipText = "Exportar";
            this.ExportToolStripButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(3, 3);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(694, 314);
            this.Grid.TabIndex = 1;
            // 
            // PaginableDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainLayoutPanel);
            this.Name = "PaginableDataGrid";
            this.Size = new System.Drawing.Size(700, 350);
            this.MainLayoutPanel.ResumeLayout(false);
            this.MainLayoutPanel.PerformLayout();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        public System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton FirstToolStripButton;
        private System.Windows.Forms.ToolStripButton PreviousToolStripButton;
        private System.Windows.Forms.ToolStripTextBox PageToolStripTextBox;
        private System.Windows.Forms.ToolStripButton NextToolStripButton;
        private System.Windows.Forms.ToolStripButton LastToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton ReloadToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton AddToolStripButton;
        public System.Windows.Forms.ToolStripButton EditToolStripButton;
        public System.Windows.Forms.ToolStripButton DeleteToolStripButton;
        public System.Windows.Forms.ToolStripButton ReactivateToolStripButton;
        private System.Windows.Forms.ToolStripComboBox StatusToolStripComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel RowCountToolStripLabel;
        private System.Windows.Forms.ToolStripLabel RowsByPageToolStripLabel;
        private System.Windows.Forms.ToolStripComboBox PageSizeToolStripComboBox;
        private System.Windows.Forms.ToolStripButton ExportToolStripButton;
        public System.Windows.Forms.DataGridView Grid;
    }
}
