using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;

namespace CollegeBreaker
{
    public partial class GameForm : Form
    {
        public Game game;
        public bool left;
        public bool move = false;

        public GameForm()
        {
            InitializeComponent();

            Width = 624;
            Height = 550;

            game = new Game();
            game.NextLevel();

            TimerFPS.Start();

            ControlHandler.ControlAlign(LabelPaused);
            ControlHandler.VerticalAlign(LabelPaused, PanelPaused);
        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            game.Draw(e.Graphics);
            e.Graphics.DrawRectangle(new Pen(Color.Black, 4), ClientRectangle);
        }

        private void TimerFPS_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            ControlHandler.ControlAlign(PanelPaused);
            Location = new Point(Screen.FromControl(this).Bounds.Width / 2 - Width / 2 - ToolsForm.width / 2 - 10, Screen.FromControl(this).Bounds.Height / 2 - Height / 2 + ScoreForm.height / 2 + 10);
        }

        private void TimerPlayerMove_Tick(object sender, EventArgs e)
        {
            Movement();
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Left && e.KeyCode != Keys.Right)
                e.Handled = true;

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
                TimerPlayerMove.Start();
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
            if (move)
            {
                if (left)
                    game.movables.MovePlatformLeft();

                else
                    game.movables.MovePlatformRight();
            }
        }
    }
}
