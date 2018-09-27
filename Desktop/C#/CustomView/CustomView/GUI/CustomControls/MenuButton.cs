using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomView.GUI.CustomControls
{
    public partial class MenuButton : Button
    {
        public String EntityName { get; set; }
        public MenuButton()
        {
            InitializeComponent();

            this.Enabled = false;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Location = new System.Drawing.Point(0, 50);
            this.Name = "BoxButton";
            this.Size = new System.Drawing.Size(250, 55);
            this.Text = "Cooler";
            this.UseVisualStyleBackColor = true;
        }
    }
}
