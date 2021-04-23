using System;
using System.Collections.Generic;
using System.Text;

namespace TestingTaskJustMobi
{
    class Inventory
    {
        private Dictionary<Item, int> _items = new Dictionary<Item, int>();

        public void AddItem(Item newItem, int countItems)
        {
            if (_items.ContainsKey(newItem))
            {
                _items[newItem] += countItems;
            }
            else
            {
                _items.Add(newItem, countItems);
            }
        }

        public Dictionary<Item, int> TransferInventory()
        {
            Dictionary<Item, int> transferredInventory = new Dictionary<Item, int>(_items);
            _items.Clear();

            return transferredInventory;
        }
    }
}
