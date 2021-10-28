using System;
using System.Collections.Generic;
using System.Numerics;

using RPGConsole.Project.Misc;
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
        }
        public void Draw()
        {
            Console.WriteLine("There is the map:");
            foreach(Area Area in Areas)
            {
                Console.WriteLine("Floor: " + Area.GetPosition() + " | Room Type: " + Area.GetInfo().ToString());
            }
        }
        public void Generate(int GameDuration)
        {
            Areas.Clear();
            Areas.Add(new Area(AreaType.Spawn, 0));
            Areas.Add(new Area(AreaType.Fight, 1));

            int CityCount = 1;
            int BossCount = 1;
            Random Random = new Random(Converter.AnyToInt(DateTime.Now.ToString()));
            for (int i = 2; i < GameDuration; i++)
            {
                if(CityCount > 3 && Random.NextDouble() < 0.3 || CityCount > 9)
                {
                    Areas.Add(new Area(AreaType.City, i));
                    CityCount = 0;
                    BossCount++;
                    continue;
                }
                if(BossCount > 2 && Random.NextDouble() < 0.3 || BossCount > 5)
                {
                    Areas.Add(new Area(AreaType.Boss, i));
                    BossCount = 0;
                    CityCount++;
                    continue;
                }
                Areas.Add(new Area(AreaType.Fight, i));
                BossCount++;
                CityCount++;
            }
            Debug.Print("Map Created");
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
        public Area GetArea(int Position)
        {
            foreach(Area Area in Areas)
            {
                if(Area.GetPosition() == Position)
                {
                    return Area;
                }
            }
            return null;
        }

        #endregion
    }
}
