using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    public class LevelUp
    {        
        public int LevelCount {  get; set; }
        public int Exp {  get; set; }
        public int AttackIncrease { get; set; }
        public int ArmorIncrease { get; set; } 
        public int MaxHealthIncrease { get; set; }
        public int MaxManaIncrease { get; set; }


        public LevelUp(int level, int exp, int attackIncrease, int aromrIncrease, int maxHealthIncrease, int maxManaIncrease) 
        {
            LevelCount = level;
            Exp = exp;
            AttackIncrease = attackIncrease;
            ArmorIncrease = aromrIncrease;
            MaxHealthIncrease = maxHealthIncrease;
            MaxManaIncrease = maxManaIncrease;
        }
    }
}
