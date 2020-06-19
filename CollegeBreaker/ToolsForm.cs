using System;
using System.Drawing;
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

            Width = 200;
            Height = 615;

            width = Width;
            pause = false;

            ButtonExit.MouseEnter += new EventHandler(ImageHandler.MouseEnter);
            ButtonExit.MouseLeave += new EventHandler(ImageHandler.MouseLeave);

            ButtonPause.MouseEnter += new EventHandler(ImageHandler.MouseEnter);
            ButtonPause.MouseLeave += new EventHandler(ImageHandler.MouseLeave);

            ButtonRetry.MouseEnter += new EventHandler(ImageHandler.MouseEnter);
            ButtonRetry.MouseLeave += new EventHandler(ImageHandler.MouseLeave);

            ButtonExit.Click += new EventHandler(WindowHandler.Exit);

            ButtonExit.Size = new Size(Width - 31, ButtonExit.Height);
            ButtonPause.Size = new Size(Width - 31, ButtonPause.Height);
            ButtonRetry.Size = new Size(Width - 31, ButtonRetry.Height);

            ControlHandler.ControlAlign(ButtonRetry, 14, "Center", Height - ButtonRetry.Height - ButtonPause.Height - ButtonExit.Height - 42);
            ControlHandler.ControlAlign(ButtonPause, 14, "Center", Height - ButtonPause.Height - ButtonExit.Height - 28);
            ControlHandler.ControlAlign(ButtonExit, 14, "Center", Height - ButtonExit.Height - 14);
            ControlHandler.ControlAlign(LabelTime, 15, "Center", 40);

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
