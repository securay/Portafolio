namespace GUI.Start
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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.HeadPanel = new System.Windows.Forms.Panel();
            this.LastConnectionLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.TimePictureBox = new System.Windows.Forms.PictureBox();
            this.UserPictureBox = new System.Windows.Forms.PictureBox();
            this.MenuPictureBox = new System.Windows.Forms.PictureBox();
            this.MaximizePictureBox = new System.Windows.Forms.PictureBox();
            this.RestorePictureBox = new System.Windows.Forms.PictureBox();
            this.MinimizePictureBox = new System.Windows.Forms.PictureBox();
            this.ClosePictureBox = new System.Windows.Forms.PictureBox();
            this.PermissionsButton = new CustomView.GUI.CustomControls.MenuButton();
            this.SystemUserButton = new CustomView.GUI.CustomControls.MenuButton();
            this.EmployeeButton = new CustomView.GUI.CustomControls.MenuButton();
            this.ServiceOrderCoolerButton = new CustomView.GUI.CustomControls.MenuButton();
            this.ServiceOrderButton = new CustomView.GUI.CustomControls.MenuButton();
            this.CustomerButton = new CustomView.GUI.CustomControls.MenuButton();
            this.CoolersButton = new CustomView.GUI.CustomControls.MenuButton();
            this.ChangePasswordButton = new CustomView.GUI.CustomControls.MenuButton();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.HeadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestorePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.MenuPanel.Controls.Add(this.ChangePasswordButton);
            this.MenuPanel.Controls.Add(this.PermissionsButton);
            this.MenuPanel.Controls.Add(this.SystemUserButton);
            this.MenuPanel.Controls.Add(this.EmployeeButton);
            this.MenuPanel.Controls.Add(this.ServiceOrderCoolerButton);
            this.MenuPanel.Controls.Add(this.ServiceOrderButton);
            this.MenuPanel.Controls.Add(this.CustomerButton);
            this.MenuPanel.Controls.Add(this.CoolersButton);
            this.MenuPanel.Controls.Add(this.LogoPictureBox);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(250, 768);
            this.MenuPanel.TabIndex = 0;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(250, 50);
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // HeadPanel
            // 
            this.HeadPanel.BackColor = System.Drawing.Color.White;
            this.HeadPanel.Controls.Add(this.LastConnectionLabel);
            this.HeadPanel.Controls.Add(this.UserLabel);
            this.HeadPanel.Controls.Add(this.TimePictureBox);
            this.HeadPanel.Controls.Add(this.UserPictureBox);
            this.HeadPanel.Controls.Add(this.MenuPictureBox);
            this.HeadPanel.Controls.Add(this.MaximizePictureBox);
            this.HeadPanel.Controls.Add(this.RestorePictureBox);
            this.HeadPanel.Controls.Add(this.MinimizePictureBox);
            this.HeadPanel.Controls.Add(this.ClosePictureBox);
            this.HeadPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadPanel.Location = new System.Drawing.Point(250, 0);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(774, 50);
            this.HeadPanel.TabIndex = 1;
            // 
            // LastConnectionLabel
            // 
            this.LastConnectionLabel.AutoSize = true;
            this.LastConnectionLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastConnectionLabel.Location = new System.Drawing.Point(88, 30);
            this.LastConnectionLabel.Name = "LastConnectionLabel";
            this.LastConnectionLabel.Size = new System.Drawing.Size(125, 14);
            this.LastConnectionLabel.TabIndex = 8;
            this.LastConnectionLabel.Text = "18/09/2018 00:00";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.Location = new System.Drawing.Point(88, 3);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(155, 16);
            this.UserLabel.TabIndex = 7;
            this.UserLabel.Text = "SA / SUPER ADMIN, SA";
            // 
            // TimePictureBox
            // 
            this.TimePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TimePictureBox.Image")));
            this.TimePictureBox.Location = new System.Drawing.Point(62, 27);
            this.TimePictureBox.Name = "TimePictureBox";
            this.TimePictureBox.Size = new System.Drawing.Size(20, 20);
            this.TimePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.TimePictureBox.TabIndex = 6;
            this.TimePictureBox.TabStop = false;
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UserPictureBox.Image")));
            this.UserPictureBox.Location = new System.Drawing.Point(62, 1);
            this.UserPictureBox.Name = "UserPictureBox";
            this.UserPictureBox.Size = new System.Drawing.Size(20, 20);
            this.UserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.UserPictureBox.TabIndex = 5;
            this.UserPictureBox.TabStop = false;
            // 
            // MenuPictureBox
            // 
            this.MenuPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MenuPictureBox.Image")));
            this.MenuPictureBox.Location = new System.Drawing.Point(6, 0);
            this.MenuPictureBox.Name = "MenuPictureBox";
            this.MenuPictureBox.Size = new System.Drawing.Size(50, 50);
            this.MenuPictureBox.TabIndex = 4;
            this.MenuPictureBox.TabStop = false;
            this.MenuPictureBox.Click += new System.EventHandler(this.MenuPictureBox_Click);
            // 
            // MaximizePictureBox
            // 
            this.MaximizePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MaximizePictureBox.Image")));
            this.MaximizePictureBox.Location = new System.Drawing.Point(717, 3);
            this.MaximizePictureBox.Name = "MaximizePictureBox";
            this.MaximizePictureBox.Size = new System.Drawing.Size(26, 26);
            this.MaximizePictureBox.TabIndex = 3;
            this.MaximizePictureBox.TabStop = false;
            this.MaximizePictureBox.Click += new System.EventHandler(this.MaximizePictureBox_Click);
            // 
            // RestorePictureBox
            // 
            this.RestorePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestorePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RestorePictureBox.Image")));
            this.RestorePictureBox.Location = new System.Drawing.Point(717, 3);
            this.RestorePictureBox.Name = "RestorePictureBox";
            this.RestorePictureBox.Size = new System.Drawing.Size(26, 26);
            this.RestorePictureBox.TabIndex = 2;
            this.RestorePictureBox.TabStop = false;
            this.RestorePictureBox.Visible = false;
            this.RestorePictureBox.Click += new System.EventHandler(this.RestorePictureBox_Click);
            // 
            // MinimizePictureBox
            // 
            this.MinimizePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MinimizePictureBox.Image")));
            this.MinimizePictureBox.Location = new System.Drawing.Point(687, 3);
            this.MinimizePictureBox.Name = "MinimizePictureBox";
            this.MinimizePictureBox.Size = new System.Drawing.Size(26, 26);
            this.MinimizePictureBox.TabIndex = 1;
            this.MinimizePictureBox.TabStop = false;
            this.MinimizePictureBox.Click += new System.EventHandler(this.MinimizePictureBox_Click);
            // 
            // ClosePictureBox
            // 
            this.ClosePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClosePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ClosePictureBox.Image")));
            this.ClosePictureBox.Location = new System.Drawing.Point(747, 3);
            this.ClosePictureBox.Name = "ClosePictureBox";
            this.ClosePictureBox.Size = new System.Drawing.Size(26, 26);
            this.ClosePictureBox.TabIndex = 0;
            this.ClosePictureBox.TabStop = false;
            this.ClosePictureBox.Click += new System.EventHandler(this.ClosePictureBox_Click);
            // 
            // PermissionsButton
            // 
            this.PermissionsButton.Enabled = false;
            this.PermissionsButton.EntityName = "SystemUserPermission";
            this.PermissionsButton.FlatAppearance.BorderSize = 0;
            this.PermissionsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.PermissionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PermissionsButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PermissionsButton.ForeColor = System.Drawing.Color.White;
            this.PermissionsButton.Image = ((System.Drawing.Image)(resources.GetObject("PermissionsButton.Image")));
            this.PermissionsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PermissionsButton.Location = new System.Drawing.Point(0, 422);
            this.PermissionsButton.Name = "PermissionsButton";
            this.PermissionsButton.Size = new System.Drawing.Size(250, 55);
            this.PermissionsButton.TabIndex = 8;
            this.PermissionsButton.Text = "Permisos";
            this.PermissionsButton.UseVisualStyleBackColor = true;
            this.PermissionsButton.Click += new System.EventHandler(this.PermissionsButton_Click);
            // 
            // SystemUserButton
            // 
            this.SystemUserButton.Enabled = false;
            this.SystemUserButton.EntityName = "SystemUserRow";
            this.SystemUserButton.FlatAppearance.BorderSize = 0;
            this.SystemUserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.SystemUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SystemUserButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemUserButton.ForeColor = System.Drawing.Color.White;
            this.SystemUserButton.Image = ((System.Drawing.Image)(resources.GetObject("SystemUserButton.Image")));
            this.SystemUserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SystemUserButton.Location = new System.Drawing.Point(3, 361);
            this.SystemUserButton.Name = "SystemUserButton";
            this.SystemUserButton.Size = new System.Drawing.Size(250, 55);
            this.SystemUserButton.TabIndex = 7;
            this.SystemUserButton.Text = "Usuarios";
            this.SystemUserButton.UseVisualStyleBackColor = true;
            this.SystemUserButton.Click += new System.EventHandler(this.SystemUserButton_Click);
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.Enabled = false;
            this.EmployeeButton.EntityName = "EmployeeRow";
            this.EmployeeButton.FlatAppearance.BorderSize = 0;
            this.EmployeeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.EmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeButton.ForeColor = System.Drawing.Color.White;
            this.EmployeeButton.Image = ((System.Drawing.Image)(resources.GetObject("EmployeeButton.Image")));
            this.EmployeeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmployeeButton.Location = new System.Drawing.Point(0, 300);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(250, 55);
            this.EmployeeButton.TabIndex = 6;
            this.EmployeeButton.Text = "Empleados";
            this.EmployeeButton.UseVisualStyleBackColor = true;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // ServiceOrderCoolerButton
            // 
            this.ServiceOrderCoolerButton.Enabled = false;
            this.ServiceOrderCoolerButton.EntityName = "ServiceOrderCoolerRow";
            this.ServiceOrderCoolerButton.FlatAppearance.BorderSize = 0;
            this.ServiceOrderCoolerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ServiceOrderCoolerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServiceOrderCoolerButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceOrderCoolerButton.ForeColor = System.Drawing.Color.White;
            this.ServiceOrderCoolerButton.Image = ((System.Drawing.Image)(resources.GetObject("ServiceOrderCoolerButton.Image")));
            this.ServiceOrderCoolerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ServiceOrderCoolerButton.Location = new System.Drawing.Point(0, 239);
            this.ServiceOrderCoolerButton.Name = "ServiceOrderCoolerButton";
            this.ServiceOrderCoolerButton.Size = new System.Drawing.Size(250, 55);
            this.ServiceOrderCoolerButton.TabIndex = 5;
            this.ServiceOrderCoolerButton.Text = "Recepción";
            this.ServiceOrderCoolerButton.UseVisualStyleBackColor = true;
            this.ServiceOrderCoolerButton.Click += new System.EventHandler(this.ServiceOrderCoolerButton_Click);
            // 
            // ServiceOrderButton
            // 
            this.ServiceOrderButton.Enabled = false;
            this.ServiceOrderButton.EntityName = "ServiceOrderRow";
            this.ServiceOrderButton.FlatAppearance.BorderSize = 0;
            this.ServiceOrderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ServiceOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServiceOrderButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceOrderButton.ForeColor = System.Drawing.Color.White;
            this.ServiceOrderButton.Image = ((System.Drawing.Image)(resources.GetObject("ServiceOrderButton.Image")));
            this.ServiceOrderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ServiceOrderButton.Location = new System.Drawing.Point(0, 178);
            this.ServiceOrderButton.Name = "ServiceOrderButton";
            this.ServiceOrderButton.Size = new System.Drawing.Size(250, 55);
            this.ServiceOrderButton.TabIndex = 4;
            this.ServiceOrderButton.Text = "Orden de Servicio";
            this.ServiceOrderButton.UseVisualStyleBackColor = true;
            this.ServiceOrderButton.Click += new System.EventHandler(this.ServiceOrderButton_Click);
            // 
            // CustomerButton
            // 
            this.CustomerButton.Enabled = false;
            this.CustomerButton.EntityName = "Customer";
            this.CustomerButton.FlatAppearance.BorderSize = 0;
            this.CustomerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.CustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerButton.ForeColor = System.Drawing.Color.White;
            this.CustomerButton.Image = ((System.Drawing.Image)(resources.GetObject("CustomerButton.Image")));
            this.CustomerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomerButton.Location = new System.Drawing.Point(0, 117);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(250, 55);
            this.CustomerButton.TabIndex = 3;
            this.CustomerButton.Text = "Clientes";
            this.CustomerButton.UseVisualStyleBackColor = true;
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // CoolersButton
            // 
            this.CoolersButton.Enabled = false;
            this.CoolersButton.EntityName = "CoolerRow";
            this.CoolersButton.FlatAppearance.BorderSize = 0;
            this.CoolersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.CoolersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CoolersButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoolersButton.ForeColor = System.Drawing.Color.White;
            this.CoolersButton.Image = ((System.Drawing.Image)(resources.GetObject("CoolersButton.Image")));
            this.CoolersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CoolersButton.Location = new System.Drawing.Point(0, 56);
            this.CoolersButton.Name = "CoolersButton";
            this.CoolersButton.Size = new System.Drawing.Size(250, 55);
            this.CoolersButton.TabIndex = 2;
            this.CoolersButton.Text = "Coolers";
            this.CoolersButton.UseVisualStyleBackColor = true;
            this.CoolersButton.Click += new System.EventHandler(this.CoolersButton_Click);
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Enabled = false;
            this.ChangePasswordButton.EntityName = "SystemUser";
            this.ChangePasswordButton.FlatAppearance.BorderSize = 0;
            this.ChangePasswordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ChangePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePasswordButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordButton.ForeColor = System.Drawing.Color.White;
            this.ChangePasswordButton.Image = ((System.Drawing.Image)(resources.GetObject("ChangePasswordButton.Image")));
            this.ChangePasswordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangePasswordButton.Location = new System.Drawing.Point(0, 483);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(250, 55);
            this.ChangePasswordButton.TabIndex = 9;
            this.ChangePasswordButton.Text = "Cambiar Contraseña";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.HeadPanel);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.HeadPanel.ResumeLayout(false);
            this.HeadPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestorePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Panel HeadPanel;
        private System.Windows.Forms.PictureBox MaximizePictureBox;
        private System.Windows.Forms.PictureBox RestorePictureBox;
        private System.Windows.Forms.PictureBox MinimizePictureBox;
        private System.Windows.Forms.PictureBox ClosePictureBox;
        private System.Windows.Forms.PictureBox MenuPictureBox;
        private System.Windows.Forms.Label LastConnectionLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.PictureBox TimePictureBox;
        private System.Windows.Forms.PictureBox UserPictureBox;
        private CustomView.GUI.CustomControls.MenuButton CoolersButton;
        private CustomView.GUI.CustomControls.MenuButton CustomerButton;
        private CustomView.GUI.CustomControls.MenuButton ServiceOrderButton;
        private CustomView.GUI.CustomControls.MenuButton ServiceOrderCoolerButton;
        private CustomView.GUI.CustomControls.MenuButton EmployeeButton;
        private CustomView.GUI.CustomControls.MenuButton SystemUserButton;
        private CustomView.GUI.CustomControls.MenuButton PermissionsButton;
        private CustomView.GUI.CustomControls.MenuButton ChangePasswordButton;
    }
}