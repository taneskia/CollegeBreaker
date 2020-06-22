using System.Windows.Forms;

namespace CollegeBreaker
{
    public partial class ScoreForm : Form
    {
        public static int height;
        private float currentGrade = 0;
        private float meanGrade = 0f;

        public ScoreForm()
        {
            InitializeComponent();

            Width = 624;
            Height = height = 55;

            PanelMain.MouseMove += new MouseEventHandler(WindowHandler.Drag);
            LabelMeanGrade.MouseMove += new MouseEventHandler(WindowHandler.Drag);
            LabelSemester.MouseMove += new MouseEventHandler(WindowHandler.Drag);

            ControlHandler.SetFont(LabelMeanGrade, 10);
            ControlHandler.SetFont(LabelSemester, 10);

            ControlHandler.VerticalAlign(LabelMeanGrade, PanelMain);
            ControlHandler.VerticalAlign(LabelSemester, PanelMain);

            LabelMeanGrade.Location = new System.Drawing.Point(Location.X + Height / 3, LabelMeanGrade.Location.Y);
            LabelSemester.Location = new System.Drawing.Point(Location.X + Width - LabelSemester.Width - Height / 2, LabelSemester.Location.Y);
        }

        private float CalculateMeanGrade()
        {
            meanGrade += currentGrade / 20;
            return meanGrade;
        }

        public void AddPoints(int points)
        {
            currentGrade += points;
            LabelMeanGrade.Text = "Mean Grade: " + CalculateMeanGrade();
        }

        public void SetSemester(int semester)
        {
            LabelSemester.Text = "Semester: " + semester;
        }

        public void ClearLevelGrades()
        {
            currentGrade = 0;
        }
    }
}
