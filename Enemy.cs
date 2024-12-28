using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TextRPGAlancia
{
    public class Enemy : Character
    {
        public Enemy(string name ,int health, int damage, int armor, int gold, int exp)
            : base(name,health,damage,armor) 
        {
            Name = name;
            Health = health;
            Damage = damage;
            Armor = armor;
            Gold = gold;
            Exp = exp;

            MaxHealth = Health;
            Mana = 0;
            MaxMana = MaxMana;
            MaxGold = Gold;
        }

        //public override void Attack(Character target)
        //{
        //    int attackDamag = Damage - target.Armor;
        //    if (attackDamag < 0)
        //    {
        //        attackDamag = 0;
        //    }
        //    target.Health -= attackDamag;
        //    Console.WriteLine($"{Name}이가 {target.Name}에게 {attackDamag}피해를 줬습니다.");
        //}

        public void EnemyDisplayStats()
        {
            Console.WriteLine($"적 이름: {Name} \n" +
                $"체력: {Health}, 공격력: {Damage}, 방어력: {Armor}, 경험치 {Exp}");
        }
    }
}
