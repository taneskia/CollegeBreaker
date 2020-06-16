using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_VP
{
    static class WindowHandler
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public static void Drag(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage((sender as Panel).FindForm().Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public static void Minimize(object sender, EventArgs e)
        {
            (sender as Button).FindForm().WindowState = FormWindowState.Minimized;
        }

        public static void Maximize(object sender, EventArgs e)
        {
            (sender as Button).FindForm().WindowState = (sender as Button).FindForm().WindowState.Equals(FormWindowState.Normal) ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        public static void Close(object sender, EventArgs e)
        {
            (sender as Button).FindForm().Close();
        }

        public static void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
