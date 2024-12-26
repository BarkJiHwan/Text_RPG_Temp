﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    internal class AccessoryItem : Item
    {
        public int Damage { get; set; }
        public int Armor { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public AccessoryItem(string name, int damage, int armor, int health, int mana, string description,int price)
            : base(ItemTpye.Accessory, name, description, price)
        {
            Damage = damage;
            Armor = armor;
            Health = health;
            Mana = mana;
        }

        public override void equip(Character player)
        {
            Console.WriteLine($"{Name}장착");
            player.Damage += Damage;
            player.Armor += Armor;
            player.Health += Health;
            player.Mana += Mana;
            Console.WriteLine($"공격력 +{Damage}, 방어력 +{Armor}, 체력 +{Health}, 마나 +{Mana}");
        }

        public override void Unequip(Character player)
        {
            Console.WriteLine($"{Name}해제");
            player.Damage -= Damage;
            player.Armor -= Armor;
            player.Health -= Health;
            player.Mana -= Mana;
            Console.WriteLine($"공격력 -{Damage}, 방어력 -{Armor}, 체력 -{Health}, 마나 -{Mana}");
        }
    }
}
