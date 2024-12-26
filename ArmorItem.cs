using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    internal class ArmorItem : Item
    {
        public int Armor { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public ArmorItem(string name, int armor, int health, int mana, string description,int price)
            : base(ItemTpye.Armor, name, description, price)
        {
            Armor = armor;
            Health = health;
            Mana = mana;
        }

        public override void equip(Character player)
        {
            Console.WriteLine($"{Name}장착");
            player.Armor += Armor;
            player.Health += Health;
            player.Mana += Mana;
            Console.WriteLine($"방어력 +{Armor}, 체력 +{Health}, 마나 +{Mana}");
        }
        public override void Unequip(Character player)
        {
            Console.WriteLine($"{Name}해제");
            player.Armor -= Armor;
            player.Health -= Health;
            player.Mana -= Mana;
            Console.WriteLine($"방어력 -{Armor}, 체력 -{Health}, 마나 -{Mana}");
        }        
    }
}
