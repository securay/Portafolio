namespace GUI.Auth.SystemUserView
{
    partial class SystemUserListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemUserListForm));
            this.SystemUserLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FindTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.FindButton = new System.Windows.Forms.PictureBox();
            this.GridPanel = new System.Windows.Forms.Panel();
            this.ResetPassworPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SystemUserLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FindButton)).BeginInit();
            this.GridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPassworPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SystemUserLayout
            // 
            this.SystemUserLayout.BackColor = System.Drawing.Color.Transparent;
            this.SystemUserLayout.ColumnCount = 2;
            this.SystemUserLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SystemUserLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.SystemUserLayout.Controls.Add(this.FindTextBox, 0, 0);
            this.SystemUserLayout.Controls.Add(this.FindButton, 1, 0);
            this.SystemUserLayout.Controls.Add(this.GridPanel, 0, 1);
            this.SystemUserLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SystemUserLayout.ForeColor = System.Drawing.Color.Black;
            this.SystemUserLayout.Location = new System.Drawing.Point(0, 37);
            this.SystemUserLayout.Name = "SystemUserLayout";
            this.SystemUserLayout.RowCount = 2;
            this.SystemUserLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.SystemUserLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SystemUserLayout.Size = new System.Drawing.Size(750, 363);
            this.SystemUserLayout.TabIndex = 1;
            // 
            // FindTextBox
            // 
            this.FindTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FindTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FindTextBox.ForeColor = System.Drawing.Color.Black;
            this.FindTextBox.Location = new System.Drawing.Point(3, 3);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(718, 20);
            this.FindTextBox.TabIndex = 0;
            this.FindTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FindTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.FindTextBox.WaterMarkText = "Bucar Usuarios";
            this.FindTextBox.TextChanged += new System.EventHandler(this.FindTextBox_TextChanged);
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FindButton.ForeColor = System.Drawing.Color.Black;
            this.FindButton.Image = ((System.Drawing.Image)(resources.GetObject("FindButton.Image")));
            this.FindButton.Location = new System.Drawing.Point(727, 3);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(20, 19);
            this.FindButton.TabIndex = 1;
            this.FindButton.TabStop = false;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // GridPanel
            // 
            this.GridPanel.BackColor = System.Drawing.Color.Transparent;
            this.SystemUserLayout.SetColumnSpan(this.GridPanel, 2);
            this.GridPanel.Controls.Add(this.ResetPassworPictureBox);
            this.GridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPanel.ForeColor = System.Drawing.Color.Black;
            this.GridPanel.Location = new System.Drawing.Point(3, 28);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(744, 332);
            this.GridPanel.TabIndex = 2;
            // 
            // ResetPassworPictureBox
            // 
            this.ResetPassworPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ResetPassworPictureBox.Image")));
            this.ResetPassworPictureBox.Location = new System.Drawing.Point(4, 273);
            this.ResetPassworPictureBox.Name = "ResetPassworPictureBox";
            this.ResetPassworPictureBox.Size = new System.Drawing.Size(16, 16);
            this.ResetPassworPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ResetPassworPictureBox.TabIndex = 0;
            this.ResetPassworPictureBox.TabStop = false;
            this.ResetPassworPictureBox.Visible = false;
            // 
            // SystemUserListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 400);
            this.Controls.Add(this.SystemUserLayout);
            this.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SystemUserListForm";
            this.Text = "Usuarios";
            this.Controls.SetChildIndex(this.SystemUserLayout, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.SystemUserLayout.ResumeLayout(false);
            this.SystemUserLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FindButton)).EndInit();
            this.GridPanel.ResumeLayout(false);
            this.GridPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPassworPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel SystemUserLayout;
        private CustomControls.WaterMarkTextBox FindTextBox;
        private System.Windows.Forms.PictureBox FindButton;
        private System.Windows.Forms.Panel GridPanel;
        private System.Windows.Forms.PictureBox ResetPassworPictureBox;
    }
}