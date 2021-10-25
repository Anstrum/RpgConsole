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
        private char[,] TableMap;
        public Map(int GameDuration)
        {
            this.GameDuration = GameDuration;
            Generate();
            Draw();
            Console.ReadKey();
        }

        private void Generate()
        {
            TableMap = new char[GameDuration * 2, 19];
            for(int i = 0; i < GameDuration * 2; i++)
            {
                for(int j = 0; j < 19; j++)
                {
                    TableMap[i,j] = ' ';
                }
            }
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
