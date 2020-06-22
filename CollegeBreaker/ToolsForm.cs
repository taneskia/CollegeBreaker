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
        private int seconds;

        public GameForm gameForm;
        public MainForm mainForm;

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

            Game.GetInstance().Subscribe(this);
        }

        private void SetGameForm()
        {
            foreach (Form form in Application.OpenForms)
                if(form.GetType() == typeof(MainForm))
                {
                    mainForm = form as MainForm;
                    gameForm = mainForm.gameForm;
                }
        }

        private void SetSeconds()
        {
            seconds = gameForm.game.levels.LevelTime;
        }

        private void ButtonPause_Click(object sender, EventArgs e)
        {
            pause = !pause;

            gameForm.PanelPaused.Visible = pause;

            if (pause)
            {
                gameForm.TimerFPS.Stop();
                TimerCount.Stop();
                ButtonPause.Text = "Play";
            }

            else
            {
                gameForm.TimerFPS.Start();
                gameForm.Focus();
                TimerCount.Start();
                ButtonPause.Text = "Pause";
                mainForm.scoreForm.SetSemester(gameForm.game.levels.PointsFromLevels.Count);
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
            gameForm.PanelPaused.Visible = false;
            gameForm.game.RetryLevel();
            gameForm.TimerFPS.Start();
            gameForm.Focus();
            TimerCount.Start();
        }

        private void ToolsForm_Load(object sender, EventArgs e)
        {
            SetGameForm();
            SetSeconds();
        }

        public void OnNext(GameInfo info)
        {
            //pause and retry buttons diabled
            if (info.State == Game.State.GameBeat) 
            {
                ButtonPause.Enabled = false;
                ButtonRetry.Enabled = false;
            }

            // pause button disabled
            if (info.State == Game.State.GameLost || info.State == Game.State.LevelLost) 
            {
                ButtonPause.Enabled = false;
            }

            // all buttons enabled
            if (info.State == Game.State.Running) 
            {
                ButtonPause.Enabled = true;
                ButtonRetry.Enabled = true;
            }

            if (info.State == Game.State.LevelBeat)
            {
                ButtonPause.Text = "Next";
                ButtonPause.Enabled = true;
                ButtonRetry.Enabled = true;
                pause = true;
                gameForm.game.NextLevel();
                SetSeconds();
                LabelTime.Text = TimeSpan.FromSeconds(seconds).ToString("mm\\:ss");
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
