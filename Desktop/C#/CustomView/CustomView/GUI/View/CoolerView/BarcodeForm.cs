using GUI.CustomControls;
using System;
using System.Drawing;

namespace GUI.View.CoolerView
{
    public partial class BarcodeForm : BaseForm
    {
        private string Barcode;
        private string Code;
        private string Acronym;
        private decimal Capacity;
        private Bitmap DrawArea;
        public BarcodeForm(string Barcode, string Code, decimal Capacity, string Acronym)
        {
            this.Barcode = Barcode;
            this.Code = Code;
            this.Capacity = Capacity;
            this.Acronym = Acronym;

            InitializeComponent();

            DrawBarcode();
            SaveFileDialog.FileName = String.Format("{0}-{1}.bmp", Code, Barcode);
        }

        private void DrawBarcode()
        {
            DrawArea = new Bitmap(BarcodePictureBox.Size.Width, BarcodePictureBox.Size.Height);
            using (Graphics g = Graphics.FromImage(DrawArea))
            {
                Font BarCodeFont = new Font("Free 3 of 9", 35, FontStyle.Regular);
                Font TextFont = new Font("Verdana", 15, FontStyle.Bold);
                Rectangle R = new Rectangle(0, 0, 394, 224);
                StringFormat drawFormat = new StringFormat();
                drawFormat.Alignment = StringAlignment.Center;

                g.Clear(Color.White);
                R.Y = 45;
                g.DrawString(String.Format("*{0}*", Barcode), BarCodeFont, Brushes.Black, R, drawFormat);
                R.Y = 80;
                g.DrawString(String.Format("*{0}*", Barcode), BarCodeFont, Brushes.Black, R, drawFormat);
                R.Y = 110;
                g.DrawString(Barcode, TextFont, Brushes.Black, R, drawFormat);
                R.Y = 130;
                g.DrawString(Code, TextFont, Brushes.Black, R, drawFormat);
                R.Y = 160;
                g.DrawString(String.Format("{0} {1}", Capacity.ToString("#0.00"), Acronym), TextFont, Brushes.Black, R, drawFormat);
            }
            BarcodePictureBox.Image = DrawArea;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BarcodePictureBox.Image.Save(SaveFileDialog.FileName);
                Close();
            }
        }
    }
}
