using System;
using System.Collections.Generic;
using System.Text;

using RPGConsole.Project.Enums;


namespace RPGConsole.Project.Items
{
    class Item
    {
        protected ObjectId Id;
        protected ItemType Type;
        protected bool Equiped;

        public Item(string Id, ItemType Type)
        {
            this.Type = Type;
            this.Equiped = false;
            this.Id = new ObjectId(Id);
        }
        public Item(string Id, ItemType Type, bool Equiped)
        {
            this.Type = Type;
            this.Equiped = Equiped;
            this.Id = new ObjectId(Id);
        }

        #region Getter
        public bool IsEquiped() { return Equiped; }
        public string GetId() { return Id.ToString(); }
        public ItemType GetItemType() { return Type; }
        #endregion
    }
}
