using System;
using System.Windows.Forms;

namespace GUI.CustomControls
{
    public partial class ComboBoxWaterMark : ComboBox
    {
        public Action FillComboBox;
        public string QueryText { get; set; }
        public string WaterMarkText { get; set; }
        public ComboBoxWaterMark()
        {
            InitializeComponent();

            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.DropDownStyle = ComboBoxStyle.DropDownList;

            QueryText = "";

            DrawItem += ComboBoxWaterMark_DrawItem;
            KeyPress += ComboBoxWaterMark_KeyPress;
            SelectedIndexChanged += ComboBoxWaterMark_SelectedIndexChanged;
        }

        public void Init(string DisplayMember, string ValueMember, string WaterMarkText, Action FillComboBox)
        {
            this.DisplayMember = DisplayMember;
            this.ValueMember = ValueMember;
            this.WaterMarkText = WaterMarkText;
            this.FillComboBox = FillComboBox;
            this.FillComboBox();
        }

        private void ComboBoxWaterMark_SelectedIndexChanged(object sender, EventArgs e)
        {
            QueryText = "";
        }

        private void ComboBoxWaterMark_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar != (char)13))
            {
                if (char.IsLetterOrDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                {
                    QueryText += e.KeyChar;
                }
                else if (((int)e.KeyChar) == 8)
                {
                    if (QueryText.Length > 0)
                    {
                        QueryText = QueryText.Substring(0, QueryText.Length - 1);
                    }
                }
                
                FillComboBox?.Invoke();
            }
        }

        private void ComboBoxWaterMark_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            System.Drawing.StringFormat sf = new System.Drawing.StringFormat();
            sf.LineAlignment = System.Drawing.StringAlignment.Center;
            sf.Alignment = System.Drawing.StringAlignment.Center;

            if (e.Index > 0)
            {
                System.Drawing.Brush brush = new System.Drawing.SolidBrush(ForeColor);
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    brush = System.Drawing.SystemBrushes.HighlightText;
                }
                e.Graphics.DrawString(Items[e.Index].ToString(), Font, brush, e.Bounds, sf);
            }
            else
            {
                e.Graphics.DrawString(WaterMarkText, Font, System.Drawing.SystemBrushes.GrayText, e.Bounds, sf);
            }
            e.DrawFocusRectangle();
        }
    }
}
