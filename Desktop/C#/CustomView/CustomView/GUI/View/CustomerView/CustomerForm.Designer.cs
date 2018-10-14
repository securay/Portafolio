namespace GUI.View.CustomerView
{
    partial class CustomerForm
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
            this.RUCTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.NameTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.DescriptionTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
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
            this.MainLayoutPanel.Controls.Add(this.RUCTextBox, 0, 0);
            this.MainLayoutPanel.Controls.Add(this.NameTextBox, 0, 2);
            this.MainLayoutPanel.Controls.Add(this.DescriptionTextBox, 0, 4);
            this.MainLayoutPanel.Controls.Add(this.ButtonsPanel, 1, 6);
            this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, 30);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowCount = 7;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(400, 202);
            this.MainLayoutPanel.TabIndex = 1;
            // 
            // RUCTextBox
            // 
            this.MainLayoutPanel.SetColumnSpan(this.RUCTextBox, 2);
            this.RUCTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RUCTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RUCTextBox.Location = new System.Drawing.Point(3, 3);
            this.RUCTextBox.Name = "RUCTextBox";
            this.RUCTextBox.Size = new System.Drawing.Size(394, 22);
            this.RUCTextBox.TabIndex = 0;
            this.RUCTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RUCTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.RUCTextBox.WaterMarkText = "RUC";
            // 
            // NameTextBox
            // 
            this.MainLayoutPanel.SetColumnSpan(this.NameTextBox, 2);
            this.NameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(3, 52);
            this.NameTextBox.MaxLength = 255;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(394, 22);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.NameTextBox.WaterMarkText = "Razón Social";
            // 
            // DescriptionTextBox
            // 
            this.MainLayoutPanel.SetColumnSpan(this.DescriptionTextBox, 2);
            this.DescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(3, 101);
            this.DescriptionTextBox.MaxLength = 255;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(394, 22);
            this.DescriptionTextBox.TabIndex = 2;
            this.DescriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DescriptionTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.DescriptionTextBox.WaterMarkText = "Descripción";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsPanel.Location = new System.Drawing.Point(163, 150);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(234, 49);
            this.ButtonsPanel.TabIndex = 5;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 232);
            this.Controls.Add(this.MainLayoutPanel);
            this.Name = "CustomerForm";
            this.Text = "Cliente";
            this.Controls.SetChildIndex(this.MainLayoutPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.MainLayoutPanel.ResumeLayout(false);
            this.MainLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        private CustomControls.WaterMarkTextBox RUCTextBox;
        private CustomControls.WaterMarkTextBox NameTextBox;
        private CustomControls.WaterMarkTextBox DescriptionTextBox;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Panel ButtonsPanel;
    }
}