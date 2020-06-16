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

            ControlHandler.ControlAlign(LabelPlayerName, 13);
            ControlHandler.GroupAlign(new System.Collections.Generic.List<Control>() { TextboxName, ButtonChoose }, 10);
        }

        private void ButtonChoose_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PlayerName = TextboxName.Text;
            Properties.Settings.Default.Save();
            Close();
        }
    }
}
