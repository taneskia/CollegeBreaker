using System;
using System.Collections.Generic;
using System.Drawing;

namespace CollegeBreaker
{
    public class Game : IObservable<GameInfo>, IObserver<List<List<int>>>
    {
        private static readonly Game INSTANCE = new Game();
        private readonly List<IObserver<GameInfo>> observers;
        public enum State { Running, LevelBeat, LevelLost, GameBeat, GameLost, Paused }
        public Movables movables;
        public Levels levels;
        private bool levelLost;
        private bool paused;

        private Game()
        {
            observers = new List<IObserver<GameInfo>>();
            movables = new Movables(new Ball(), new Platform());
            levels = new Levels();
            levels.Subscribe(this);
            paused = false;
        }

        public static Game GetInstance()
        {
            return INSTANCE;
        }

        private void Notify()
        {
            GameInfo gameInfo = new GameInfo(levels.PointsFromLevels, GetState(), levels.LevelTime);
            foreach (IObserver<GameInfo> o in observers)
                o.OnNext(gameInfo);
        }

        public void Pause(bool pause)
        {
            if (pause)
                levels.LevelTimer.Stop();

            else if (!levels.LevelTimer.Enabled)
                levels.LevelTimer.Start();

            paused = pause;

            Notify();
        }

        public State GetState()
        {
            /*
            if (levels.GetMeanGrade() < 5 && levels.PointsFromLevels.Count != 0)
            {
                return State.LevelLost;
            }
            */

            if (paused)
                return State.Paused;

            if (levels.BrickCount == 0)
                return State.LevelBeat;

            if (levelLost)
                return State.LevelLost;

            if (levels.CurrentLevelNumber == 8 && levels.BrickCount == 0)
                return State.GameBeat;            

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

            if (levelLost)
                Notify();

            levels.CheckCollisionWithBall(movables.ball);
        }

        public void NextLevel()
        {
            if (levels.CurrentLevelNumber % 2 == 0)
            {
                movables.ball.Speed += 1;
                movables.platform.PlatformSpeed += 1;
            }

            movables.Reset();
            levels.NextLevel();

            Notify();
        }

        public void RetryLevel()
        {
            movables.ball.Reset();
            levels.RetryLevel();

            GameInfo gameInfo = new GameInfo(levels.PointsFromLevels, State.Running, levels.LevelTime);
            foreach (IObserver<GameInfo> o in observers)
                o.OnNext(gameInfo);
        }

        public IDisposable Subscribe(IObserver<GameInfo> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
                // Provide observer with existing data.
                observer.OnNext(new GameInfo(levels.PointsFromLevels, GetState(), levels.LevelTime));
            }
            return new Unsubscriber<GameInfo>(observers, observer);
        }

        public void OnNext(List<List<int>> value)
        {
            GameInfo gameInfo = new GameInfo(value, GetState(), levels.LevelTime);
            foreach (IObserver<GameInfo> o in observers)
                o.OnNext(gameInfo);
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        internal class Unsubscriber<GameInfo> : IDisposable
        {
            private readonly List<IObserver<GameInfo>> _observers;
            private readonly IObserver<GameInfo> _observer;

            internal Unsubscriber(List<IObserver<GameInfo>> observers, IObserver<GameInfo> observer)
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
