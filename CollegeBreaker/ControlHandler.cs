using CollegeBreaker.Properties;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace CollegeBreaker
{
    static class ControlHandler
    {
        static PrivateFontCollection pfc = new PrivateFontCollection();

        static ControlHandler()
        {
            pfc.AddFontFile("PressStart2P.ttf");
        }

        public static void VerticalAlign(Control control, Panel panel)
        {
            control.Location = new Point(control.Location.X, panel.Height / 2 - control.Font.Height / 2);
        }

        public static void ControlAlign(Control control, int fontSize, string horizontalPosition, int verticalPosition)
        {
            if (control is Button)
            {
                ((Button)control).UseCompatibleTextRendering = true;
                ((Button)control).TextAlign = ContentAlignment.MiddleCenter;
            }

            SetFont(control, fontSize);

            switch(horizontalPosition)
            {
                case "Right":
                    control.Location = new Point(control.FindForm().Width - control.Width, verticalPosition);
                    break;
                case "Left":
                    control.Location = new Point(10, verticalPosition);
                    break;
                default:
                    control.Location = new Point(control.FindForm().Width / 2 - control.Width / 2, verticalPosition);
                    break;
            }                
        }

        public static void SetFont(Control control, int fontSize)
        {
            control.Font = new Font(pfc.Families[0], fontSize, FontStyle.Regular);
        }
    }
}
