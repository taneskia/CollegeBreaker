using CollegeBreaker.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace CollegeBreaker
{
    public class Game
    {
        public Movables movables;

        public int Level { get; set; }
        public int[] LevelPoints { get; set; }
        public Image[][] Bricks;

        private Random random;

        private ScoreForm scoreForm;

        public Game()
        {
            movables = new Movables(new Ball(), new Platform());

            Level = 0;

            Bricks = new Image[5][];

            for (int i = 0; i < Bricks.Length; i++)
                Bricks[i] = new Image[4];

            random = new Random();
        }

        public void SetScoreForm(ScoreForm scoreForm)
        {
            this.scoreForm = scoreForm;
        }

        public void NextLevel()
        {
            GenerateLevel(++Level);
        }

        private void GenerateLevel(int level)
        {
            for (int i = 0; i < Bricks.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int randomBrick = random.Next(5, 11);
                    switch (randomBrick)
                    {
                        case 5:
                            Bricks[i][j] = Resources.FailBrick;
                            Bricks[i][j].Tag = -5;
                            break;
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

        public void Draw(Graphics graphics)
        {
            movables.MoveBall(Movables.BrickCollision.None);
            movables.Draw(graphics);
            CheckCollision();
            DrawBricks(graphics);
        }

        public void DrawBricks(Graphics graphics)
        {
            for (int i = 0; i < Bricks.Length; i++)
                for (int j = 0; j < 4; j++)
                    if (Bricks[i][j] != null)
                        graphics.DrawImageUnscaled(Bricks[i][j], 50 + 106 * i, 45 + 51 * j);
        }

        private void CheckCollision()
        {
            bool once = true;
            for (int i = 0; i < Bricks.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Bricks[i][j] != null)
                    {
                        if (DoOverlap(new Point(50 + 106 * i, 45 + 51 * j), movables.ball.BallPosition, once))
                        {
                            scoreForm.AddPoints(Convert.ToInt32(Bricks[i][j].Tag));
                            Bricks[i][j] = null;
                            once = false;
                        }
                    }
                }
            }
        }

        private bool DoOverlap(Point brick, Point ball, bool once)
        {
            List<Point> radiusPoints = new List<Point>();
            for (double angle = 0.0; angle < 2.0 * Math.PI; angle += (Math.PI / 180) * 45)
            {
                radiusPoints.Add(new Point(ball.X + 17 + (int)(17 * Math.Cos(angle)), ball.Y + 17 + (int)(17 * Math.Sin(angle))));
            }

            for (int i = 0; i < radiusPoints.Count; i++)
            {
                if (radiusPoints[i].X >= brick.X && radiusPoints[i].X <= brick.X + 100)
                {
                    if (radiusPoints[i].Y >= brick.Y && radiusPoints[i].Y <= brick.Y + 45)
                    {
                        if (once)
                        {
                            if (i == 0) movables.MoveBall(Movables.BrickCollision.Right);
                            if (i == 6 || i == 5 || i == 7) movables.MoveBall(Movables.BrickCollision.Top);
                            if (i == 4) movables.MoveBall(Movables.BrickCollision.Left);
                            if (i == 2 || i == 3 || i == 1) movables.MoveBall(Movables.BrickCollision.Bottom);
                        }

                        return true;
                    }
                }
            }

            /*foreach (Point p in radiusPoints)
            {
                if (p.X >= brick.X && p.X <= brick.X + 100)
                    if (p.Y >= brick.Y && p.Y <= brick.Y + 45)
                        return true;
            }
            */
            return false;
        }
    }
}
