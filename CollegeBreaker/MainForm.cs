using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CollegeBreaker.Properties;

namespace CollegeBreaker
{
    public partial class MainForm : Form
    {
        public GameForm gameForm = new GameForm();
        ScoreForm scoreForm = new ScoreForm();
        ToolsForm toolsForm = new ToolsForm();

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
            ControlHandler.ControlAlign(LabelTitle);
            ControlHandler.ControlAlign(LabelScoreboard, 13);
            ControlHandler.GroupAlign(new List<Control>() { LabelTop1, LabelTop2, LabelTop3 }, 10, "Right");
            ControlHandler.GroupAlign(new List<Control>() { ButtonExit, ButtonPlay }, 14);
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            if (Settings.Default.PlayerName == string.Empty) 
                new PlayerName().ShowDialog();

            Hide();

            gameForm.Show();
            scoreForm.Show();
            toolsForm.Show();

            gameForm.game.SetScoreForm(scoreForm);

            scoreForm.ShowInTaskbar = false;
            scoreForm.Location = new Point(gameForm.Location.X, gameForm.Location.Y - scoreForm.Height - 10);

            toolsForm.ShowInTaskbar = false;
            toolsForm.Location = new Point(gameForm.Location.X + gameForm.Width + 10, gameForm.Location.Y - scoreForm.Height - 10);

            scoreForm.LocationChanged += new EventHandler(MoveAllHandler);

            gameForm.Focus();
        }

        private void MoveAllHandler(object sender, EventArgs e)
        {
            gameForm.Location = new Point(scoreForm.Location.X, scoreForm.Location.Y + scoreForm.Height + 10);
            toolsForm.Location = new Point(gameForm.Location.X + gameForm.Width + 10, scoreForm.Location.Y);
        }
    }
}
