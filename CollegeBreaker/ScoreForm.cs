using System.Windows.Forms;

namespace CollegeBreaker
{
    public partial class ScoreForm : Form
    {
        public static int height;
        private int fontSize = 10;
        private int totalScore = 0;
        private int score = 0;

        public ScoreForm()
        {
            InitializeComponent();

            Width = 624;
            Height = height = 55;

            PanelMain.MouseMove += new MouseEventHandler(WindowHandler.Drag);
            LabelTotalScoreText.MouseMove += new MouseEventHandler(WindowHandler.Drag);
            LabelTotalScoreValue.MouseMove += new MouseEventHandler(WindowHandler.Drag);
            LabelScoreText.MouseMove += new MouseEventHandler(WindowHandler.Drag);
            LabelScoreValue.MouseMove += new MouseEventHandler(WindowHandler.Drag);

            ControlHandler.SetFont(LabelTotalScoreText, fontSize);
            ControlHandler.SetFont(LabelTotalScoreValue, fontSize);
            ControlHandler.SetFont(LabelScoreText, fontSize);
            ControlHandler.SetFont(LabelScoreValue, fontSize);

            ControlHandler.VerticalAlign(LabelTotalScoreText, PanelMain);
            ControlHandler.VerticalAlign(LabelTotalScoreValue, PanelMain);
            ControlHandler.VerticalAlign(LabelScoreText, PanelMain);
            ControlHandler.VerticalAlign(LabelScoreValue, PanelMain);
        }

        public void AddPoints(int score)
        {
            this.score += score;
            totalScore += score;
            LabelTotalScoreValue.Text = totalScore.ToString();
            LabelScoreValue.Text = this.score.ToString();
        }

        public void ClearLevelScore()
        {
            score = 0;
        }
    }
}
