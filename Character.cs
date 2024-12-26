using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Temp
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int Type {  get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int MaxHealth { get; set; }
        public int MaxMana { get; set; }
        public int Gold { get; set; }
        public int MaxGold { get; set; }
        public double Critical { get; set; }
        public double CriticalDam { get; set; }
        public int Damage { get; set; }
        public int Armor { get; set; }
        public int Level { get; set; }
        public int Exp { get; set; }
        public int MaxExp { get; set; }
        public bool IsPlayerState { get; set; } //죽었니~ 살앗니~?
        static int EnemyCount = 0;
        protected Character(string name, int health, int damage, int armor)
        { 
            Name = name;
            Health = health;   
            MaxHealth = damage;
            Mana = armor;
        }

        public void Attack(Character target)        
        {
            int attackDamag = Damage - target.Armor;
            if (attackDamag < 0)
            {
                attackDamag = 0;
            }
            target.Health -= attackDamag;
            Console.WriteLine($"{Name}이가 {target.Name}에게 {attackDamag}피해를 줬습니다.");
        }
    }

}
