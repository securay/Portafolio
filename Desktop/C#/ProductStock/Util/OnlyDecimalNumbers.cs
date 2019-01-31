using System.Windows.Forms;

namespace Util
{
    public static class OnlyDecimalNumbers
    {
        public static void OnlyDecimalNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
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
