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
        private Area[,] TableMap;
        public Map(int GameDuration)
        {
            this.GameDuration = GameDuration;
            Generate();
            Draw();
            Console.ReadKey();
        }

        private void Generate()
        {
            TableMap = new Area[GameDuration, 17];
            for(int i = 0; i < GameDuration; i++)
            {
                for(int j = 0; j < 17; j++)
                {
                    TableMap[i,j] = null;
                }
            }


            TableMap[0, 4] = new Area(new Vector2(0, 4), AreaType.Spawn);
            TableMap[1, 3] = new Area(new Vector2(1, 3), AreaType.Fight);
            TableMap[1, 4] = new Area(new Vector2(1, 4), AreaType.Fight);
            TableMap[1, 5] = new Area(new Vector2(1, 5), AreaType.Fight);

        }
        public void Draw()
        {

        }

        public void CreateArea(Vector2 Position, AreaType Type, bool LeftPath, bool RightPath, bool DownPath)
        {
            Areas.Add(new Area(Position, Type, LeftPath, RightPath, DownPath));
        }
        public void CreateArea(Vector2 Position, AreaType Type)
        {
            Areas.Add(new Area(Position, Type));
        }
        public AreaType GetRandomAreaType(Random Random)
        {
            double Value = Random.NextDouble();

            if(Value < 0.70)
            {
                return AreaType.Fight;
            }
            else if(Value < 0.90)
            {
                return AreaType.Boss;
            }
            else
            {
                return AreaType.City;
            }
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
        public Area GetAreaByPosition(Vector2 Position)
        {
            foreach(Area MyArea in Areas)
            {
                if(MyArea.GetInfo().Key == Position)
                {
                    return MyArea;
                }
            }
            return null;
        }
        #endregion
    }
}
