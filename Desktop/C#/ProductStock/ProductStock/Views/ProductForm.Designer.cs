namespace ProductStock.Views
{
    partial class ProductForm
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
            this.NameTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.CodeTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.SunatCodeTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.PerecibleCheckBox = new System.Windows.Forms.CheckBox();
            this.ElectronicDocumentCheckBox = new System.Windows.Forms.CheckBox();
            this.MinStockTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.PriceTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.ButtonsPanel.SuspendLayout();
            this.MainLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(202, 3);
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 261);
            this.ButtonsPanel.Size = new System.Drawing.Size(324, 50);
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.ColumnCount = 2;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayoutPanel.Controls.Add(this.NameTextBox, 0, 0);
            this.MainLayoutPanel.Controls.Add(this.CodeTextBox, 0, 2);
            this.MainLayoutPanel.Controls.Add(this.SunatCodeTextBox, 0, 4);
            this.MainLayoutPanel.Controls.Add(this.PerecibleCheckBox, 0, 6);
            this.MainLayoutPanel.Controls.Add(this.ElectronicDocumentCheckBox, 1, 6);
            this.MainLayoutPanel.Controls.Add(this.MinStockTextBox, 0, 8);
            this.MainLayoutPanel.Controls.Add(this.PriceTextBox, 1, 8);
            this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowCount = 10;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(324, 261);
            this.MainLayoutPanel.TabIndex = 1;
            // 
            // NameTextBox
            // 
            this.MainLayoutPanel.SetColumnSpan(this.NameTextBox, 2);
            this.NameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(3, 3);
            this.NameTextBox.MaxLength = 250;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(318, 22);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.NameTextBox.WaterMarkText = "Nombre";
            // 
            // CodeTextBox
            // 
            this.MainLayoutPanel.SetColumnSpan(this.CodeTextBox, 2);
            this.CodeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeTextBox.Location = new System.Drawing.Point(3, 55);
            this.CodeTextBox.MaxLength = 50;
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(318, 22);
            this.CodeTextBox.TabIndex = 1;
            this.CodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CodeTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.CodeTextBox.WaterMarkText = "Código";
            // 
            // SunatCodeTextBox
            // 
            this.MainLayoutPanel.SetColumnSpan(this.SunatCodeTextBox, 2);
            this.SunatCodeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SunatCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunatCodeTextBox.Location = new System.Drawing.Point(3, 107);
            this.SunatCodeTextBox.MaxLength = 20;
            this.SunatCodeTextBox.Name = "SunatCodeTextBox";
            this.SunatCodeTextBox.Size = new System.Drawing.Size(318, 22);
            this.SunatCodeTextBox.TabIndex = 2;
            this.SunatCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SunatCodeTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.SunatCodeTextBox.WaterMarkText = "Código SUNAT";
            // 
            // PerecibleCheckBox
            // 
            this.PerecibleCheckBox.AutoSize = true;
            this.PerecibleCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PerecibleCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerecibleCheckBox.Location = new System.Drawing.Point(3, 159);
            this.PerecibleCheckBox.Name = "PerecibleCheckBox";
            this.PerecibleCheckBox.Size = new System.Drawing.Size(156, 26);
            this.PerecibleCheckBox.TabIndex = 3;
            this.PerecibleCheckBox.Text = "Perecible";
            this.PerecibleCheckBox.UseVisualStyleBackColor = true;
            // 
            // ElectronicDocumentCheckBox
            // 
            this.ElectronicDocumentCheckBox.AutoSize = true;
            this.ElectronicDocumentCheckBox.Checked = true;
            this.ElectronicDocumentCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ElectronicDocumentCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ElectronicDocumentCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElectronicDocumentCheckBox.Location = new System.Drawing.Point(165, 159);
            this.ElectronicDocumentCheckBox.Name = "ElectronicDocumentCheckBox";
            this.ElectronicDocumentCheckBox.Size = new System.Drawing.Size(156, 26);
            this.ElectronicDocumentCheckBox.TabIndex = 4;
            this.ElectronicDocumentCheckBox.Text = "Documentos Elect.";
            this.ElectronicDocumentCheckBox.UseVisualStyleBackColor = true;
            // 
            // MinStockTextBox
            // 
            this.MinStockTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinStockTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.MinStockTextBox.Location = new System.Drawing.Point(3, 211);
            this.MinStockTextBox.MaxLength = 10;
            this.MinStockTextBox.Name = "MinStockTextBox";
            this.MinStockTextBox.Size = new System.Drawing.Size(156, 22);
            this.MinStockTextBox.TabIndex = 5;
            this.MinStockTextBox.Text = "0";
            this.MinStockTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MinStockTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.MinStockTextBox.WaterMarkText = "Stock Mínimo";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.PriceTextBox.Location = new System.Drawing.Point(165, 211);
            this.PriceTextBox.MaxLength = 10;
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(156, 22);
            this.PriceTextBox.TabIndex = 6;
            this.PriceTextBox.Text = "0";
            this.PriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PriceTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.PriceTextBox.WaterMarkText = "Precio";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 311);
            this.Controls.Add(this.MainLayoutPanel);
            this.Name = "ProductForm";
            this.Text = "PRODUCTO";
            this.Controls.SetChildIndex(this.ButtonsPanel, 0);
            this.Controls.SetChildIndex(this.MainLayoutPanel, 0);
            this.ButtonsPanel.ResumeLayout(false);
            this.MainLayoutPanel.ResumeLayout(false);
            this.MainLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        private GUI.CustomControls.WaterMarkTextBox NameTextBox;
        private GUI.CustomControls.WaterMarkTextBox CodeTextBox;
        private GUI.CustomControls.WaterMarkTextBox SunatCodeTextBox;
        private System.Windows.Forms.CheckBox PerecibleCheckBox;
        private System.Windows.Forms.CheckBox ElectronicDocumentCheckBox;
        private GUI.CustomControls.WaterMarkTextBox MinStockTextBox;
        private GUI.CustomControls.WaterMarkTextBox PriceTextBox;
    }
}