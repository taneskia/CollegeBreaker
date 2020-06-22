using System.Drawing;

namespace CollegeBreaker
{
    public class Game
    {
        public enum State { Running, LevelBeat, LevelLost, GameBeat, GameLost }
        public Movables movables;
        public Levels levels;
        private bool levelLost;

        public Game()
        {
            movables = new Movables(new Ball(), new Platform());
            levels = new Levels();
        }

        public State GetState()
        {
            if (levelLost)
            {
                return State.LevelLost;
            }

            if (levels.CurrentLevelNumber == 8 && levels.BrickCount == 0)
            {
                return State.GameBeat;
            }

            if (levels.BrickCount == 0)
            {
                return State.LevelBeat;
            }

            return State.Running;
        }

        public void Draw(Graphics graphics)
        {
            movables.Draw(graphics);
            levels.Draw(graphics);
        }

        public void Advance()
        {
            levelLost = !movables.MoveBall();
            levels.CheckCollisionWithBall(movables.ball);
        }

        public void NextLevel()
        {
            levels.NextLevel();
        }

        public void RetryLevel()
        {
            movables.ball.Reset();
            levels.RetryLevel();
        }
    }
}
