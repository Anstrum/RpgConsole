using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

using RPGConsole.Project.Enums;

namespace RPGConsole.Project.Areas
{
    class Area
    {
        protected Vector2 Position;
        protected AreaType Type;

        protected bool PathLeft;
        protected bool PathRight;
        protected bool PathDown;

        public Area(Vector2 Position, AreaType Type)
        {
            this.Position = Position;
            this.Type = Type;
        }
        public Area(Vector2 Position, AreaType Type, bool LeftPath, bool RightPath, bool DownPath)
        {
            this.Position = Position;
            this.Type = Type;
            this.PathLeft = LeftPath;
            this.PathRight = RightPath;
            this.PathDown = DownPath;
        }
        public void SetPath(bool Left, bool Right, bool Down)
        {
            PathLeft = Left;
            PathLeft = Right;
            PathLeft = Down;
        }
        public KeyValuePair<Vector2, AreaType> GetInfo()
        {
            return new KeyValuePair<Vector2, AreaType>(Position, Type) ;
        }
        public bool[] GetPaths()
        {
            return new bool[]{PathLeft, PathRight, PathDown };
        }
    }
}
