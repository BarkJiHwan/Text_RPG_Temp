using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Temp
{
    internal class MapManager
    {//맵을 관리하는 클래스
        public Village Village { get; set; }
        public  Field field { get; set; }
        public Dungeon Dungeon  { get; set; }

        public MapManager()
        {
            Village = new Village();
            field = new Field();
            Dungeon = new Dungeon();
        }
    }
}