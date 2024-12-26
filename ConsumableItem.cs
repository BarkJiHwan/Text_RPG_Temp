using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    internal class ConsumableItem : Item
    {
        public ConsumableItem(string name, string description, int health, int mana, int price)
            : base(ItemTpye.Consumable, name, description, price)
        {
            Health = health;
            Mana = mana;
        }
        public override void equip(Character player)
        {
            Console.WriteLine($"{Name}을 사용합니다.");
            if (Health > 0 && Mana == 0)
            {
                Console.WriteLine($"체력을 {Health} 회복합니다.");
                player.Health += Health;
            }
            else if (Mana > 0 && Health ==0)
            {
                Console.WriteLine($"마력을 {Mana} 회복합니다.");
                player.Mana += Mana;
            }
        }

        public override void Unequip(Character player) { }
    }
}
