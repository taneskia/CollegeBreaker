using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeBreaker
{
    public partial class GameForm : Form
    {
        private Game game;
        public GameForm()
        {
            InitializeComponent();
            game = new Game();
            game.NextLevel();
            timer1.Start();
        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            game.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
