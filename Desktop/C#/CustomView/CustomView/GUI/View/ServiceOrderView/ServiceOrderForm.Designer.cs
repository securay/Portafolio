namespace GUI.View.ServiceOrderView
{
    partial class ServiceOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceOrderForm));
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CodeTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.CustomerComboBox = new GUI.CustomControls.ComboBoxWaterMark();
            this.GridPanel = new System.Windows.Forms.Panel();
            this.CoolerTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.AddPictureBox = new System.Windows.Forms.PictureBox();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.MainLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.ColumnCount = 2;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayoutPanel.Controls.Add(this.CodeTextBox, 0, 0);
            this.MainLayoutPanel.Controls.Add(this.ButtonsPanel, 1, 6);
            this.MainLayoutPanel.Controls.Add(this.CustomerComboBox, 1, 0);
            this.MainLayoutPanel.Controls.Add(this.GridPanel, 0, 4);
            this.MainLayoutPanel.Controls.Add(this.CoolerTextBox, 0, 2);
            this.MainLayoutPanel.Controls.Add(this.AddPictureBox, 1, 2);
            this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, 30);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowCount = 7;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(600, 420);
            this.MainLayoutPanel.TabIndex = 1;
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodeTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeTextBox.Location = new System.Drawing.Point(3, 3);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(294, 22);
            this.CodeTextBox.TabIndex = 0;
            this.CodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CodeTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.CodeTextBox.WaterMarkText = "Código";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsPanel.Location = new System.Drawing.Point(303, 367);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(294, 50);
            this.ButtonsPanel.TabIndex = 5;
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CustomerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(303, 3);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.QueryText = "";
            this.CustomerComboBox.Size = new System.Drawing.Size(294, 24);
            this.CustomerComboBox.TabIndex = 1;
            this.CustomerComboBox.WaterMarkText = "Cliente";
            // 
            // GridPanel
            // 
            this.MainLayoutPanel.SetColumnSpan(this.GridPanel, 2);
            this.GridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPanel.Location = new System.Drawing.Point(3, 103);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(594, 238);
            this.GridPanel.TabIndex = 6;
            // 
            // CoolerTextBox
            // 
            this.CoolerTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoolerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CoolerTextBox.Location = new System.Drawing.Point(3, 53);
            this.CoolerTextBox.Name = "CoolerTextBox";
            this.CoolerTextBox.Size = new System.Drawing.Size(294, 20);
            this.CoolerTextBox.TabIndex = 7;
            this.CoolerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CoolerTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.CoolerTextBox.WaterMarkText = "Cooler";
            this.CoolerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CoolerTextBox_KeyPress);
            // 
            // AddPictureBox
            // 
            this.AddPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AddPictureBox.Image")));
            this.AddPictureBox.Location = new System.Drawing.Point(303, 53);
            this.AddPictureBox.Name = "AddPictureBox";
            this.AddPictureBox.Size = new System.Drawing.Size(294, 24);
            this.AddPictureBox.TabIndex = 8;
            this.AddPictureBox.TabStop = false;
            this.AddPictureBox.Click += new System.EventHandler(this.AddPictureBox_Click);
            // 
            // ServiceOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.MainLayoutPanel);
            this.Name = "ServiceOrderForm";
            this.Text = "Orden de Servicio";
            this.Controls.SetChildIndex(this.MainLayoutPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.MainLayoutPanel.ResumeLayout(false);
            this.MainLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        private CustomControls.WaterMarkTextBox CodeTextBox;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Panel ButtonsPanel;
        private CustomControls.ComboBoxWaterMark CustomerComboBox;
        private System.Windows.Forms.Panel GridPanel;
        private CustomControls.WaterMarkTextBox CoolerTextBox;
        private System.Windows.Forms.PictureBox AddPictureBox;
    }
}