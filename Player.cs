using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Temp
{
    public class Player : Character
    {
        public bool Mainstory;
        public Inventory playerinventory {  get; set; }
        public Equipment Equipment { get; set; }
        public Player(string name) : base(name, 100, 10, 5)
        {
            Name = name;
            Level = 1;
            MaxHealth = 300;
            MaxMana = 100;
            Health = MaxHealth;
            Mana = MaxMana;
            Damage = 50;
            Armor = 5;
            Critical = 5;
            CriticalDam = (Damage * 1.5);
            Gold = 0;
            
            MaxGold = 999_999_999;
            Exp = 0;
            MaxExp = 0;

            playerinventory = new Inventory();
            Equipment = new Equipment();
            
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
                $"골드: {Gold}\n" +
                $"경험치: {Exp}\n");
        }

        public void LevelUP()
        {
            Level++;
            Damage += 10;
            Armor += 3;
            MaxHealth += 30;
            Health = MaxHealth;
            MaxMana += 10;
            Mana = MaxMana;

            Console.WriteLine($"레벨이 올랐습니다.\n" +
                $"체력과 마력이 모두 회복됩니다.");
        }

        public void ItemGet(Item item)
        {            
            playerinventory.inventories.Add(item);
        }
        public void PrintInven()
        {
            int Number=0;
            foreach (var item in playerinventory.inventories)
            {
                Console.WriteLine($"{Number++}번 아이템 : {item.Name}");
            }
        }
    }
}