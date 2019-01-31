using System;
using System.Windows.Forms;

namespace CustomView.GUI.CustomControls
{
    public partial class MenuButton : Button
    {
        public string EntityName { get; set; }
        public MenuButton()
        {
            InitializeComponent();

            //Enabled = false;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            FlatStyle = FlatStyle.Flat;
            Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.White;
            ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Location = new System.Drawing.Point(0, 50);
            Name = "BoxButton";
            Size = new System.Drawing.Size(200, 50);
            Text = "Cooler";
            UseVisualStyleBackColor = true;
        }
    }
}
