using System;
using System.Drawing;
using System.Windows.Forms;

namespace CollegeBreaker
{
    public partial class MainForm : Form
    {
        public GameForm gameForm = new GameForm();
        public ScoreForm scoreForm = new ScoreForm();
        public ToolsForm toolsForm = new ToolsForm();

        public MainForm()
        {
            InitializeComponent();

            LabelTitle.Text = "College\nBreaker";

            ButtonExit.Click += new EventHandler(WindowHandler.Exit);
            PanelMain.MouseMove += new MouseEventHandler(WindowHandler.Drag);

            ButtonExit.MouseEnter += new EventHandler(ImageHandler.MouseEnter);
            ButtonExit.MouseLeave += new EventHandler(ImageHandler.MouseLeave);

            ButtonPlay.MouseEnter += new EventHandler(ImageHandler.MouseEnter);
            ButtonPlay.MouseLeave += new EventHandler(ImageHandler.MouseLeave);

            SetControls();
        }

        private void SetControls()
        {
            ControlHandler.ControlAlign(LabelTitle, 28, 50);
            ControlHandler.ControlAlign(LabelScoreboard, 13, Height / 2 - 50);
            ControlHandler.ControlAlign(LabelTop1, 10, Height / 2 - 10);
            ControlHandler.ControlAlign(LabelTop2, 10, Height / 2 + LabelTop1.Height);
            ControlHandler.ControlAlign(LabelTop3, 10, Height / 2 + LabelTop1.Height + LabelTop2.Height + 10);
            ControlHandler.ControlAlign(ButtonExit, 14, Height - 40 - ButtonExit.Height);
            ControlHandler.ControlAlign(ButtonPlay, 14, Height - 60 - 2 * ButtonExit.Height);
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.PlayerName == string.Empty)
                new PlayerName().ShowDialog();

            Hide();

            gameForm.Show();
            scoreForm.Show();
            toolsForm.Show();

            scoreForm.ShowInTaskbar = false;
            scoreForm.Location = new Point(gameForm.Location.X, gameForm.Location.Y - scoreForm.Height - 10);
            scoreForm.LocationChanged += new EventHandler(MoveAllHandler);

            toolsForm.ShowInTaskbar = false;
            toolsForm.Location = new Point(gameForm.Location.X + gameForm.Width + 10, gameForm.Location.Y - scoreForm.Height - 10);

            gameForm.Focus();

            gameForm.game.levels.SetScoreForm(scoreForm);
        }

        public void DisablePauseButton()
        {
            toolsForm.ButtonPause.Enabled = toolsForm.ButtonPause.Visible = false;
        }

        private void MoveAllHandler(object sender, EventArgs e)
        {
            gameForm.Location = new Point(scoreForm.Location.X, scoreForm.Location.Y + scoreForm.Height + 10);
            toolsForm.Location = new Point(gameForm.Location.X + gameForm.Width + 10, scoreForm.Location.Y);
        }
    }
}
