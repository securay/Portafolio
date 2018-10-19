namespace GUI.Auth.SystemUserView
{
    partial class SystemUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /*protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SystemUserLayout = new System.Windows.Forms.TableLayoutPanel();
            this.EmployeeComboBox = new GUI.CustomControls.ComboBoxWaterMark();
            this.UsernameTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.ExpirationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MultiSessionCheckBox = new System.Windows.Forms.CheckBox();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SystemUserLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // SystemUserLayout
            // 
            this.SystemUserLayout.BackColor = System.Drawing.Color.Transparent;
            this.SystemUserLayout.ColumnCount = 2;
            this.SystemUserLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SystemUserLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SystemUserLayout.Controls.Add(this.EmployeeComboBox, 0, 0);
            this.SystemUserLayout.Controls.Add(this.UsernameTextBox, 0, 2);
            this.SystemUserLayout.Controls.Add(this.ExpirationDateTimePicker, 0, 4);
            this.SystemUserLayout.Controls.Add(this.MultiSessionCheckBox, 1, 2);
            this.SystemUserLayout.Controls.Add(this.ButtonsPanel, 1, 6);
            this.SystemUserLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SystemUserLayout.ForeColor = System.Drawing.Color.Black;
            this.SystemUserLayout.Location = new System.Drawing.Point(0, 37);
            this.SystemUserLayout.Name = "SystemUserLayout";
            this.SystemUserLayout.RowCount = 7;
            this.SystemUserLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.SystemUserLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SystemUserLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.SystemUserLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SystemUserLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.SystemUserLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SystemUserLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.SystemUserLayout.Size = new System.Drawing.Size(466, 211);
            this.SystemUserLayout.TabIndex = 1;
            // 
            // EmployeeComboBox
            // 
            this.EmployeeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SystemUserLayout.SetColumnSpan(this.EmployeeComboBox, 2);
            this.EmployeeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.EmployeeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmployeeComboBox.ForeColor = System.Drawing.Color.Black;
            this.EmployeeComboBox.FormattingEnabled = true;
            this.EmployeeComboBox.Location = new System.Drawing.Point(3, 3);
            this.EmployeeComboBox.Name = "EmployeeComboBox";
            this.EmployeeComboBox.QueryText = "";
            this.EmployeeComboBox.Size = new System.Drawing.Size(460, 24);
            this.EmployeeComboBox.TabIndex = 0;
            this.EmployeeComboBox.WaterMarkText = null;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UsernameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.UsernameTextBox.ForeColor = System.Drawing.Color.Black;
            this.UsernameTextBox.Location = new System.Drawing.Point(3, 50);
            this.UsernameTextBox.MaxLength = 50;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(227, 20);
            this.UsernameTextBox.TabIndex = 2;
            this.UsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UsernameTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.UsernameTextBox.WaterMarkText = "Usuario";
            // 
            // ExpirationDateTimePicker
            // 
            this.ExpirationDateTimePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SystemUserLayout.SetColumnSpan(this.ExpirationDateTimePicker, 2);
            this.ExpirationDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpirationDateTimePicker.ForeColor = System.Drawing.Color.Black;
            this.ExpirationDateTimePicker.Location = new System.Drawing.Point(3, 97);
            this.ExpirationDateTimePicker.Name = "ExpirationDateTimePicker";
            this.ExpirationDateTimePicker.Size = new System.Drawing.Size(460, 23);
            this.ExpirationDateTimePicker.TabIndex = 4;
            // 
            // MultiSessionCheckBox
            // 
            this.MultiSessionCheckBox.AutoSize = true;
            this.MultiSessionCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultiSessionCheckBox.ForeColor = System.Drawing.Color.Black;
            this.MultiSessionCheckBox.Location = new System.Drawing.Point(236, 50);
            this.MultiSessionCheckBox.Name = "MultiSessionCheckBox";
            this.MultiSessionCheckBox.Size = new System.Drawing.Size(227, 21);
            this.MultiSessionCheckBox.TabIndex = 5;
            this.MultiSessionCheckBox.Text = "Multi Sesión";
            this.MultiSessionCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MultiSessionCheckBox.UseVisualStyleBackColor = true;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsPanel.ForeColor = System.Drawing.Color.Black;
            this.ButtonsPanel.Location = new System.Drawing.Point(236, 144);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(227, 64);
            this.ButtonsPanel.TabIndex = 6;
            // 
            // SystemUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 248);
            this.Controls.Add(this.SystemUserLayout);
            this.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SystemUserForm";
            this.Text = "Usuario";
            this.Controls.SetChildIndex(this.SystemUserLayout, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.SystemUserLayout.ResumeLayout(false);
            this.SystemUserLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel SystemUserLayout;
        private CustomControls.ComboBoxWaterMark EmployeeComboBox;
        private CustomControls.WaterMarkTextBox UsernameTextBox;
        private System.Windows.Forms.DateTimePicker ExpirationDateTimePicker;
        private System.Windows.Forms.CheckBox MultiSessionCheckBox;
        private System.Windows.Forms.Panel ButtonsPanel;
    }
}