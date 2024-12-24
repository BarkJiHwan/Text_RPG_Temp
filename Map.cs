using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Temp
{
    internal class Map //원래 분리된걸 합쳤는데 다시 클래스를 나눠야 할 것 같다는 생각이듬..
    {
        public Village village {  get; private set; }
        public Field field { get; private set; }
        public Dungeon dungeon { get; private set; }
        public Map()
        {
            village = new Village();
            field = new Field();
            dungeon = new Dungeon();
        }
    }
}