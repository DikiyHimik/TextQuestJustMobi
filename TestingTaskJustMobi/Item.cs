using System;
using System.Collections.Generic;
using System.Text;

namespace TestingTaskJustMobi
{
    class Item
    {
        private string _name;

        public string Name => _name;

        public Item(string name)
        {
            _name = name;
        }
    }
}
