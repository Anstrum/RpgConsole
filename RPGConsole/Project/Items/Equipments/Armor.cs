using System;
using System.Collections.Generic;
using System.Text;

using RPGConsole.Project.Misc;
using RPGConsole.Project.Enums;

namespace RPGConsole.Project.Items.Equipments
{
    class Armor : Item
    {
        public Armor() : base(IdGenerator.CreateId(), ItemType.Armor)
        {

        }
    }
}
