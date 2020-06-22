using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace CollegeBreaker
{
    static class ControlHandler
    {
        static readonly PrivateFontCollection pfc = new PrivateFontCollection();

        static ControlHandler()
        {
            pfc.AddFontFile("PressStart2P.ttf");
        }

        public static void VerticalAlign(Control control, int height)
        {
            control.Location = new Point(control.Location.X, height / 2 + control.Height / 2 - control.Font.Height);
        }

        public static void ControlAlign(Control control, int fontSize, int verticalPosition)
        {
            if (control is Button)
            {
                ((Button)control).UseCompatibleTextRendering = true;
                ((Button)control).TextAlign = ContentAlignment.MiddleCenter;
            }

            SetFont(control, fontSize);

            control.Location = new Point(control.FindForm().Width / 2 - control.Width / 2, verticalPosition);
        }

        public static void SetFont(Control control, int fontSize)
        {
            control.Font = new Font(pfc.Families[0], fontSize, FontStyle.Regular);
        }
    }
}
