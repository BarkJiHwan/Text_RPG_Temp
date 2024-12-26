using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Temp
{
    internal class Player : Character
    {
        public bool Mainstory;
        public Player(string name) : base(name, 100, 10, 5)
        {
            Name = name;
            Level = 1;
            Health = 100;
            Damage = 10;
            Armor = 5;
            Mana =50 ;
            MaxHealth = Health;
            MaxMana = Mana;
            Critical = 5;
            CriticalDam = (Damage * 1.5);
            Gold = 0;
            
            MaxGold = 999_999_999;
            Exp = 0;
            MaxExp = 0;        
            
            Inventory inventory = new Inventory();
        }

        //public override void Attack(Character target)
        //{
        //    int actualDamage = Damage - target.Armor;
        //    if (actualDamage < 0)
        //    {
        //        actualDamage = 0;
        //    }
        //    target.Health-= actualDamage;
        //    Console.WriteLine($"{Name}이 {target.Name}에게 {actualDamage}의 데미지를 줌");

        //}

        public void PlayerStats()
        {
            Console.WriteLine($"이름: {Name}, 레벨: {Level} \n" +
                $"체력: {Health}, 마력: {Mana}, \n" +
                $"공격력: {Damage}, 방어력: {Armor} \n" +
                $"크리티컬확률: {Critical} \n" +
                $"크리티컬데미지: {CriticalDam} \n" +
                $"골드: {Gold}\n"+
                $"경험치: {Exp}");
        }
    }
}