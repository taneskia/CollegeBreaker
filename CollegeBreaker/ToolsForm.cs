using System;
using System.Drawing;
using System.Windows.Forms;

namespace CollegeBreaker
{
    public partial class ToolsForm : Form
    {
        public static int width;
        private bool pause;
        private int seconds;

        public ToolsForm()
        {
            InitializeComponent();

            Width = width = 200;
            Height = 615;

            pause = false;

            ButtonExit.MouseEnter += new EventHandler(ImageHandler.MouseEnter);
            ButtonExit.MouseLeave += new EventHandler(ImageHandler.MouseLeave);

            ButtonPause.MouseEnter += new EventHandler(ImageHandler.MouseEnter);
            ButtonPause.MouseLeave += new EventHandler(ImageHandler.MouseLeave);

            ButtonRetry.MouseEnter += new EventHandler(ImageHandler.MouseEnter);
            ButtonRetry.MouseLeave += new EventHandler(ImageHandler.MouseLeave);

            ButtonExit.Click += new EventHandler(WindowHandler.Exit);

            ButtonExit.Size = new Size(Width - 30, ButtonExit.Height);
            ButtonPause.Size = new Size(Width - 30, ButtonPause.Height);
            ButtonRetry.Size = new Size(Width - 30, ButtonRetry.Height);

            ControlHandler.ControlAlign(ButtonPause, 14, Height - ButtonPause.Height - ButtonRetry.Height - ButtonExit.Height - 42);
            ControlHandler.ControlAlign(ButtonRetry, 14, Height - ButtonPause.Height - ButtonExit.Height - 28);
            ControlHandler.ControlAlign(ButtonExit, 14, Height - ButtonExit.Height - 14);
            ControlHandler.ControlAlign(LabelTime, 15, 40);

            TimerCount.Start();
        }

        private void SetSeconds()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(GameForm))
                {
                    seconds = (form as GameForm).game.levels.LevelTime;
                }
            }
        }

        private void ButtonPause_Click(object sender, EventArgs e)
        {
            pause = !pause;

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(GameForm))
                {
                    (form as GameForm).PanelPaused.Visible = pause;

                    if (pause)
                    {
                        (form as GameForm).TimerFPS.Stop();
                        TimerCount.Stop();
                        ButtonPause.Text = "Play";
                    }

                    else
                    {
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
            LabelTime.Text = TimeSpan.FromSeconds(--seconds).ToString("mm\\:ss");
        }

        private void ButtonRetry_Click(object sender, EventArgs e)
        {
            ButtonPause.Enabled = ButtonPause.Visible = true;
            SetSeconds();
            LabelTime.Text = TimeSpan.FromSeconds(seconds).ToString("mm\\:ss");

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(GameForm))
                {
                    (form as GameForm).PanelPaused.Visible = false;
                    (form as GameForm).game.RetryLevel();
                    (form as GameForm).TimerFPS.Start();
                    (form as GameForm).Focus();
                    TimerCount.Start();
                }
            }
        }

        private void ToolsForm_Load(object sender, EventArgs e)
        {
            SetSeconds();
        }
    }
}
