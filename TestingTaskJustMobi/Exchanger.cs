using System;
using System.Collections.Generic;
using System.Text;

namespace TestingTaskJustMobi
{
    class Exchanger
    {
        public void TransferItem(Character transmitter, Character receiver)
        {
            Dictionary<Item, int> transferredItems = transmitter.GiveInventory();

            foreach (KeyValuePair<Item, int> item in transferredItems)
            {
                receiver.AddItemInInventory(item.Key, transferredItems[item.Key]);
                Console.WriteLine($"Вы получили: {item.Key.Name} в количестве {transferredItems[item.Key]}");
            }
        }
    }
}
