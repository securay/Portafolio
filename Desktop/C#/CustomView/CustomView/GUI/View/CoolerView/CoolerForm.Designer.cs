namespace GUI.View.CoolerView
{
    partial class CoolerForm
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
            this.CodeTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.BarcodeTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.ColorTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.CapacityTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.MeasureUnitComboBox = new GUI.CustomControls.ComboBoxWaterMark();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.MainLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.ColumnCount = 2;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MainLayoutPanel.Controls.Add(this.CodeTextBox, 0, 0);
            this.MainLayoutPanel.Controls.Add(this.BarcodeTextBox, 0, 2);
            this.MainLayoutPanel.Controls.Add(this.ColorTextBox, 0, 4);
            this.MainLayoutPanel.Controls.Add(this.CapacityTextBox, 0, 6);
            this.MainLayoutPanel.Controls.Add(this.ButtonsPanel, 1, 10);
            this.MainLayoutPanel.Controls.Add(this.MeasureUnitComboBox, 0, 8);
            this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, 30);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowCount = 11;
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
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(400, 290);
            this.MainLayoutPanel.TabIndex = 1;
            // 
            // CodeTextBox
            // 
            this.MainLayoutPanel.SetColumnSpan(this.CodeTextBox, 2);
            this.CodeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodeTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeTextBox.Location = new System.Drawing.Point(3, 3);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(394, 22);
            this.CodeTextBox.TabIndex = 0;
            this.CodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CodeTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.CodeTextBox.WaterMarkText = "Código";
            // 
            // BarcodeTextBox
            // 
            this.MainLayoutPanel.SetColumnSpan(this.BarcodeTextBox, 2);
            this.BarcodeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BarcodeTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeTextBox.Location = new System.Drawing.Point(3, 50);
            this.BarcodeTextBox.MaxLength = 13;
            this.BarcodeTextBox.Name = "BarcodeTextBox";
            this.BarcodeTextBox.Size = new System.Drawing.Size(394, 22);
            this.BarcodeTextBox.TabIndex = 1;
            this.BarcodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BarcodeTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.BarcodeTextBox.WaterMarkText = "Código de Barras";
            // 
            // ColorTextBox
            // 
            this.MainLayoutPanel.SetColumnSpan(this.ColorTextBox, 2);
            this.ColorTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorTextBox.Location = new System.Drawing.Point(3, 97);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(394, 22);
            this.ColorTextBox.TabIndex = 2;
            this.ColorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColorTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.ColorTextBox.WaterMarkText = "Color";
            this.ColorTextBox.Click += new System.EventHandler(this.ColorTextBox_Click);
            // 
            // CapacityTextBox
            // 
            this.MainLayoutPanel.SetColumnSpan(this.CapacityTextBox, 2);
            this.CapacityTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CapacityTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapacityTextBox.Location = new System.Drawing.Point(3, 144);
            this.CapacityTextBox.Name = "CapacityTextBox";
            this.CapacityTextBox.Size = new System.Drawing.Size(394, 22);
            this.CapacityTextBox.TabIndex = 3;
            this.CapacityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CapacityTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.CapacityTextBox.WaterMarkText = "Capacidad";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsPanel.Location = new System.Drawing.Point(163, 238);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(234, 49);
            this.ButtonsPanel.TabIndex = 5;
            // 
            // MeasureUnitComboBox
            // 
            this.MainLayoutPanel.SetColumnSpan(this.MeasureUnitComboBox, 2);
            this.MeasureUnitComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeasureUnitComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.MeasureUnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MeasureUnitComboBox.FormattingEnabled = true;
            this.MeasureUnitComboBox.Location = new System.Drawing.Point(3, 191);
            this.MeasureUnitComboBox.Name = "MeasureUnitComboBox";
            this.MeasureUnitComboBox.QueryText = "";
            this.MeasureUnitComboBox.Size = new System.Drawing.Size(394, 21);
            this.MeasureUnitComboBox.TabIndex = 6;
            this.MeasureUnitComboBox.WaterMarkText = "Unidad de Medida";
            // 
            // CoolerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.MainLayoutPanel);
            this.Name = "CoolerForm";
            this.Text = "Cooler";
            this.Controls.SetChildIndex(this.MainLayoutPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.MainLayoutPanel.ResumeLayout(false);
            this.MainLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        private CustomControls.WaterMarkTextBox CodeTextBox;
        private CustomControls.WaterMarkTextBox BarcodeTextBox;
        private CustomControls.WaterMarkTextBox ColorTextBox;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private CustomControls.WaterMarkTextBox CapacityTextBox;
        private System.Windows.Forms.Panel ButtonsPanel;
        private CustomControls.ComboBoxWaterMark MeasureUnitComboBox;
    }
}