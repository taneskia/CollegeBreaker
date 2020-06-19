using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CollegeBreaker
{
    public partial class PlayerName : Form
    {
        public PlayerName()
        {
            InitializeComponent();

            ButtonChoose.MouseEnter += new EventHandler(ImageHandler.MouseEnter);
            ButtonChoose.MouseLeave += new EventHandler(ImageHandler.MouseLeave);

            ControlHandler.ControlAlign(LabelPlayerName, 13, "Center", Height / 2 - 6);
            ControlHandler.ControlAlign(TextboxName, 10, "Center", Height / 2 - 5);
            ControlHandler.ControlAlign(ButtonChoose, 10, "Center", Height / 2 - 15 + TextboxName.Height);
        }

        private void ButtonChoose_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PlayerName = TextboxName.Text;
            Properties.Settings.Default.Save();
            Close();
        }
    }
}
