using System.Collections.Generic;
using System.Windows.Forms;

namespace Util
{
    public static class Extensions
    {
        public static ComboBox FillComboBox<T>(this ComboBox ComboBox, IEnumerable<T> Items)
        {
            object selected = ComboBox.SelectedItem;

            ComboBox.Items.Clear();
            foreach (T Item in Items)
                ComboBox.Items.Add(Item);

            ComboBox.SelectedItem = selected;
            return ComboBox;
        }
    }
}
