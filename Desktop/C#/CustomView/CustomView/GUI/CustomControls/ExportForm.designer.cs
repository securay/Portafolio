namespace GUI.CustomControls
{
    partial class ExportForm <T>
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
            this.ExportLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.StartPageTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.EndPageTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.AllCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.ExportLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExportLayoutPanel
            // 
            this.ExportLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.ExportLayoutPanel.ColumnCount = 4;
            this.ExportLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ExportLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ExportLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ExportLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ExportLayoutPanel.Controls.Add(this.StartPageTextBox, 0, 0);
            this.ExportLayoutPanel.Controls.Add(this.EndPageTextBox, 1, 0);
            this.ExportLayoutPanel.Controls.Add(this.AllCheckBox, 2, 0);
            this.ExportLayoutPanel.Controls.Add(this.SaveButton, 3, 0);
            this.ExportLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExportLayoutPanel.Location = new System.Drawing.Point(0, 30);
            this.ExportLayoutPanel.Name = "ExportLayoutPanel";
            this.ExportLayoutPanel.RowCount = 1;
            this.ExportLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ExportLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.ExportLayoutPanel.Size = new System.Drawing.Size(424, 30);
            this.ExportLayoutPanel.TabIndex = 1;
            // 
            // StartPageTextBox
            // 
            this.StartPageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartPageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.StartPageTextBox.Location = new System.Drawing.Point(3, 3);
            this.StartPageTextBox.Name = "StartPageTextBox";
            this.StartPageTextBox.Size = new System.Drawing.Size(100, 20);
            this.StartPageTextBox.TabIndex = 0;
            this.StartPageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartPageTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.StartPageTextBox.WaterMarkText = "Pagina Inicio";
            // 
            // EndPageTextBox
            // 
            this.EndPageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EndPageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.EndPageTextBox.Location = new System.Drawing.Point(109, 3);
            this.EndPageTextBox.Name = "EndPageTextBox";
            this.EndPageTextBox.Size = new System.Drawing.Size(100, 20);
            this.EndPageTextBox.TabIndex = 1;
            this.EndPageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EndPageTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.EndPageTextBox.WaterMarkText = "Pagina Fin";
            // 
            // AllCheckBox
            // 
            this.AllCheckBox.AutoSize = true;
            this.AllCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllCheckBox.Location = new System.Drawing.Point(215, 3);
            this.AllCheckBox.Name = "AllCheckBox";
            this.AllCheckBox.Size = new System.Drawing.Size(100, 24);
            this.AllCheckBox.TabIndex = 2;
            this.AllCheckBox.Text = "Todas";
            this.AllCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveButton.Location = new System.Drawing.Point(321, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 24);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Guardar";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "Excel |*.xlsx";
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 60);
            this.Controls.Add(this.ExportLayoutPanel);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(116)))), ((int)(((byte)(164)))));
            this.Name = "ExportForm";
            this.Text = "Exportar";
            this.Controls.SetChildIndex(this.ExportLayoutPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ExportLayoutPanel.ResumeLayout(false);
            this.ExportLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ExportLayoutPanel;
        private WaterMarkTextBox StartPageTextBox;
        private WaterMarkTextBox EndPageTextBox;
        private System.Windows.Forms.CheckBox AllCheckBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}