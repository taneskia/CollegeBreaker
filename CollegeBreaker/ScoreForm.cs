using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CollegeBreaker
{
    public partial class ScoreForm : Form, IObserver<GameInfo>
    {
        public static int height;

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

            ControlHandler.VerticalAlign(LabelMeanGrade, Height);
            ControlHandler.VerticalAlign(LabelSemester, Height);

            LabelMeanGrade.Location = new System.Drawing.Point(Location.X + Height / 3, LabelMeanGrade.Location.Y);
            LabelSemester.Location = new System.Drawing.Point(Location.X + Width - LabelSemester.Width - Height / 2, LabelSemester.Location.Y);

            Game.GetInstance().Subscribe(this);
        }

        public void ShowMeanGrade(List<List<int>> points)
        {
            int count = 0;
            float sum = 0;

            foreach (List<int> levelPoints in points)
            {
                foreach (int pts in levelPoints)
                {
                    sum += pts;
                    count++;
                }
            }

            if (count != 0)
                LabelMeanGrade.Text = "Mean Grade: " + String.Format("{0:0.00}", sum / count);
            else LabelMeanGrade.Text = "Mean Grade: NaN";
        }

        public void SetSemester(int semester)
        {
            LabelSemester.Text = "Semester: " + semester;
        }

        public void OnNext(GameInfo info)
        {
            LabelMeanGrade.Text = "Mean Grade: " + String.Format("{0:0.00}", 0);
            ShowMeanGrade(info.PointsFromLevels);
            SetSemester(info.PointsFromLevels.Count);
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
