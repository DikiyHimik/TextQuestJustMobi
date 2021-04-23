using System;
using System.Collections.Generic;
using System.Text;

namespace TestingTaskJustMobi
{
    class Swagman : Character
    {
        private bool _wasInterraction;

        public Swagman(string name) : base(name)
        {
            _wasInterraction = false;

            FillInventory();
        }

        public bool TryTalk()
        {
            if (_wasInterraction == false)
            {
                Console.WriteLine($"Здравствуй, путник. Меня зовут {Name}. У меня есть кое-что для тебя.");
                _wasInterraction = true;
                return true;
            }
            else
            {
                Console.WriteLine("\"Молчание\"");
                return false;
            }
        }

        private void FillInventory()
        {
            Item medalion = new Item("Медальон");
            _inventory.AddItem(medalion, 1);

            Item goldCoin = new Item("Золотая монета");
            _inventory.AddItem(goldCoin, 50);
        }
    }
}
