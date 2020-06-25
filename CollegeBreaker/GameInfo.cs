using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeBreaker
{
    public class GameInfo
    {
        public List<List<int>> PointsFromLevels { get; set; }
        public Game.State State { get; set; }
        public int LevelTime { get; set; }

        public GameInfo(List<List<int>> PointsFromLevels, Game.State state, int levelTime)
        {
            this.PointsFromLevels = PointsFromLevels;            
            State = state;
            LevelTime = levelTime;
        }
    }
}
