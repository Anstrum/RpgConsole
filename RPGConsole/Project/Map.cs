using System;
using System.Collections.Generic;
using System.Numerics;

using RPGConsole.Project.Areas;
using RPGConsole.Project.Enums;

namespace RPGConsole.Project
{
    class Map
    {
        private int GameDuration;
        private List<Area> Areas = new List<Area>();
        public Map(int GameDuration)
        {
            this.GameDuration = GameDuration;
            Generate();
            Draw();
            Console.ReadKey();
        }

        private void Generate()
        {
        }
        public void Draw()
        {

        }



        #region Area Ask
        public List<Area> GetAreasByNumber(int RoomNuber)
        {
            List<Area> MatchingAreas = new List<Area>();
            foreach(Area Area in Areas)
            {
                if(Area.GetInfo().Key.X == RoomNuber)
                {
                    MatchingAreas.Add(Area);
                }
            }
            return MatchingAreas;
        }
        public bool IsDupe(Vector2 Position)
        {
            foreach(Area MyArea in GetAreasByNumber(Convert.ToInt32(Position.X)))
            {
                if(MyArea.GetInfo().Key.Y == Position.Y)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
