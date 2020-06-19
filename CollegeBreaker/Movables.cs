using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeBreaker
{
    public class Movables
    {
        public Ball ball;
        public Platform platform;

        public Movables(Ball ball, Platform platform)
        {
            this.ball = ball;
            this.platform = platform;
        }

        public void Draw(Graphics graphics)
        {
            PlatformBallInteraction();
            ball.Draw(graphics);
            platform.Draw(graphics);
        }

        public void PlatformBallInteraction()
        {
            int x = ball.BallPosition.X + ball.BallSpeedX;
            int y = ball.BallPosition.Y + ball.BallSpeedY;

            bool hitXBorder = false;
            bool hitYBorder = false;

            if (y >= 490) // 515
            {
                int ballCenter = x + ball.BallImage.Width / 2;

                if (ballCenter >= platform.PlatformPosition.X && ballCenter <= platform.PlatformPosition.X + platform.PlatformImage.Width)
                {
                    hitYBorder = true;
                    ball.BallPosition.Y = 485;
                    ball.BallSpeedY = -ball.BallSpeedY;
                }

                #region DetectPlatformPosition

                if (ballCenter >= platform.PlatformPosition.X && ballCenter <= platform.PlatformPosition.X + platform.PlatformImage.Width / 4)
                    ball.BallSpeedX = -ball.Speed;

                else if (ballCenter >= platform.PlatformPosition.X + platform.PlatformImage.Width / 4 && ballCenter <= platform.PlatformPosition.X + 3 * platform.PlatformImage.Width / 4)
                {
                    if (ballCenter > platform.PlatformPosition.X + platform.PlatformImage.Width / 2 + 10)
                        ball.BallSpeedX = ball.Speed / 2;

                    else if (ballCenter < platform.PlatformPosition.X + platform.PlatformImage.Width / 2 - 10)
                        ball.BallSpeedX = -(ball.Speed / 2);

                    else ball.BallSpeedX = 0;
                }

                else if (ballCenter >= platform.PlatformPosition.X + 3 * platform.PlatformImage.Width / 4 && x <= platform.PlatformPosition.X + platform.PlatformImage.Width)
                    ball.BallSpeedX = ball.Speed;

                #endregion DetectPlatformPosition

                if (!hitXBorder)
                    ball.BallPosition.X = ball.BallPosition.X + ball.BallSpeedX;

                if (!hitYBorder)
                    ball.BallPosition.Y = ball.BallPosition.Y + ball.BallSpeedY;
            }
        }

        public bool MoveBall()
        {
            return ball.MoveBall(Ball.BrickCollision.None);
        }
    }
}
