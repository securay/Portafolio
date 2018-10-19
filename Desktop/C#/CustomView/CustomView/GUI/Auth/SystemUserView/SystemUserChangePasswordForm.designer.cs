namespace GUI.Auth.SystemUserView
{
    partial class SystemUserChangePasswordForm
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
            this.PasswordChangeLayout = new System.Windows.Forms.TableLayoutPanel();
            this.CurrentPasswordTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.NewPasswordTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.NewPasswordRTextBox = new GUI.CustomControls.WaterMarkTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.PasswordChangeLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // PasswordChangeLayout
            // 
            this.PasswordChangeLayout.BackColor = System.Drawing.Color.Transparent;
            this.PasswordChangeLayout.ColumnCount = 2;
            this.PasswordChangeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.PasswordChangeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.PasswordChangeLayout.Controls.Add(this.CurrentPasswordTextBox, 0, 0);
            this.PasswordChangeLayout.Controls.Add(this.ButtonsPanel, 1, 5);
            this.PasswordChangeLayout.Controls.Add(this.NewPasswordTextBox, 0, 2);
            this.PasswordChangeLayout.Controls.Add(this.NewPasswordRTextBox, 0, 4);
            this.PasswordChangeLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordChangeLayout.ForeColor = System.Drawing.Color.Black;
            this.PasswordChangeLayout.Location = new System.Drawing.Point(0, 37);
            this.PasswordChangeLayout.Name = "PasswordChangeLayout";
            this.PasswordChangeLayout.RowCount = 6;
            this.PasswordChangeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PasswordChangeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PasswordChangeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.PasswordChangeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PasswordChangeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.PasswordChangeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.PasswordChangeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PasswordChangeLayout.Size = new System.Drawing.Size(371, 188);
            this.PasswordChangeLayout.TabIndex = 1;
            // 
            // CurrentPasswordTextBox
            // 
            this.CurrentPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PasswordChangeLayout.SetColumnSpan(this.CurrentPasswordTextBox, 2);
            this.CurrentPasswordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CurrentPasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.CurrentPasswordTextBox.Location = new System.Drawing.Point(3, 3);
            this.CurrentPasswordTextBox.MaxLength = 50;
            this.CurrentPasswordTextBox.Name = "CurrentPasswordTextBox";
            this.CurrentPasswordTextBox.Size = new System.Drawing.Size(365, 20);
            this.CurrentPasswordTextBox.TabIndex = 0;
            this.CurrentPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CurrentPasswordTextBox.UseSystemPasswordChar = true;
            this.CurrentPasswordTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.CurrentPasswordTextBox.WaterMarkText = "Contraseña Actual";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsPanel.Location = new System.Drawing.Point(114, 120);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(254, 65);
            this.ButtonsPanel.TabIndex = 3;
            // 
            // NewPasswordTextBox
            // 
            this.PasswordChangeLayout.SetColumnSpan(this.NewPasswordTextBox, 2);
            this.NewPasswordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.NewPasswordTextBox.Location = new System.Drawing.Point(3, 48);
            this.NewPasswordTextBox.MaxLength = 50;
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.Size = new System.Drawing.Size(365, 20);
            this.NewPasswordTextBox.TabIndex = 1;
            this.NewPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewPasswordTextBox.UseSystemPasswordChar = true;
            this.NewPasswordTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.NewPasswordTextBox.WaterMarkText = "Nueva Contraseña";
            // 
            // NewPasswordRTextBox
            // 
            this.PasswordChangeLayout.SetColumnSpan(this.NewPasswordRTextBox, 2);
            this.NewPasswordRTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewPasswordRTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.NewPasswordRTextBox.Location = new System.Drawing.Point(3, 94);
            this.NewPasswordRTextBox.MaxLength = 50;
            this.NewPasswordRTextBox.Name = "NewPasswordRTextBox";
            this.NewPasswordRTextBox.Size = new System.Drawing.Size(365, 20);
            this.NewPasswordRTextBox.TabIndex = 2;
            this.NewPasswordRTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewPasswordRTextBox.UseSystemPasswordChar = true;
            this.NewPasswordRTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.NewPasswordRTextBox.WaterMarkText = "Repetir Nueva Contraseña";
            // 
            // SystemUserChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 225);
            this.Controls.Add(this.PasswordChangeLayout);
            this.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SystemUserChangePasswordForm";
            this.Text = "Cambiar Contraseña";
            this.Controls.SetChildIndex(this.PasswordChangeLayout, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.PasswordChangeLayout.ResumeLayout(false);
            this.PasswordChangeLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PasswordChangeLayout;
        private CustomControls.WaterMarkTextBox CurrentPasswordTextBox;
        private System.Windows.Forms.Panel ButtonsPanel;
        private CustomControls.WaterMarkTextBox NewPasswordTextBox;
        private CustomControls.WaterMarkTextBox NewPasswordRTextBox;
    }
}