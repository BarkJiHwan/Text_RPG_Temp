using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    public abstract class Character
    {
        public string _Name { get; set; }
        public int _NumBer {  get; set; }
        public int _Health { get; set; }
        public int _Mana { get; set; }
        public int _MaxHealth { get; set; }
        public int _MaxMana { get; set; }
        public int _Gold { get; set; }
        public int _maxGold { get; set; }
        public double _Critical { get; set; }
        public double _CriticalDam { get; set; }
        public int _Damage { get; set; }
        public int _Armor { get; set; }
        public int _Level { get; set; }
        public int _Exp { get; set; }
        public int _maxExp { get; set; }
        public bool _isPlayerState { get; set; } //죽었니~ 살앗니~?
        static int enemyCount = 0;
        protected Character(string name, int health, int damage, int armor)
        { 
            _Name = name;
            _Health = health;   
            _MaxHealth = damage;
            _Mana = armor;
        }


        public abstract void Attack(Character target);
    }

}
