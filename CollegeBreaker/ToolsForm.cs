using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeBreaker
{
    public partial class ToolsForm : Form
    {
        public static int width;
        private bool pause;
        private int seconds = 0;
        public ToolsForm()
        {
            InitializeComponent();

            width = Width;
            pause = false;

            ButtonExit.MouseEnter += new EventHandler(ImageHandler.MouseEnter);
            ButtonExit.MouseLeave += new EventHandler(ImageHandler.MouseLeave);

            ButtonPause.MouseEnter += new EventHandler(ImageHandler.MouseEnter);
            ButtonPause.MouseLeave += new EventHandler(ImageHandler.MouseLeave);

            ButtonExit.Click += new EventHandler(WindowHandler.Exit);

            ControlHandler.ControlAlign(ButtonExit, 14);
            ControlHandler.ControlAlign(ButtonPause, 14);
            ControlHandler.ControlAlign(LabelTime, 20);

            TimerCount.Start();
        }

        private void ButtonPause_Click(object sender, EventArgs e)
        {
            pause = !pause;
            foreach (Form form in Application.OpenForms)
            {
                if(form.GetType() == typeof(GameForm))
                {
                    if (pause)
                    {
                        (form as GameForm).PanelPaused.Visible = true;
                        (form as GameForm).TimerFPS.Stop();
                        TimerCount.Stop();
                        ButtonPause.Text = "Play";
                    }
                    else
                    {
                        (form as GameForm).PanelPaused.Visible = false;
                        (form as GameForm).TimerFPS.Start();
                        (form as GameForm).Focus();
                        TimerCount.Start();
                        ButtonPause.Text = "Pause";
                    }
                    break;
                }
            }
        }

        private void TimerCount_Tick(object sender, EventArgs e)
        {
            seconds++;
            LabelTime.Text = TimeSpan.FromSeconds(seconds).ToString("mm\\:ss");
        }
    }
}
