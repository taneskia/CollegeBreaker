using CollegeBreaker.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeBreaker
{
    class Game
    {
        public int Level { get; set; }
        public int[] LevelPoints { get; set; }
        private Image[][] Bricks;
        private Image Ball;
        private Point BallPosition;
        private int BallSpeedX;
        private int BallSpeedY;

        private Random random;

        public Game()
        {
            Level = 0;
            Bricks = new Image[5][];
            for (int i = 0; i < Bricks.Length; i++)
                Bricks[i] = new Image[4];
            Ball = Resources.Ball;
            BallPosition = new Point(300, 450);
            BallSpeedX = -8;
            BallSpeedY = -8;

            random = new Random();

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
                            Bricks[i][j].Tag = 5;
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
            MoveBall();
            graphics.DrawImageUnscaled(Ball, BallPosition);
            CheckCollision();
            DrawBricks(graphics);
        }

        public void DrawBricks(Graphics graphics)
        {
            for (int i = 0; i < Bricks.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Bricks[i][j] != null)
                        graphics.DrawImageUnscaled(Bricks[i][j], 50 + 106 * i, 90 + 51 * j);
                }
            }
        }

        private void CheckCollision()
        {
            for (int i = 0; i < Bricks.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Bricks[i][j] != null)
                    {
                        if (DoOverlap(new Point(50 + 106 * i, 90 + 51 * j), BallPosition))
                        {
                            Bricks[i][j] = null;
                        }
                    }
                }
            }
        }

        private bool DoOverlap(Point brick, Point ball)
        {
            List<Point> radiusPoints = new List<Point>();
            for (double angle = 0.0; angle < 2.0 * Math.PI; angle += (Math.PI / 180) * 15)
            {
                radiusPoints.Add(new Point(ball.X + 17 + (int)(17 * Math.Cos(angle)), ball.Y + 17 + (int)(17 * Math.Sin(angle))));
            }

            foreach(Point p in radiusPoints)
            {
                if (p.X >= brick.X && p.X <= brick.X + 100)
                    if (p.Y >= brick.Y && p.Y <= brick.Y + 45)
                        return true;
            }

            return false;
        }



        private void MoveBall()
        {
            int x = BallPosition.X + BallSpeedX;
            int y = BallPosition.Y + BallSpeedY;

            bool hitXBorder = false;
            bool hitYBorder = false;

            if (x <= 0)
            {
                hitXBorder = true;
                BallPosition.X = 0;
                BallSpeedX = -BallSpeedX;
            }
            if (x >= 589)
            {
                hitXBorder = true;
                BallPosition.X = 589;
                BallSpeedX = -BallSpeedX;
            }

            if (y <= 45)
            {
                hitYBorder = true;
                BallPosition.Y = 45;
                BallSpeedY = -BallSpeedY;
            }

            if (y >= 515)
            {
                hitYBorder = true;
                BallPosition.Y = 515;
                BallSpeedY = -BallSpeedY;
            }

            if (!hitXBorder)
                BallPosition.X = BallPosition.X + BallSpeedX;
            if (!hitYBorder)
                BallPosition.Y = BallPosition.Y + BallSpeedY;
        }
    }
}
