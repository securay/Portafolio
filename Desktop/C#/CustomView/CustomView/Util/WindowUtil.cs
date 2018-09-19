using System;
using System.Runtime.InteropServices;

namespace Util
{
    public static class WindowUtil
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public static void AssignMouseDown(IntPtr Handle, System.Windows.Forms.Control Control)
        {
            Control.MouseDown += 
                (object sender, System.Windows.Forms.MouseEventArgs e) =>
                {
                    ReleaseCapture();
                    SendMessage(Handle, 0x112, 0xf012, 0);
                };
        }
    }
}
