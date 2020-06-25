using System;
using System.Drawing;
using System.Windows.Forms;

namespace CollegeBreaker
{
    public partial class GameForm : Form, IObserver<GameInfo>
    {
        public Game game;
        public bool left;
        public bool move = false;

        public GameForm()
        {
            InitializeComponent();

            Width = 624;
            Height = 550;

            game = Game.GetInstance();
            game.Subscribe(this);
            game.levels.NextLevel();

            TimerFPS.Start();

            ControlHandler.ControlAlign(LabelPaused, 28, Height / 2 - 14);
            ControlHandler.VerticalAlign(LabelPaused, Height);
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            ControlHandler.ControlAlign(PanelPaused, 28, Height / 2 - 14);
            Location = new Point(Screen.FromControl(this).Bounds.Width / 2 - Width / 2 - ToolsForm.width / 2 - 10, Screen.FromControl(this).Bounds.Height / 2 - Height / 2 + ScoreForm.height / 2 + 10);
        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            game.Advance();
            game.Draw(e.Graphics);
            e.Graphics.DrawRectangle(new Pen(Color.Black, 4), ClientRectangle);
        }

        private void TimerFPS_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void TimerPlayerMove_Tick(object sender, EventArgs e)
        {
            Movement();
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Left && e.KeyCode != Keys.Right)
            {
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Left)
            {
                left = true;
                move = true;
            }

            else if (e.KeyCode == Keys.Right)
            {
                left = false;
                move = true;
            }

            if (move)
            {
                TimerPlayerMove.Start();
            }
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Left && e.KeyCode != Keys.Right)
            {
                e.Handled = true;
                return;
            }

            TimerPlayerMove.Stop();
            move = false;
        }

        public void Movement()
        {
            if (left && move)
                game.movables.platform.MovePlatformLeft();

            else if (!left && move)
                game.movables.platform.MovePlatformRight();
        }

        public void SetEndScreen(string text, int fontSize)
        {
            using (Graphics g = CreateGraphics())
            {
                SizeF size = g.MeasureString(text, ControlHandler.GetFont(fontSize), LabelPaused.Width);
                LabelPaused.Height = (int)Math.Ceiling(size.Height);
                LabelPaused.Text = text;
            }

            ControlHandler.ControlAlign(LabelPaused, fontSize, Height / 2 - LabelPaused.Height / 2);
        }

        public void PauseGame(bool pause)
        {
            SetEndScreen("Paused!", 24);

            if (pause)
            {
                TimerFPS.Stop();
                TimerPlayerMove.Stop();
                PanelPaused.Visible = true;
            }
            else
            {
                TimerFPS.Start();
                TimerPlayerMove.Start();
                PanelPaused.Visible = false;
            }
        }

        public void OnNext(GameInfo info)
        {
            if(info.State == Game.State.Paused)
            {
                PauseGame(true);
            }

            if (info.State == Game.State.GameBeat)
            {
                TimerFPS.Stop();
                SetEndScreen("Congratulations!\nYou've graduated!", 20);
                PanelPaused.Visible = true;
            }

            if (info.State == Game.State.LevelLost)
            {
                TimerFPS.Stop();
                SetEndScreen("Failed!", 24);
                PanelPaused.Visible = true;
            }

            if (info.State == Game.State.LevelBeat)
            {
                TimerFPS.Stop();
                SetEndScreen("Semester\nPassed!", 24);
                PanelPaused.Visible = true;
            }

            if (info.State == Game.State.Running)
            {
                Focus();
                PauseGame(false);
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
