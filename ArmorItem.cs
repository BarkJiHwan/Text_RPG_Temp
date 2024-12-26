using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    internal class ArmorItem : Item
    {
        public ArmorItem(string name, int armor, int maxHealth, int maxMana, string description, int price)
            : base(ItemTpye.Armor, name, description, price)
        {
            Armor = armor;
            MaxHealth = maxHealth;
            MaxMana = maxMana;
        }

        public override void equip(Character player)
        {
            Console.WriteLine($"{Name}장착");
            player.Armor += Armor;
            player.MaxHealth += MaxHealth;
            player.MaxMana += MaxMana;
            Console.WriteLine($"방어력 +{Armor}, 체력 +{MaxHealth}, 마나 +{MaxMana}");
        }
        public override void Unequip(Character player)
        {
            Console.WriteLine($"{Name}해제");
            player.Armor -= Armor;
            player.MaxHealth -= MaxHealth;
            player.MaxMana -= MaxMana;
            Console.WriteLine($"방어력 -{Armor}, 체력 -{MaxHealth}, 마나 -{MaxMana}");
        }        
    }
}
