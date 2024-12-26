using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    internal class AccessoryItem : Item
    {
        public AccessoryItem(string name, int damage, int armor, int maxHealth, int maxMana, string description,int price)
            : base(ItemTpye.Accessory, name, description, price)
        {
            Damage = damage;
            Armor = armor;
            MaxHealth = maxHealth;
            MaxMana = maxMana;
        }

        public override void equip(Character player)
        {
            Console.WriteLine($"{Name}장착");
            player.Damage += Damage;
            player.Armor += Armor;
            player.MaxHealth += MaxHealth;
            player.MaxMana += MaxMana;
            Console.WriteLine($"공격력 +{Damage}, 방어력 +{Armor}, 체력 +{MaxHealth}, 마나 +{MaxMana}");
        }

        public override void Unequip(Character player)
        {
            Console.WriteLine($"{Name}해제");
            player.Damage -= Damage;
            player.Armor -= Armor;
            player.MaxHealth -= MaxHealth;
            player.MaxMana -= MaxMana;
            Console.WriteLine($"공격력 -{Damage}, 방어력 -{Armor}, 체력 -{MaxHealth}, 마나 -{MaxMana}");
        }
    }
}
