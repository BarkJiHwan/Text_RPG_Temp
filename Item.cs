using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    internal class Item
    {
        public int Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Damage { get; set; }
        public int Armor { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public double Critical { get; set; }
        public double CriticalDam { get; set; }
        public Item() { }

    }
}
