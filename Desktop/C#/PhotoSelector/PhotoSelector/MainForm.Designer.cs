namespace PhotoSelector
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.TargetLabel = new System.Windows.Forms.Label();
            this.SourceTextBox = new System.Windows.Forms.TextBox();
            this.SourceButton = new System.Windows.Forms.Button();
            this.TargetTextBox = new System.Windows.Forms.TextBox();
            this.TargetButton = new System.Windows.Forms.Button();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SplitLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.HelpLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.UncheckedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CheckedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.MainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.ColumnCount = 3;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.MainLayoutPanel.Controls.Add(this.SourceLabel, 0, 0);
            this.MainLayoutPanel.Controls.Add(this.TargetLabel, 0, 1);
            this.MainLayoutPanel.Controls.Add(this.SourceTextBox, 1, 0);
            this.MainLayoutPanel.Controls.Add(this.SourceButton, 2, 0);
            this.MainLayoutPanel.Controls.Add(this.TargetTextBox, 1, 1);
            this.MainLayoutPanel.Controls.Add(this.TargetButton, 2, 1);
            this.MainLayoutPanel.Controls.Add(this.MainPictureBox, 0, 2);
            this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowCount = 3;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(884, 461);
            this.MainLayoutPanel.TabIndex = 0;
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceLabel.Location = new System.Drawing.Point(3, 0);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(69, 25);
            this.SourceLabel.TabIndex = 0;
            this.SourceLabel.Text = "Origen";
            this.SourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TargetLabel
            // 
            this.TargetLabel.AutoSize = true;
            this.TargetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TargetLabel.Location = new System.Drawing.Point(3, 25);
            this.TargetLabel.Name = "TargetLabel";
            this.TargetLabel.Size = new System.Drawing.Size(69, 25);
            this.TargetLabel.TabIndex = 1;
            this.TargetLabel.Text = "Destino";
            this.TargetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceTextBox.Location = new System.Drawing.Point(78, 3);
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.ReadOnly = true;
            this.SourceTextBox.Size = new System.Drawing.Size(728, 20);
            this.SourceTextBox.TabIndex = 2;
            // 
            // SourceButton
            // 
            this.SourceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceButton.Location = new System.Drawing.Point(812, 3);
            this.SourceButton.Name = "SourceButton";
            this.SourceButton.Size = new System.Drawing.Size(69, 19);
            this.SourceButton.TabIndex = 3;
            this.SourceButton.Text = "...";
            this.SourceButton.UseVisualStyleBackColor = true;
            this.SourceButton.Click += new System.EventHandler(this.SourceButton_Click);
            // 
            // TargetTextBox
            // 
            this.TargetTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TargetTextBox.Location = new System.Drawing.Point(78, 28);
            this.TargetTextBox.Name = "TargetTextBox";
            this.TargetTextBox.ReadOnly = true;
            this.TargetTextBox.Size = new System.Drawing.Size(728, 20);
            this.TargetTextBox.TabIndex = 4;
            // 
            // TargetButton
            // 
            this.TargetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TargetButton.Location = new System.Drawing.Point(812, 28);
            this.TargetButton.Name = "TargetButton";
            this.TargetButton.Size = new System.Drawing.Size(69, 19);
            this.TargetButton.TabIndex = 5;
            this.TargetButton.Text = "...";
            this.TargetButton.UseVisualStyleBackColor = true;
            this.TargetButton.Click += new System.EventHandler(this.TargetButton_Click);
            // 
            // MainPictureBox
            // 
            this.MainLayoutPanel.SetColumnSpan(this.MainPictureBox, 3);
            this.MainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPictureBox.Location = new System.Drawing.Point(3, 53);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(878, 405);
            this.MainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainPictureBox.TabIndex = 6;
            this.MainPictureBox.TabStop = false;
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.SplitLabel,
            this.HelpLabel,
            this.UncheckedLabel,
            this.CheckedLabel});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 439);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(884, 22);
            this.MainStatusStrip.TabIndex = 1;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(81, 17);
            this.StatusLabel.Text = "PhotoSelector";
            this.StatusLabel.Click += new System.EventHandler(this.StatusLabel_Click);
            // 
            // SplitLabel
            // 
            this.SplitLabel.Image = ((System.Drawing.Image)(resources.GetObject("SplitLabel.Image")));
            this.SplitLabel.Name = "SplitLabel";
            this.SplitLabel.Size = new System.Drawing.Size(82, 17);
            this.SplitLabel.Text = "Solo copiar";
            this.SplitLabel.Click += new System.EventHandler(this.SplitLabel_Click);
            // 
            // HelpLabel
            // 
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(41, 17);
            this.HelpLabel.Text = "Ayuda";
            this.HelpLabel.Click += new System.EventHandler(this.HelpLabel_Click);
            // 
            // UncheckedLabel
            // 
            this.UncheckedLabel.Image = ((System.Drawing.Image)(resources.GetObject("UncheckedLabel.Image")));
            this.UncheckedLabel.Name = "UncheckedLabel";
            this.UncheckedLabel.Size = new System.Drawing.Size(16, 17);
            this.UncheckedLabel.Visible = false;
            // 
            // CheckedLabel
            // 
            this.CheckedLabel.Image = ((System.Drawing.Image)(resources.GetObject("CheckedLabel.Image")));
            this.CheckedLabel.Name = "CheckedLabel";
            this.CheckedLabel.Size = new System.Drawing.Size(16, 17);
            this.CheckedLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MainLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Selector";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MainLayoutPanel.ResumeLayout(false);
            this.MainLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.Label TargetLabel;
        private System.Windows.Forms.TextBox SourceTextBox;
        private System.Windows.Forms.Button SourceButton;
        private System.Windows.Forms.TextBox TargetTextBox;
        private System.Windows.Forms.Button TargetButton;
        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel HelpLabel;
        private System.Windows.Forms.ToolStripStatusLabel SplitLabel;
        private System.Windows.Forms.ToolStripStatusLabel UncheckedLabel;
        private System.Windows.Forms.ToolStripStatusLabel CheckedLabel;
    }
}

