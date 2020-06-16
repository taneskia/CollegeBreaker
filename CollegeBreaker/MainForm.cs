using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Chat_VP;
using CollegeBreaker.Properties;

namespace CollegeBreaker
{
    public partial class MainForm : Form
    {
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
            if (Settings.Default.PlayerName == string.Empty) new PlayerName().ShowDialog();

            Hide();
            new GameForm().ShowDialog();
            Close();
        }
    }
}
