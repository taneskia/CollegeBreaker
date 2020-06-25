using System;
using System.Drawing;
using System.Windows.Forms;

namespace CollegeBreaker
{
    public partial class ToolsForm : Form, IObserver<GameInfo>
    {
        // TODO: Ako se korista OpenForms, chuvaj instanca, ne baraj celo vreme

        public static int width;
        private bool pause;

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

            Game.GetInstance().Subscribe(this);
        }

        private void ButtonPause_Click(object sender, EventArgs e)
        {
            pause = !pause;

            if (ButtonPause.Text == "Next")
            {
                Game.GetInstance().NextLevel();
                ButtonPause.Text = "Pause";
            }

            else ButtonPause.Text = pause ? "Play" : "Pause";

            Game.GetInstance().Pause(pause);
        }

        private void ButtonRetry_Click(object sender, EventArgs e)
        {
            ButtonPause.Enabled = ButtonPause.Visible = true;
            Game.GetInstance().RetryLevel();
            if (pause)
            {
                pause = false;
                ButtonPause.Text = "Pause";
            }
        }

        public void OnNext(GameInfo info)
        {
            //pause and retry buttons diabled
            if (info.State == Game.State.GameBeat)
            {
                ButtonPause.Enabled = ButtonRetry.Enabled = false;
            }

            // pause button disabled
            if (info.State == Game.State.GameLost || info.State == Game.State.LevelLost)
            {
                ButtonPause.Enabled = ButtonPause.Visible = false;
            }

            // all buttons enabled
            if (info.State == Game.State.Running)
            {
                ButtonPause.Enabled = ButtonRetry.Enabled = true;

                if (!pause)
                    LabelTime.Text = TimeSpan.FromSeconds(info.LevelTime).ToString("mm\\:ss");
            }

            if (info.State == Game.State.LevelBeat)
            {
                ButtonPause.Text = "Next";
                ButtonPause.Enabled = ButtonRetry.Enabled = pause = true;
            }
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }
    }
}
