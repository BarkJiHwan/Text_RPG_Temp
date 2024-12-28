using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGAlancia
{
    public class LevelManager
    {
        public LevelManager() 
        { 
            List<LevelUp> levelUpTable = new List<LevelUp>();
            {
                new LevelUp(2, 300, 10, 3, 30, 10);
                new LevelUp(3, 800, 10, 3, 30, 10);
                new LevelUp(4, 1200, 10, 3, 30, 10);
                new LevelUp(5, 1600, 10, 3, 30, 10);
                new LevelUp(6, 1800, 10, 3, 30, 10);
                new LevelUp(7, 2200, 10, 3, 30, 10);
                new LevelUp(8, 2600, 10, 3, 30, 10);
                new LevelUp(9, 3300, 10, 3, 30, 10);
                new LevelUp(10, 4300, 10, 3, 30, 10);

            }
        }
    }
}
