using System;
using System.Linq;
using System.Windows.Forms;
using Util;

namespace GUI.CustomControls
{
    public partial class ComboBoxWaterMark<T> : ComboBox
        where T : Entity.BaseEntity<Guid>
    {
        private Repository.BaseRepository<T> Repository;
        public ComboBoxWaterMark(Repository.BaseRepository<T> Repository, String DisplayMember, String ValueMember)
        {
            this.Repository = Repository;
            this.DrawMode = DrawMode.OwnerDrawFixed;

            InitializeComponent();

            SetStyle(ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

            this.DisplayMember = DisplayMember;
            this.ValueMember = ValueMember;
            
            TextChanged += ComboBoxWaterMark_TextChanged;
            MeasureItem += ComboBoxWaterMark_MeasureItem;
            DrawItem += ComboBoxWaterMark_DrawItem;
        }

        private void ComboBoxWaterMark_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemWidth = Width;
            e.ItemHeight = Height;
        }

        private void ComboBoxWaterMark_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if(e.Index >= 0)
            {
                System.Drawing.StringFormat sf = new System.Drawing.StringFormat();
                sf.LineAlignment = System.Drawing.StringAlignment.Center;
                sf.Alignment = System.Drawing.StringAlignment.Center;

                System.Drawing.Brush brush = new System.Drawing.SolidBrush(ForeColor);
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    brush = System.Drawing.SystemBrushes.HighlightText;
                }
                e.Graphics.DrawString(Items[e.Index].ToString(), Font, brush, e.Bounds, sf);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            using (System.Drawing.Brush br = new System.Drawing.SolidBrush(this.ForeColor))
            {
                System.Drawing.StringFormat sformat = new System.Drawing.StringFormat();
                sformat.LineAlignment = System.Drawing.StringAlignment.Center;
                sformat.Alignment = System.Drawing.StringAlignment.Center;
                e.Graphics.DrawString(this.Text, this.Font, br, this.ClientRectangle, sformat);
            }
        }

        private void ComboBoxWaterMark_TextChanged(object sender, EventArgs e)
        {
            if (SelectedItem == null)
            {
                FillComboBox();
                SelectionStart = Text.Length;
            }
        }

        private void FillComboBox()
        {
            IQueryable<T> ProductCategories = Repository.FindForComboBox(Text, true, 20);
            this.FillComboBox<T>(ProductCategories);
        }
    }
}
