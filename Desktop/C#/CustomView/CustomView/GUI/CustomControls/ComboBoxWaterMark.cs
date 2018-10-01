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
        private bool isActivated;
        private TextFormatFlags _textFormatFlags = TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter;
        public ComboBoxWaterMark(Repository.BaseRepository<T> Repository, String DisplayMember, String ValueMember)
        {
            this.Repository = Repository;
            this.DrawMode = DrawMode.OwnerDrawVariable;

            //SetStyle(ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

            InitializeComponent();

            this.DisplayMember = DisplayMember;
            this.ValueMember = ValueMember;
            
            TextChanged += ComboBoxWaterMark_TextChanged;
            DrawItem += ComboBoxWaterMark_DrawItem;
        }

        public int GetDropDownWidth()
        {
            int w = ClientRectangle.Width;
            foreach (var s in Items)
            {
                int curW = TextRenderer.MeasureText(s.ToString(), Font).Width;
                if (curW > w)
                    w = curW;
            }

            return w;
        }

        private void ComboBoxWaterMark_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            System.Drawing.StringFormat sf = new System.Drawing.StringFormat();
            sf.LineAlignment = System.Drawing.StringAlignment.Center;
            sf.Alignment = System.Drawing.StringAlignment.Center;
            
            System.Drawing.Brush brush = new System.Drawing.SolidBrush(ForeColor);
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                brush = System.Drawing.SystemBrushes.HighlightText;
            }

            e.Graphics.DrawString(Items[e.Index].ToString(), Font, brush, e.Bounds, sf);

            e.DrawFocusRectangle();
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
