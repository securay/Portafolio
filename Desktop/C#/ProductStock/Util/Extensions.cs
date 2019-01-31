using System.Collections.Generic;
using System.Windows.Forms;

namespace Util
{
    public static class Extensions
    {
        public static ComboBox FillComboBox<T>(this ComboBox cbo, IEnumerable<T> data)
        {
            object selected = cbo.SelectedItem;

            cbo.Items.Clear();
            foreach (T e in data)
                cbo.Items.Add(e);

            cbo.SelectedItem = selected;
            return cbo;
        }
    }
}
