namespace GUI.Auth.EmployeeView
{
    partial class EmployeeListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeListForm));
            this.EmployeeLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FindTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.GridPanel = new System.Windows.Forms.Panel();
            this.FindButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.EmployeeLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FindButton)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeLayout
            // 
            this.EmployeeLayout.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeLayout.ColumnCount = 2;
            this.EmployeeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EmployeeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.EmployeeLayout.Controls.Add(this.FindTextBox, 0, 0);
            this.EmployeeLayout.Controls.Add(this.GridPanel, 0, 1);
            this.EmployeeLayout.Controls.Add(this.FindButton, 1, 0);
            this.EmployeeLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeLayout.Location = new System.Drawing.Point(0, 25);
            this.EmployeeLayout.Name = "EmployeeLayout";
            this.EmployeeLayout.RowCount = 2;
            this.EmployeeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.EmployeeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EmployeeLayout.Size = new System.Drawing.Size(882, 359);
            this.EmployeeLayout.TabIndex = 1;
            // 
            // FindTextBox
            // 
            this.FindTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FindTextBox.Location = new System.Drawing.Point(3, 3);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(850, 20);
            this.FindTextBox.TabIndex = 0;
            this.FindTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FindTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.FindTextBox.WaterMarkText = "Buscar Empleado";
            this.FindTextBox.TextChanged += new System.EventHandler(this.FindButton_Click);
            // 
            // GridPanel
            // 
            this.EmployeeLayout.SetColumnSpan(this.GridPanel, 2);
            this.GridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPanel.Location = new System.Drawing.Point(3, 28);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(876, 328);
            this.GridPanel.TabIndex = 1;
            // 
            // FindButton
            // 
            this.FindButton.Image = ((System.Drawing.Image)(resources.GetObject("FindButton.Image")));
            this.FindButton.Location = new System.Drawing.Point(859, 3);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(20, 19);
            this.FindButton.TabIndex = 2;
            this.FindButton.TabStop = false;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // EmployeeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 384);
            this.Controls.Add(this.EmployeeLayout);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "EmployeeListForm";
            this.Text = "Empleados";
            this.Controls.SetChildIndex(this.EmployeeLayout, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.EmployeeLayout.ResumeLayout(false);
            this.EmployeeLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FindButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel EmployeeLayout;
        private CustomControls.WaterMarkTextBox FindTextBox;
        private System.Windows.Forms.Panel GridPanel;
        private System.Windows.Forms.PictureBox FindButton;
    }
}