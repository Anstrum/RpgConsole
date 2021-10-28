using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

using RPGConsole.Project.Enums;

namespace RPGConsole.Project.Areas
{
    class Area
    {
        protected AreaType Type;
        protected int Position;

        public Area(AreaType Type, int Position)
        {
            this.Type = Type;
            this.Position = Position;
        }

        public AreaType GetInfo()
        {
            return Type;
        }
        public int GetPosition()
        {
            return Position;
        }
    }
}
