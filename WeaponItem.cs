using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    internal class WeaponItem : Item
    {
        public WeaponItem(ItemTpye itemTpye, string name, int damage, double criticall, double criticalDam, string description ,int price) 
            : base(ItemTpye.Weapon, name, description, price)
        {
            itemTpye = ItemTpye.Weapon;
            Damage = damage;
            Critical = criticall;
            CriticalDam = criticalDam;
        }

        public override void Equip(Player player)
        {
            Console.WriteLine($"{Name}장착");
            player.Damage += Damage;
            player.Critical += Critical;
            player.CriticalDam += CriticalDam;
            Console.WriteLine($"공격력 +{Damage}, 크리티컬 확률 +{Critical}, 크리티컬데미지 +{CriticalDam}");
        }

        public override void Unequip(Player player)
        {
            Console.WriteLine($"{Name}해제");
            player.Damage -= Damage;
            player.Critical -= Critical;
            player.CriticalDam -= CriticalDam;
            Console.WriteLine($"공격력 -{Damage}, 크리티컬 확률 -{Critical}, 크리티컬데미지 -{CriticalDam}");
        }
    }
}
