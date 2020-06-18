using CollegeBreaker.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace CollegeBreaker
{
    public class Ball
    {
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
    }
}
