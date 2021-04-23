using System;
using System.Collections.Generic;
using System.Text;

namespace TestingTaskJustMobi
{
    class Exchanger
    {
        public void TransferInventory(Character transmitter, Character receiver)
        {
            Dictionary<Item, int> transferredInventory = transmitter.GiveInventory();

            foreach (KeyValuePair<Item, int> item in transferredInventory)
            {
                receiver.AddItemInInventory(item.Key, transferredInventory[item.Key]);
                Console.WriteLine($"Вы получили: {item.Key.Name} в количестве {transferredInventory[item.Key]}");
            }
        }
    }
}
