using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    internal class Monster
    {
        public List<Enemy> _enemies {  get; set; }
        public Enemy enemy;
        public Monster() 
        {
            enemy = new Enemy();
            _enemies = new List<Enemy>();
            {
                _enemies.Add(new Enemy("고블린", 50, 5, 3));
                _enemies.Add(new Enemy("임프", 80, 15, 4));
                _enemies.Add(new Enemy("스켈레톤", 100, 5, 3));
                _enemies.Add(new Enemy("망령", 100, 3, 10));
                _enemies.Add(new Enemy("오크", 100, 10, 5));
                _enemies.Add(new Enemy("오우거", 250, 25, 10));
                _enemies.Add(new Enemy("트롤", 400, 15, 15));
            }
        }
    }
}
