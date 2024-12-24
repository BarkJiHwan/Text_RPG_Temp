using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    internal class Player : Character
    {
        public Player(string name) : base(name, 100, 10, 5)
        {
            _Name = name;
            _Level = 1;
            _Damage = 10;
            _Armor = 5;
            _Health = 100;
            _Mana =50 ;
            _MaxHealth = _Health;
            _MaxMana = _Mana;
            _Gold = 0;
            _maxGold = 999_999_999;

            _Critical = 5;
            _CriticalDam = (_Damage * 1.5);
            _Exp = 0;
            _MaxHealth = 0;
            _MaxMana = 0;
            _Gold = 0;
            _maxGold = 0;
            _maxExp = 0;
        }

        public override void Attack(Character target)
        {
            int actualDamage = _Damage - target._Armor;
            if (actualDamage < 0)
            {
                actualDamage = 0;
            }
            target._Health-= actualDamage;
            Console.WriteLine($"{_Name}이 {target._Name}에게 {actualDamage}의 데미지를 줌");

        }

        public void PlayerStats()
        {
            Console.WriteLine($"이름: {_Name}, 레벨: {_Level} \n" +
                $"체력: {_Health}, 마력: {_Mana}, \n" +
                $"공격력: {_Damage}, 방어력: {_Armor} \n" +
                $"크리티컬확률: {_Critical} \n" +
                $"크리티컬데미지: {_CriticalDam} \n" +
                $"골드: {_Gold}\n"+
                $"경험치: {_Exp}");
        }
    }
}