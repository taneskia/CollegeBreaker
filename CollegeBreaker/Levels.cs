using CollegeBreaker.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CollegeBreaker
{
    public class Levels : IObservable<List<List<int>>>
    {
        private readonly List<IObserver<List<List<int>>>> observers;
        public int CurrentLevelNumber { get; set; }
        public List<List<int>> PointsFromLevels { get; set; }
        public int BrickCount { get; set; }
        public Image[][] Bricks;
        private readonly Random random;
        public Timer LevelTimer { get; set; }
        public int LevelTime { get; set; }

        public Levels()
        {
            observers = new List<IObserver<List<List<int>>>>();
            CurrentLevelNumber = 0;
            PointsFromLevels = new List<List<int>>();
            BrickCount = 20;

            Bricks = new Image[5][];

            for (int i = 0; i < Bricks.Length; i++)
                Bricks[i] = new Image[4];

            random = new Random();

            LevelTimer = new Timer
            {
                Interval = 1000
            };

            LevelTimer.Tick += new EventHandler(TimerTick);
        }

        private int GetLevelTime()
        {
            return 90 - ((CurrentLevelNumber - 1) * 10);
        }

        public float GetMeanGrade()
        {
            int count = 0;
            float sum = 0;

            foreach (List<int> levelPoints in PointsFromLevels)
            {
                foreach (int pts in levelPoints)
                {
                    sum += pts;
                    count++;
                }
            }

            if (count != 0)
                return sum / count;
            return 0;
        }

        private void SetLevelTime()
        {
            LevelTime = GetLevelTime();
            LevelTimer.Stop();
            LevelTimer.Start();
        }

        public void NextLevel()
        {
            PointsFromLevels.Add(new List<int>());
            GenerateLevel(++CurrentLevelNumber);

            BrickCount = 20;

            SetLevelTime();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            LevelTime--;
            foreach (IObserver<List<List<int>>> o in observers)
                o.OnNext(PointsFromLevels);
        }

        public void RetryLevel()
        {
            PointsFromLevels[CurrentLevelNumber - 1] = new List<int>();
            GenerateLevel(CurrentLevelNumber);
            SetLevelTime();
        }

        private void GenerateLevel(int level)
        {
            for (int i = 0; i < Bricks.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int failBrickProbability = random.Next(0, 10);
                    int randomBrick = random.Next(6, 11);

                    if (failBrickProbability == 0)
                    {
                        Bricks[i][j] = Resources.FailBrick;
                        Bricks[i][j].Tag = -2;
                    }
                    else
                    {
                        switch (randomBrick)
                        {
                            case 6:
                                Bricks[i][j] = Resources._6_Brick;
                                Bricks[i][j].Tag = 6;
                                break;
                            case 7:
                                Bricks[i][j] = Resources._7_Brick;
                                Bricks[i][j].Tag = 7;
                                break;
                            case 8:
                                Bricks[i][j] = Resources._8_Brick;
                                Bricks[i][j].Tag = 8;
                                break;
                            case 9:
                                Bricks[i][j] = Resources._9_Brick;
                                Bricks[i][j].Tag = 9;
                                break;
                            case 10:
                                Bricks[i][j] = Resources._10_Brick;
                                Bricks[i][j].Tag = 10;
                                break;
                        }
                    }
                }
            }
        }

        public void Draw(Graphics graphics)
        {
            int brickCount = 0;
            for (int i = 0; i < Bricks.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Bricks[i][j] != null)
                    {
                        brickCount++;
                        graphics.DrawImageUnscaled(Bricks[i][j], 50 + 106 * i, 45 + 51 * j);
                    }
                }
            }

            BrickCount = brickCount;
            if (BrickCount == 0)
                foreach (IObserver<List<List<int>>> o in observers)
                    o.OnNext(PointsFromLevels);
        }

        public void CheckCollisionWithBall(Ball ball)
        {
            bool once = true;
            for (int i = 0; i < Bricks.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Bricks[i][j] != null)
                    {
                        if (DoOverlap(new Point(50 + 106 * i, 45 + 51 * j), ball, once))
                        {
                            PointsFromLevels[CurrentLevelNumber - 1].Add(Convert.ToInt32(Bricks[i][j].Tag));
                            Bricks[i][j] = null;
                            once = false;
                            foreach (IObserver<List<List<int>>> o in observers)
                                o.OnNext(PointsFromLevels);
                        }
                    }
                }
            }
        }

        private bool DoOverlap(Point brick, Ball ball, bool once)
        {
            List<Point> radiusPoints = new List<Point>();
            for (double angle = 0.0; angle < 2.0 * Math.PI; angle += (Math.PI / 180) * 45)
            {
                radiusPoints.Add(new Point(ball.BallPosition.X + 17 + (int)(17 * Math.Cos(angle)), ball.BallPosition.Y + 17 + (int)(17 * Math.Sin(angle))));
            }

            for (int i = 0; i < radiusPoints.Count; i++)
            {
                if (radiusPoints[i].X >= brick.X && radiusPoints[i].X <= brick.X + 100)
                {
                    if (radiusPoints[i].Y >= brick.Y && radiusPoints[i].Y <= brick.Y + 45)
                    {
                        if (once)
                        {
                            if (i == 0)
                            {
                                ball.MoveBall(Ball.BrickCollision.Right);
                            }

                            if (i == 6 || i == 5 || i == 7)
                            {
                                ball.MoveBall(Ball.BrickCollision.Top);
                            }

                            if (i == 4)
                            {
                                ball.MoveBall(Ball.BrickCollision.Left);
                            }

                            if (i == 2 || i == 3 || i == 1)
                            {
                                ball.MoveBall(Ball.BrickCollision.Bottom);
                            }
                        }

                        return true;
                    }
                }
            }
            return false;
        }

        public IDisposable Subscribe(IObserver<List<List<int>>> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
                // Provide observer with existing data.
                observer.OnNext(PointsFromLevels);
            }
            return new Unsubscriber<List<List<int>>>(observers, observer);
        }

        private class Unsubscriber<T> : IDisposable
        {
            private readonly List<IObserver<List<List<int>>>> _observers;
            private readonly IObserver<List<List<int>>> _observer;

            public Unsubscriber(List<IObserver<List<List<int>>>> observers, IObserver<List<List<int>>> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (_observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }
    }
}
