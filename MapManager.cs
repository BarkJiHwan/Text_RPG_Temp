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
        public List<Location> Locations;
        public MapManager()
        {
            Locations = new List<Location>();
            {
                Locations.Add(new Village("시작의마을", "낯선 풍경이지만 왠지 익숙한 느낌이 든다."));
                Locations.Add(new Field("첫번째 필드", "필드"));
                Locations.Add(new Dungeon("첫번째 던전", "던전"));

                Locations.Add(new Village("두번째마을", ""));
                Locations.Add(new Field("두번째필드", "사냥터"));
                Locations.Add(new Dungeon("두번째 던전",""));

                Locations.Add(new Village("세번째 마을", ""));
                Locations.Add(new Field("세번째 필드", "사냥터"));
                Locations.Add(new Dungeon("세번째 던전", "사냥터"));

                Locations.Add(new Village("네번째 마을", ""));
                Locations.Add(new Field("네번째 필드", "사냥터"));
                Locations.Add(new Dungeon("네번째 던전", "사냥터"));

                Locations.Add(new Village("다섯번째 마을", ""));
                Locations.Add(new Field("다섯번째 필드", "사냥터"));
                Locations.Add(new Dungeon("다섯번째 던전", "사냥터"));
            }            
        }
    }
}