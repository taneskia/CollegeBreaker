using CollegeBreaker.Properties;
using System.Drawing;

namespace CollegeBreaker
{
    public class Platform
    {
        public Point PlatformPosition;
        public Image PlatformImage;
        public int PlatformSpeed;

        public Platform()
        {
            PlatformImage = Resources.Platform;
            PlatformPosition = new Point(314 - PlatformImage.Width / 2, 520);
            PlatformSpeed = 5;
        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawImageUnscaled(PlatformImage, PlatformPosition);
        }

        public void MovePlatformLeft()
        {
            if (PlatformPosition.X - 5 >= PlatformSpeed)
                PlatformPosition.X -= PlatformSpeed;
        }

        public void MovePlatformRight()
        {
            if (PlatformPosition.X <= 623 - PlatformSpeed - PlatformImage.Width - 5)
                PlatformPosition.X += PlatformSpeed;
        }

    }
}
