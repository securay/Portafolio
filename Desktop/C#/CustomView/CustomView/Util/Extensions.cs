using System.Collections.Generic;
using System.Windows.Forms;

namespace Util
{
    public static class Extensions
    {
        public static GUI.CustomControls.ComboBoxWaterMark FillComboBox<T>(this GUI.CustomControls.ComboBoxWaterMark ComboBox, IEnumerable<T> Items)
        {
            object selected = ComboBox.SelectedItem;

            ComboBox.Items.Clear();
            ComboBox.Items.Add(ComboBox.WaterMarkText);

            foreach (T Item in Items)
                ComboBox.Items.Add(Item);

            ComboBox.SelectedItem = selected;
            return ComboBox;
        }
    }
}
