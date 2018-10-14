namespace GUI.View.ServiceOrderDetailView
{
    partial class ServiceOrderDetailListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceOrderDetailListForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.QueryTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.SearchPictureBox = new System.Windows.Forms.PictureBox();
            this.GridPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Controls.Add(this.QueryTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SearchPictureBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.GridPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 270);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // QueryTextBox
            // 
            this.QueryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueryTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryTextBox.Location = new System.Drawing.Point(3, 3);
            this.QueryTextBox.Name = "QueryTextBox";
            this.QueryTextBox.Size = new System.Drawing.Size(669, 22);
            this.QueryTextBox.TabIndex = 0;
            this.QueryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QueryTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.QueryTextBox.WaterMarkText = "Busqueda por Razón Social, Orden de Servicio o Código de Barras";
            this.QueryTextBox.TextChanged += new System.EventHandler(this.QueryTextBox_TextChanged);
            // 
            // SearchPictureBox
            // 
            this.SearchPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SearchPictureBox.Image")));
            this.SearchPictureBox.Location = new System.Drawing.Point(678, 3);
            this.SearchPictureBox.Name = "SearchPictureBox";
            this.SearchPictureBox.Size = new System.Drawing.Size(19, 19);
            this.SearchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SearchPictureBox.TabIndex = 1;
            this.SearchPictureBox.TabStop = false;
            this.SearchPictureBox.Click += new System.EventHandler(this.SearchPictureBox_Click);
            // 
            // GridPanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.GridPanel, 2);
            this.GridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPanel.Location = new System.Drawing.Point(3, 28);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(694, 239);
            this.GridPanel.TabIndex = 2;
            // 
            // ServiceOrderDetailListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 300);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ServiceOrderDetailListForm";
            this.Text = "Recepción";
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomControls.WaterMarkTextBox QueryTextBox;
        private System.Windows.Forms.PictureBox SearchPictureBox;
        private System.Windows.Forms.Panel GridPanel;
    }
}