namespace ProductStock.Views
{
    partial class StoredProductForm
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
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.StoreComboBox = new System.Windows.Forms.ComboBox();
            this.ProductCodeTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.ProductNameTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.SerialTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.PartNumberTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.PartSerialTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.ButtonsPanel.SuspendLayout();
            this.MainLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1056, 3);
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 483);
            this.ButtonsPanel.Size = new System.Drawing.Size(731, 50);
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.ColumnCount = 2;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayoutPanel.Controls.Add(this.StoreComboBox, 0, 0);
            this.MainLayoutPanel.Controls.Add(this.ProductCodeTextBox, 0, 1);
            this.MainLayoutPanel.Controls.Add(this.ProductNameTextBox, 1, 1);
            this.MainLayoutPanel.Controls.Add(this.SerialTextBox, 0, 2);
            this.MainLayoutPanel.Controls.Add(this.PartNumberTextBox, 0, 3);
            this.MainLayoutPanel.Controls.Add(this.Grid, 0, 4);
            this.MainLayoutPanel.Controls.Add(this.PartSerialTextBox, 1, 3);
            this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowCount = 5;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(731, 483);
            this.MainLayoutPanel.TabIndex = 101;
            // 
            // StoreComboBox
            // 
            this.StoreComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StoreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StoreComboBox.FormattingEnabled = true;
            this.StoreComboBox.Location = new System.Drawing.Point(3, 3);
            this.StoreComboBox.Name = "StoreComboBox";
            this.StoreComboBox.Size = new System.Drawing.Size(359, 21);
            this.StoreComboBox.TabIndex = 0;
            // 
            // ProductCodeTextBox
            // 
            this.ProductCodeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ProductCodeTextBox.Location = new System.Drawing.Point(3, 27);
            this.ProductCodeTextBox.Name = "ProductCodeTextBox";
            this.ProductCodeTextBox.Size = new System.Drawing.Size(359, 20);
            this.ProductCodeTextBox.TabIndex = 1;
            this.ProductCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductCodeTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.ProductCodeTextBox.WaterMarkText = "Código Producto";
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ProductNameTextBox.Location = new System.Drawing.Point(368, 27);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(360, 20);
            this.ProductNameTextBox.TabIndex = 2;
            this.ProductNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductNameTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.ProductNameTextBox.WaterMarkText = "Nombre Producto";
            // 
            // SerialTextBox
            // 
            this.SerialTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SerialTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.SerialTextBox.Location = new System.Drawing.Point(3, 51);
            this.SerialTextBox.Name = "SerialTextBox";
            this.SerialTextBox.Size = new System.Drawing.Size(359, 20);
            this.SerialTextBox.TabIndex = 3;
            this.SerialTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SerialTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.SerialTextBox.WaterMarkText = "Número de Serie";
            // 
            // PartNumberTextBox
            // 
            this.PartNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PartNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PartNumberTextBox.Location = new System.Drawing.Point(3, 75);
            this.PartNumberTextBox.Name = "PartNumberTextBox";
            this.PartNumberTextBox.Size = new System.Drawing.Size(359, 20);
            this.PartNumberTextBox.TabIndex = 4;
            this.PartNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PartNumberTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.PartNumberTextBox.WaterMarkText = "Componente";
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainLayoutPanel.SetColumnSpan(this.Grid, 2);
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(3, 99);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(725, 381);
            this.Grid.TabIndex = 5;
            // 
            // PartSerialTextBox
            // 
            this.PartSerialTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PartSerialTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PartSerialTextBox.Location = new System.Drawing.Point(368, 75);
            this.PartSerialTextBox.Name = "PartSerialTextBox";
            this.PartSerialTextBox.Size = new System.Drawing.Size(360, 20);
            this.PartSerialTextBox.TabIndex = 6;
            this.PartSerialTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PartSerialTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.PartSerialTextBox.WaterMarkText = "Número de Serie Componente";
            // 
            // StoredProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 533);
            this.Controls.Add(this.MainLayoutPanel);
            this.Name = "StoredProductForm";
            this.Text = "INGRESO";
            this.Controls.SetChildIndex(this.ButtonsPanel, 0);
            this.Controls.SetChildIndex(this.MainLayoutPanel, 0);
            this.ButtonsPanel.ResumeLayout(false);
            this.MainLayoutPanel.ResumeLayout(false);
            this.MainLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        private System.Windows.Forms.ComboBox StoreComboBox;
        private GUI.CustomControls.WaterMarkTextBox ProductCodeTextBox;
        private GUI.CustomControls.WaterMarkTextBox ProductNameTextBox;
        private GUI.CustomControls.WaterMarkTextBox SerialTextBox;
        private GUI.CustomControls.WaterMarkTextBox PartNumberTextBox;
        private System.Windows.Forms.DataGridView Grid;
        private GUI.CustomControls.WaterMarkTextBox PartSerialTextBox;
    }
}