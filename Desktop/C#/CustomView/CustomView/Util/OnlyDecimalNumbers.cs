using System;
using System.Windows.Forms;

namespace Util
{
    public static class OnlyDecimalNumbers
    {
        public static void OnlyDecimalNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if(e.KeyChar.Equals('.') && !((TextBox)sender).Text.Contains("."))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        } 
    }
}
