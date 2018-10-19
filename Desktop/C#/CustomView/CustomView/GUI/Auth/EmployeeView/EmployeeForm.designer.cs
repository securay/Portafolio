namespace GUI.Auth.EmployeeView
{
    partial class EmployeeForm
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
            this.EmployeeLayout = new System.Windows.Forms.TableLayoutPanel();
            this.DocumentTypeComboBox = new GUI.CustomControls.ComboBoxWaterMark();
            this.DocumentNumberComboBox = new GUI.CustomControls.WaterMarkTextBox();
            this.PaternalSurnameTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.MaternalSurnameTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.PersonNameTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.PhoneTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.EmailTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.AddressTextBox = new GUI.CustomControls.WaterMarkTextBox();
            this.DependencyComboBox = new GUI.CustomControls.ComboBoxWaterMark();
            this.PositionComboBox = new GUI.CustomControls.ComboBoxWaterMark();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.EmployeeLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeLayout
            // 
            this.EmployeeLayout.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeLayout.ColumnCount = 3;
            this.EmployeeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EmployeeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.EmployeeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EmployeeLayout.Controls.Add(this.DocumentTypeComboBox, 0, 0);
            this.EmployeeLayout.Controls.Add(this.DocumentNumberComboBox, 2, 0);
            this.EmployeeLayout.Controls.Add(this.PaternalSurnameTextBox, 0, 2);
            this.EmployeeLayout.Controls.Add(this.MaternalSurnameTextBox, 2, 2);
            this.EmployeeLayout.Controls.Add(this.PersonNameTextBox, 0, 4);
            this.EmployeeLayout.Controls.Add(this.PhoneTextBox, 0, 6);
            this.EmployeeLayout.Controls.Add(this.EmailTextBox, 2, 6);
            this.EmployeeLayout.Controls.Add(this.ButtonsPanel, 2, 12);
            this.EmployeeLayout.Controls.Add(this.AddressTextBox, 0, 8);
            this.EmployeeLayout.Controls.Add(this.DependencyComboBox, 2, 8);
            this.EmployeeLayout.Controls.Add(this.PositionComboBox, 0, 10);
            this.EmployeeLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeLayout.ForeColor = System.Drawing.Color.Black;
            this.EmployeeLayout.Location = new System.Drawing.Point(0, 30);
            this.EmployeeLayout.Name = "EmployeeLayout";
            this.EmployeeLayout.RowCount = 13;
            this.EmployeeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.EmployeeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.EmployeeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.EmployeeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.EmployeeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.EmployeeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.EmployeeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.EmployeeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.EmployeeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.EmployeeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.EmployeeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.EmployeeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.EmployeeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.EmployeeLayout.Size = new System.Drawing.Size(614, 320);
            this.EmployeeLayout.TabIndex = 1;
            // 
            // DocumentTypeComboBox
            // 
            this.DocumentTypeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DocumentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DocumentTypeComboBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentTypeComboBox.FormattingEnabled = true;
            this.DocumentTypeComboBox.Location = new System.Drawing.Point(3, 3);
            this.DocumentTypeComboBox.Name = "DocumentTypeComboBox";
            this.DocumentTypeComboBox.QueryText = "";
            this.DocumentTypeComboBox.Size = new System.Drawing.Size(291, 24);
            this.DocumentTypeComboBox.TabIndex = 1;
            this.DocumentTypeComboBox.WaterMarkText = "Tipo de Documento";
            // 
            // DocumentNumberComboBox
            // 
            this.DocumentNumberComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentNumberComboBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentNumberComboBox.Location = new System.Drawing.Point(320, 3);
            this.DocumentNumberComboBox.MaxLength = 50;
            this.DocumentNumberComboBox.Name = "DocumentNumberComboBox";
            this.DocumentNumberComboBox.Size = new System.Drawing.Size(291, 23);
            this.DocumentNumberComboBox.TabIndex = 3;
            this.DocumentNumberComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DocumentNumberComboBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.DocumentNumberComboBox.WaterMarkText = "Número de Documento de Identidad";
            // 
            // PaternalSurnameTextBox
            // 
            this.PaternalSurnameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaternalSurnameTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaternalSurnameTextBox.Location = new System.Drawing.Point(3, 48);
            this.PaternalSurnameTextBox.MaxLength = 50;
            this.PaternalSurnameTextBox.Name = "PaternalSurnameTextBox";
            this.PaternalSurnameTextBox.Size = new System.Drawing.Size(291, 23);
            this.PaternalSurnameTextBox.TabIndex = 3;
            this.PaternalSurnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PaternalSurnameTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.PaternalSurnameTextBox.WaterMarkText = "Apellido Paterno";
            // 
            // MaternalSurnameTextBox
            // 
            this.MaternalSurnameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaternalSurnameTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaternalSurnameTextBox.Location = new System.Drawing.Point(320, 48);
            this.MaternalSurnameTextBox.MaxLength = 50;
            this.MaternalSurnameTextBox.Name = "MaternalSurnameTextBox";
            this.MaternalSurnameTextBox.Size = new System.Drawing.Size(291, 23);
            this.MaternalSurnameTextBox.TabIndex = 4;
            this.MaternalSurnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaternalSurnameTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.MaternalSurnameTextBox.WaterMarkText = "Apellido Materno";
            // 
            // PersonNameTextBox
            // 
            this.PersonNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonNameTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonNameTextBox.Location = new System.Drawing.Point(3, 93);
            this.PersonNameTextBox.MaxLength = 80;
            this.PersonNameTextBox.Name = "PersonNameTextBox";
            this.PersonNameTextBox.Size = new System.Drawing.Size(291, 23);
            this.PersonNameTextBox.TabIndex = 5;
            this.PersonNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PersonNameTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.PersonNameTextBox.WaterMarkText = "Nombres";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhoneTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTextBox.Location = new System.Drawing.Point(3, 138);
            this.PhoneTextBox.MaxLength = 150;
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(291, 23);
            this.PhoneTextBox.TabIndex = 7;
            this.PhoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhoneTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.PhoneTextBox.WaterMarkText = "Teléfono";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmailTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(320, 138);
            this.EmailTextBox.MaxLength = 200;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(291, 23);
            this.EmailTextBox.TabIndex = 8;
            this.EmailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmailTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.EmailTextBox.WaterMarkText = "E-Mail";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsPanel.Location = new System.Drawing.Point(320, 273);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(291, 44);
            this.ButtonsPanel.TabIndex = 13;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTextBox.Location = new System.Drawing.Point(3, 183);
            this.AddressTextBox.MaxLength = 200;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(291, 23);
            this.AddressTextBox.TabIndex = 9;
            this.AddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddressTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.AddressTextBox.WaterMarkText = "Dirección";
            // 
            // DependencyComboBox
            // 
            this.DependencyComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DependencyComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DependencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DependencyComboBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DependencyComboBox.FormattingEnabled = true;
            this.DependencyComboBox.Location = new System.Drawing.Point(320, 183);
            this.DependencyComboBox.Name = "DependencyComboBox";
            this.DependencyComboBox.QueryText = "";
            this.DependencyComboBox.Size = new System.Drawing.Size(291, 24);
            this.DependencyComboBox.TabIndex = 10;
            this.DependencyComboBox.WaterMarkText = "Área";
            // 
            // PositionComboBox
            // 
            this.PositionComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PositionComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PositionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositionComboBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionComboBox.FormattingEnabled = true;
            this.PositionComboBox.Location = new System.Drawing.Point(3, 228);
            this.PositionComboBox.Name = "PositionComboBox";
            this.PositionComboBox.QueryText = "";
            this.PositionComboBox.Size = new System.Drawing.Size(291, 24);
            this.PositionComboBox.TabIndex = 11;
            this.PositionComboBox.WaterMarkText = "Puesto";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 350);
            this.Controls.Add(this.EmployeeLayout);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "EmployeeForm";
            this.Text = "Empleado";
            this.Controls.SetChildIndex(this.EmployeeLayout, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.EmployeeLayout.ResumeLayout(false);
            this.EmployeeLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel EmployeeLayout;
        private CustomControls.ComboBoxWaterMark DocumentTypeComboBox;
        private CustomControls.WaterMarkTextBox DocumentNumberComboBox;
        private CustomControls.WaterMarkTextBox PaternalSurnameTextBox;
        private CustomControls.WaterMarkTextBox MaternalSurnameTextBox;
        private CustomControls.WaterMarkTextBox PersonNameTextBox;
        private CustomControls.WaterMarkTextBox PhoneTextBox;
        private CustomControls.WaterMarkTextBox EmailTextBox;
        private System.Windows.Forms.Panel ButtonsPanel;
        private CustomControls.WaterMarkTextBox AddressTextBox;
        private CustomControls.ComboBoxWaterMark DependencyComboBox;
        private CustomControls.ComboBoxWaterMark PositionComboBox;
    }
}