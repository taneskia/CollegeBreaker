using CollegeBreaker.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeBreaker
{
    public class Ball
    {
        public enum BrickCollision { None, Right, Top, Left, Bottom }
        private Image BallImage;
        private Point BallPosition;
        private int BallSpeedX;
        private int BallSpeedY;

        public Ball()
        {
            BallImage = Resources.Ball;
            BallPosition = new Point(300, 450);
            BallSpeedX = -5;
            BallSpeedY = -5;
        }

        public Point GetBallPosition
        {
            get
            {
                return BallPosition;
            }
        }

        public void IncreaseSpeed(int increment)
        {
            BallSpeedX += BallSpeedX > 0 ? increment : -increment;
            BallSpeedY += BallSpeedY > 0 ? increment : -increment;
        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawImageUnscaled(BallImage, BallPosition);
        }

        public void MoveBall(BrickCollision brickCollision)
        {
            if (brickCollision == BrickCollision.Right)
            {
                BallSpeedX = -BallSpeedX;
            }
            if (brickCollision == BrickCollision.Top)
            {
                BallSpeedY = -BallSpeedY;
            }
            if (brickCollision == BrickCollision.Left)
            {
                BallSpeedX = -BallSpeedX;
            }
            if (brickCollision == BrickCollision.Bottom)
            {
                BallSpeedY = -BallSpeedY;
            }

            if (brickCollision == BrickCollision.None)
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
}
