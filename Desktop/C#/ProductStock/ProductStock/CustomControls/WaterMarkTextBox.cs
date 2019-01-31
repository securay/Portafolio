using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.CustomControls
{
    public class WaterMarkTextBox : TextBox
    {
        private Font oldFont = null;
        private bool waterMarkTextEnabled = false;

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

        private string _waterMarkText = "Water Mark";
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
            Font drawFont = new Font(Font.FontFamily,
                Font.Size, Font.Style, Font.Unit);
            SolidBrush drawBrush = new SolidBrush(WaterMarkColor);
            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            args.Graphics.DrawString((waterMarkTextEnabled ? WaterMarkText : Text),
                drawFont, drawBrush, new Rectangle(0, -2, Width, Height), stringFormat);
            base.OnPaint(args);
        }

        private void JoinEvents(bool join)
        {
            if (join)
            {
                TextChanged += new EventHandler(WaterMark_Toggel);
                LostFocus += new EventHandler(WaterMark_Toggel);
                FontChanged += new EventHandler(WaterMark_FontChanged);
            }
        }

        private void WaterMark_Toggel(object sender, EventArgs args)
        {
            if (Text.Length <= 0)
                EnableWaterMark();
            else
                DisbaleWaterMark();
        }

        private void EnableWaterMark()
        {
            oldFont = new Font(Font.FontFamily, Font.Size, Font.Style,
               Font.Unit);
            SetStyle(ControlStyles.UserPaint, true);
            waterMarkTextEnabled = true;
            Refresh();
        }

        private void DisbaleWaterMark()
        {
            waterMarkTextEnabled = false;
            SetStyle(ControlStyles.UserPaint, false);
            if (oldFont != null)
                Font = new Font(oldFont.FontFamily, oldFont.Size,
                    oldFont.Style, oldFont.Unit);
        }

        private void WaterMark_FontChanged(object sender, EventArgs args)
        {
            if (waterMarkTextEnabled)
            {
                oldFont = new Font(Font.FontFamily, Font.Size, Font.Style,
                    Font.Unit);
                Refresh();
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // WaterMarkTextBox
            // 
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResumeLayout(false);

        }
    }
}
