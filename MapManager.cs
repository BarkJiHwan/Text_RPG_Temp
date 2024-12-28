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
                Locations.Add(new Village("그린힐동산", "이곳에 처음 전이된 곳이다.",0));//0
                Locations.Add(new Village("그린힐 마을", "낯선 풍경이지만 왠지 익숙한 느낌이 든다.",1));//1
                Locations.Add(new Field("초원", "넓은 초원으로 다양한 몬스터들이 보인다.",1));//2
                Locations.Add(new Dungeon("공동묘지", "오랜시간 관리가 되지 않은 것 같다...",1));//3

                Locations.Add(new Village("브라이튼 마을", "마을 전체가 활기찬 에너지를 풍긴다. 마을 중심에 넓은 광장보인다.",2));//4
                Locations.Add(new Field("대평원", "그린힐의 초원이 작게 느껴질법한 평원이다..",2));//5
                Locations.Add(new Dungeon("오크군락지", "강력한 오크들이 거주하는 마을이다...", 2));//6

                Locations.Add(new Village("벨 플로라 마을", "아름다운 꽃들로 뒤덮인 평화로운 마을이다.",3));//7
                Locations.Add(new Field("플로럴 밸리", "꽃처럼 보이는 무언가가 계속 꿈틀거린다...", 3));//8
                Locations.Add(new Dungeon("포식자의 동굴", "무성한 덩굴 사이로 아름다운 꽃밭이 보인다. 약간 달콤한 냄새가 나는 것 같다..", 3));//9

                Locations.Add(new Village("크림슨포트 마을","붉은 벽돌 성곽으로 둘러싸인 견고해 보이는 성이다.", 4));//10
                Locations.Add(new Field("다크우드 포레스트", "어둠의 마법이 짖게 깔린 숲이다.. 몬스터들의 괴성이 들린다.", 4));//11
                Locations.Add(new Dungeon("실종 된 마법사의 집", "옛 날에 실종 된 마법사의 집이다. 지하로 내려가는 입구가 있다..",4));//12

                Locations.Add(new Village("솔라템플 마을","마을 중앙에 웅장한 신전이 빛을 밝히는 신성한 마을이다.",5));//13
                Locations.Add(new Field("최후의 격전지", "끝없이 쏟아지는 몬스터들..",5));//14
                Locations.Add(new Dungeon("소환진", "이곳에서 몬스터들이 계속 소환되고 있다..",5));//15
            }            
        }
    }
}