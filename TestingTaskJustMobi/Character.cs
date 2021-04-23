using System;
using System.Collections.Generic;
using System.Text;

namespace TestingTaskJustMobi
{
    abstract class Character
    {
        protected string Name;
        protected Inventory _inventory;

        public Character(string name)
        {
            Name = name;
            _inventory = new Inventory();
        }

        public  Dictionary<Item, int> GiveInventory()
        {
            return _inventory.TransferInventory();
        }

        public void AddItemInInventory(Item item, int count)
        {
            _inventory.AddItem(item, count);
        }
    }
}
