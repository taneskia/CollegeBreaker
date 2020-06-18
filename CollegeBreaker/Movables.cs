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
        public enum BrickCollision { None, Right, Top, Left, Bottom }
        public Ball ball;
        public Platform platform;

        public Movables(Ball ball, Platform platform)
        {
            this.ball = ball;
            this.platform = platform;
        }

        public void Draw(Graphics graphics)
        {
            ball.Draw(graphics);
            platform.Draw(graphics);
        }

        public void MovePlatformLeft()
        {
            if (platform.PlatformPosition.X - 5 >= platform.PlatformSpeed)
                platform.PlatformPosition.X -= platform.PlatformSpeed;
        }

        public void MovePlatformRight()
        {
            if (platform.PlatformPosition.X <= 623 - platform.PlatformSpeed - platform.PlatformImage.Width - 5)
                platform.PlatformPosition.X += platform.PlatformSpeed;
        }

        public void MoveBall(BrickCollision brickCollision)
        {
            if (brickCollision == BrickCollision.Right)
            {
                ball.BallSpeedX = -ball.BallSpeedX;
            }
            if (brickCollision == BrickCollision.Top)
            {
                ball.BallSpeedY = -ball.BallSpeedY;
            }
            if (brickCollision == BrickCollision.Left)
            {
                ball.BallSpeedX = -ball.BallSpeedX;
            }
            if (brickCollision == BrickCollision.Bottom)
            {
                ball.BallSpeedY = -ball.BallSpeedY;
            }

            if (brickCollision == BrickCollision.None)
            {
                int x = ball.BallPosition.X + ball.BallSpeedX;
                int y = ball.BallPosition.Y + ball.BallSpeedY;

                bool hitXBorder = false;
                bool hitYBorder = false;

                if (x <= 0)
                {
                    hitXBorder = true;
                    ball.BallPosition.X = 0;
                    ball.BallSpeedX = -ball.BallSpeedX;
                }
                if (x >= 589)
                {
                    hitXBorder = true;
                    ball.BallPosition.X = 589;
                    ball.BallSpeedX = -ball.BallSpeedX;
                }

                if (y <= 0)
                {
                    hitYBorder = true;
                    ball.BallPosition.Y = 0;
                    ball.BallSpeedY = -ball.BallSpeedY;
                }

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

                    if (y >= 515)
                    {
                        ball.BallPosition = new Point(300, 450);
                        ball.BallSpeedX = -ball.Speed;
                        ball.BallSpeedY = -ball.Speed;
                    }
                }

                if (!hitXBorder)
                    ball.BallPosition.X = ball.BallPosition.X + ball.BallSpeedX;

                if (!hitYBorder)
                    ball.BallPosition.Y = ball.BallPosition.Y + ball.BallSpeedY;
            }
        }
    }
}
