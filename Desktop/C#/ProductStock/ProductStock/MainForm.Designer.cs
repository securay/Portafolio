namespace ProductStock
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CloseBox = new System.Windows.Forms.PictureBox();
            this.StoredProductButton = new CustomView.GUI.CustomControls.MenuButton();
            this.ProductButton = new CustomView.GUI.CustomControls.MenuButton();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.LeftPanel.Controls.Add(this.StoredProductButton);
            this.LeftPanel.Controls.Add(this.ProductButton);
            this.LeftPanel.Controls.Add(this.LogoPictureBox);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(200, 700);
            this.LeftPanel.TabIndex = 1;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(200, 40);
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.TopPanel.Controls.Add(this.CloseBox);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(200, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1000, 40);
            this.TopPanel.TabIndex = 2;
            // 
            // CloseBox
            // 
            this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBox.Image = ((System.Drawing.Image)(resources.GetObject("CloseBox.Image")));
            this.CloseBox.Location = new System.Drawing.Point(973, 3);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(24, 24);
            this.CloseBox.TabIndex = 0;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            // 
            // StoredProductButton
            // 
            this.StoredProductButton.EntityName = null;
            this.StoredProductButton.FlatAppearance.BorderSize = 0;
            this.StoredProductButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.StoredProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StoredProductButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoredProductButton.ForeColor = System.Drawing.Color.White;
            this.StoredProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StoredProductButton.Location = new System.Drawing.Point(3, 106);
            this.StoredProductButton.Name = "StoredProductButton";
            this.StoredProductButton.Size = new System.Drawing.Size(200, 50);
            this.StoredProductButton.TabIndex = 2;
            this.StoredProductButton.Text = "INGRESO";
            this.StoredProductButton.UseVisualStyleBackColor = true;
            this.StoredProductButton.Click += new System.EventHandler(this.StoredProductButton_Click);
            // 
            // ProductButton
            // 
            this.ProductButton.EntityName = "Product";
            this.ProductButton.FlatAppearance.BorderSize = 0;
            this.ProductButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductButton.ForeColor = System.Drawing.Color.White;
            this.ProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductButton.Location = new System.Drawing.Point(3, 49);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Size = new System.Drawing.Size(200, 50);
            this.ProductButton.TabIndex = 1;
            this.ProductButton.Text = "PRODUCTO";
            this.ProductButton.UseVisualStyleBackColor = true;
            this.ProductButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.LeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Panel TopPanel;
        private CustomView.GUI.CustomControls.MenuButton StoredProductButton;
        private CustomView.GUI.CustomControls.MenuButton ProductButton;
        private System.Windows.Forms.PictureBox CloseBox;
    }
}