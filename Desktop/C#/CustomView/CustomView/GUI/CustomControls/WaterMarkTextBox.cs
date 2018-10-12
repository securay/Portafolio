using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.CustomControls
{
    public class WaterMarkTextBox : TextBox
    {
        private Font oldFont = null;
        private Boolean waterMarkTextEnabled = false;

        #region Attributes
        private Color _waterMarkColor = Color.Gray;
        public Color WaterMarkColor
        {
            get { return _waterMarkColor; }
            set
            {
                _waterMarkColor = value; Invalidate();
            }
        }

        private string _waterMarkText = "Marca de Agua";
        public string WaterMarkText
        {
            get { return _waterMarkText; }
            set { _waterMarkText = value; Invalidate(); }
        }
        #endregion

        public WaterMarkTextBox()
        {
            JoinEvents(true);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            WaterMark_Toggel(null, null);
            TextAlign = HorizontalAlignment.Center;
        }

        protected override void OnPaint(PaintEventArgs args)
        {
            System.Drawing.Font drawFont = new System.Drawing.Font(Font.FontFamily,
                Font.Size, Font.Style, Font.Unit);
            SolidBrush drawBrush = new SolidBrush(WaterMarkColor);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            args.Graphics.DrawString((waterMarkTextEnabled ? WaterMarkText : Text),
                drawFont, drawBrush, new Rectangle(0, -2, this.Width, this.Height), stringFormat);
            base.OnPaint(args);
        }

        private void JoinEvents(Boolean join)
        {
            if (join)
            {
                this.TextChanged += new System.EventHandler(this.WaterMark_Toggel);
                this.LostFocus += new System.EventHandler(this.WaterMark_Toggel);
                this.FontChanged += new System.EventHandler(this.WaterMark_FontChanged);
            }
        }

        private void WaterMark_Toggel(object sender, EventArgs args)
        {
            if (this.Text.Length <= 0)
                EnableWaterMark();
            else
                DisbaleWaterMark();
        }

        private void EnableWaterMark()
        {
            oldFont = new System.Drawing.Font(Font.FontFamily, Font.Size, Font.Style,
               Font.Unit);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.waterMarkTextEnabled = true;
            Refresh();
        }

        private void DisbaleWaterMark()
        {
            this.waterMarkTextEnabled = false;
            this.SetStyle(ControlStyles.UserPaint, false);
            if (oldFont != null)
                this.Font = new System.Drawing.Font(oldFont.FontFamily, oldFont.Size,
                    oldFont.Style, oldFont.Unit);
        }

        private void WaterMark_FontChanged(object sender, EventArgs args)
        {
            if (waterMarkTextEnabled)
            {
                oldFont = new System.Drawing.Font(Font.FontFamily, Font.Size, Font.Style,
                    Font.Unit);
                Refresh();
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
