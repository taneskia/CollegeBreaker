using CollegeBreaker.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace CollegeBreaker
{
    public class Ball
    {
        public enum BrickCollision { None, Right, Top, Left, Bottom }
        public Image BallImage;
        public Point BallPosition;
        public int BallSpeedX;
        public int BallSpeedY;
        public int Speed = 7;

        public Ball()
        {
            BallImage = Resources.Ball;
            BallPosition = new Point(300, 450);
            BallSpeedX = -Speed;
            BallSpeedY = -Speed;
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

        public bool MoveBall(BrickCollision brickCollision)
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

            bool hitXBorder = false;
            bool hitYBorder = false;

            if (brickCollision == BrickCollision.None)
            {
                int x = BallPosition.X + BallSpeedX;
                int y = BallPosition.Y + BallSpeedY;

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

                if (y <= 0)
                {
                    hitYBorder = true;
                    BallPosition.Y = 0;
                    BallSpeedY = -BallSpeedY;
                }


                if (y >= 515)
                {
                    BallPosition = new Point(BallPosition.X, 515);
                    return false;
                }
            }

            if (!hitXBorder)
                BallPosition.X = BallPosition.X + BallSpeedX;

            if (!hitYBorder)
                BallPosition.Y = BallPosition.Y + BallSpeedY;
            return true;
        }
    }
}

