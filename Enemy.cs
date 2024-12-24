using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Temp
{
    public class Enemy : Character
    {
        public Enemy(string name ,int health, int damage, int armor, int gold, int exp)
            : base(name,health,damage,armor) 
        {
            _Name = name;
            _Health = health;
            _Damage = damage;
            _Armor = armor;
            _Gold = gold;
            _Exp = exp;

            _MaxHealth = _Health;
            _Mana = 0;
            _MaxMana = _MaxMana;
            _maxGold = _Gold;
        }

        public override void Attack(Character target)
        {
            int attackDamag = _Damage - target._Armor;
            if (attackDamag < 0)
            {
                attackDamag = 0;
            }
            target._Health -= attackDamag;
            Console.WriteLine($"{_Name}이가 {target._Name}에게 {attackDamag}피해를 줬습니다.");

        }

        public void EnemyDisplayStats()
        {
            Console.WriteLine($"적 이름: {_Name} \n" +
                $"체력: {_Health}, 공격력: {_Damage}, 방어력: {_Armor}, 경험치 {_Exp}");
        }
    

    }
}
