using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    internal class EnemyManager
    {
        public List<Enemy> _enemies { get; set; }
        public Enemy enemy { get; set; }
        public Field field { get; set; }
        public EnemyManager()
        {
            _enemies = new List<Enemy>();
            {
                //이름, 체력, 공격력, 방어력, 골드, 경험치

                _enemies.Add(new Enemy("고블린", 50, 10, 4, 5, 7));
                _enemies.Add(new Enemy("임프", 60, 12, 4, 8, 8));
                _enemies.Add(new Enemy("슬라임", 70, 5, 3, 9, 9));
                _enemies.Add(new Enemy("스켈레톤", 80, 7, 4, 10, 10));

                _enemies.Add(new Enemy("망령", 100, 3, 10, 10, 10));
                _enemies.Add(new Enemy("붉은 슬라임", 120, 8, 6, 11, 12));
                _enemies.Add(new Enemy("붉은 스켈레톤", 120, 10, 6, 12, 15));

                _enemies.Add(new Enemy("오크", 120, 20, 5, 15, 15));
                _enemies.Add(new Enemy("오우거", 250, 25, 10, 20, 25));
                _enemies.Add(new Enemy("트롤", 400, 15, 15, 40, 50));
            }
        }
        public Enemy EnemyRandomGet()
        {
            Random random = new Random();
            int num = random.Next(4);
            Enemy CopyEnemy = _enemies[num];
            return new Enemy(CopyEnemy._Name, CopyEnemy._Health, CopyEnemy._Damage, CopyEnemy._Armor, CopyEnemy._Gold,CopyEnemy._Exp);
        }

        //public Enemy EnemySeting(Enemy enemy)
        //{
            

        //    return enemy;
        //}
    }
}
