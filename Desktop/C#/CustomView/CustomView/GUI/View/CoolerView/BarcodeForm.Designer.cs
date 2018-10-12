namespace GUI.View.CoolerView
{
    partial class BarcodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodeForm));
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BarcodePictureBox = new System.Windows.Forms.PictureBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.MainLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.ColumnCount = 3;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.MainLayoutPanel.Controls.Add(this.BarcodePictureBox, 0, 0);
            this.MainLayoutPanel.Controls.Add(this.SaveButton, 1, 1);
            this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, 30);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowCount = 2;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(400, 270);
            this.MainLayoutPanel.TabIndex = 1;
            // 
            // BarcodePictureBox
            // 
            this.BarcodePictureBox.BackColor = System.Drawing.Color.White;
            this.MainLayoutPanel.SetColumnSpan(this.BarcodePictureBox, 3);
            this.BarcodePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BarcodePictureBox.Location = new System.Drawing.Point(3, 3);
            this.BarcodePictureBox.Name = "BarcodePictureBox";
            this.BarcodePictureBox.Size = new System.Drawing.Size(394, 224);
            this.BarcodePictureBox.TabIndex = 0;
            this.BarcodePictureBox.TabStop = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.Location = new System.Drawing.Point(143, 233);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(114, 34);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "&Guardar";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "BMP Files (*.bmp)|*.bmp";
            // 
            // BarcodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.MainLayoutPanel);
            this.Name = "BarcodeForm";
            this.Text = "Código de Barras";
            this.Controls.SetChildIndex(this.MainLayoutPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.MainLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarcodePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        private System.Windows.Forms.PictureBox BarcodePictureBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}