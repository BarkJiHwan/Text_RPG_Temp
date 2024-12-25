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
                Locations.Add(new Village("그린힐", "낯선 풍경이지만 왠지 익숙한 느낌이 든다."));//0
                Locations.Add(new Field("초원", "넓은 초원으로 다양한 몬스터들이 보인다."));//1
                Locations.Add(new Dungeon("공동묘지", "오랜시간 관리가 되지 않은 것 같다..."));//2

                Locations.Add(new Village("브라이튼", "마을 전체가 활기찬 에너지를 풍긴다. 마을 중심에 넓은 광장보인다."));//3
                Locations.Add(new Field("대평원", "그린힐의 초원이 작게 느껴질법한 평원이다.."));//4
                Locations.Add(new Dungeon("두번째 던전",""));//5

                Locations.Add(new Village("벨 플로라 마을", "아름다운 꽃들로 뒤덮인 평화로운 마을이다."));//6
                Locations.Add(new Field("플로럴 밸리", "꽃처럼 보이는 무언가가 계속 꿈틀거린다..."));//7
                Locations.Add(new Dungeon("세번째 던전", "사냥터"));//8

                Locations.Add(new Village("네번째 마을", ""));//9
                Locations.Add(new Field("네번째 필드", "사냥터"));//10
                Locations.Add(new Dungeon("네번째 던전", "사냥터"));//11

                Locations.Add(new Village("다섯번째 마을", ""));//12
                Locations.Add(new Field("다섯번째 필드", "사냥터"));//13
                Locations.Add(new Dungeon("다섯번째 던전", "사냥터"));//14
            }
            
        }
    }
}