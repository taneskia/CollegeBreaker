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

        public static void ControlAlign(Control control, int fontSize = 28, string position = "Center")
        {
            if (control is Button)
            {
                ((Button)control).UseCompatibleTextRendering = true;
                ((Button)control).TextAlign = ContentAlignment.MiddleCenter;
            }

            SetFont(control, fontSize);

            switch(position)
            {
                case "Right":
                    control.Location = new Point(control.FindForm().Width - control.Width, control.Location.Y);
                    break;
                case "Left":
                    control.Location = new Point(10, control.Location.Y);
                    break;
                default:
                    control.Location = new Point(control.FindForm().Width / 2 - control.Width / 2, control.Location.Y);
                    break;
            }                
        }
        public static void SetFont(Control control, int fontSize)
        {
            control.Font = new Font(pfc.Families[0], fontSize, FontStyle.Regular);
        }

        public static void GroupAlign(List<Control> controlList, int fontSize = 28, string position = "Center")
        {
            Control largest = controlList.First();
            int max = controlList.First().Width;

            foreach (Control control in controlList)
            {
                if (control.Width > max)
                {
                    max = control.Width;
                    largest = control;
                }
            }

            ControlAlign(largest, fontSize, position);

            switch(position)
            {
                case "Right":
                    foreach (Control control in controlList)
                    {
                        SetFont(control, fontSize);
                        control.Location = new Point(largest.Location.X + largest.Width - control.FindForm().Width / 3 - control.Width, control.Location.Y);
                    }
                    break;
                case "Left":
                    foreach (Control control in controlList)
                    {
                        SetFont(control, fontSize);
                        control.Location = new Point((int)(largest.Location.X + 1.5 * largest.Width - control.FindForm().Width / 3), control.Location.Y);
                    }
                    break;
                default:
                    foreach (Control control in controlList)
                        ControlAlign(control, fontSize);
                    break;
            }
        }
    }
}
