using System;
using System.Collections.Generic;
using System.Text;

using RPGConsole.Project.Items;
using RPGConsole.Project.Enums;
using RPGConsole.Project.Items.Equipments;

namespace RPGConsole.Project
{
    class Inventory
    {
        private ObjectId Id;
        private List<Item> Content;

        public Inventory(string Id)
        {
            this.Id = new ObjectId(Id);
            Content = new List<Item>();
        }

        public void RemoveItem(ObjectId Id)
        {
            foreach (Item Item in Content)
            {
                if (Id.ToString() == Item.ToString())
                {
                    Content.Remove(Item);
                    return;
                }
            }
        }
        public void AddItem(Item Item)
        {
            Content.Add(Item);
        }

        #region Setter

        #endregion


        #region Getter
        public ObjectId GetId() { return Id; }
        public Item GetItemById(ObjectId Id)
        {
            foreach(Item Item in Content)
            {
                if(Item.GetId().ToString() == Id.ToString())
                {
                    return Item;
                }
            }
            return null;
        }
        public Weapon GetEquipedWeapon()
        {
            foreach(Weapon Weapon in Content)
            {
                if(Weapon.GetItemType() == ItemType.Weapon)
                {
                    if(Weapon.IsEquiped())
                    {
                        return Weapon;
                    }
                }
            }
            return null;
        }
        #endregion
    }
}
