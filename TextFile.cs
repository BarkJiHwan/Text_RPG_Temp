﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGAlancia
{
    internal class TextFile
    {
        //게임 종류 Text RPG(다크판타지 장르)

        //게임 진행 유도
        //게임 시작 > 1번마을 > 촌장에게 퀘스트 받음 > 필드 > 던전 > 퀘스트 완료 > 다음 퀘스트 진행
        //2번 마을 > 퀘스트 완료 > 다음 퀘스트 > 특정 레벨 달성시 오픈(성장 유도) > 다음 퀘스트 >..... 반복

        //유저의 선택을 존중, 하지만 bool문을 사용하여 플레이어의 선택에 따른 대가를 받음
        //예시, 1번 마을 퀘스트 완료 후 2번 마을에서 퀘스트를 성공시키지 못했다면 다시 1번 마을로 이동해서 퀘스트를 새로 완료하게 함
        //퀘스트 선택을 유연하게 단, 퀘스트의 보상은 없음, 유저에게 모든 부담을 주게 함
        //퀘스트가 없어도 진행은 가능하도록 설계
        //예시, 1번마을 퀘스트 > 2번 마을에서 퀘스트완료 > 다음 퀘스트를 받지 않음 > NPc의 떨떠름한 반응 + 이어서 진행 하려면 처음부터 진행을 하라는 말을 해줌
        //bool문을 통해 유저의 퀘스트 상황 변환, 단, 이럴 경우 다음다음의 퀘스트를 진행할 수 있는 결과가 나올 수 있기 때문에(버그)
        //해당 관련 처리를 확실하게 해야 됨 각각의 메서드를 따로 나누면서 bool문도 각각 적용..? 쓸대없는 불문이 많이 나올 것 같음 생각해 보자
        
        //운적 요소 던전에 보물상자를 추가 다양한 아이템을 획득 할 수 있도록 한다.
        //단, 특정 몬스터를 제외한 일부 몬스터들은 아이템을 주지 않음
        //파밍은 오로지 던전에서만 랜덤으로 보물상자 출혈 > 보물상자 꽝 or 당첨 등의 운적 요소 추가

        //몬스터 처치로 얻는 골드의 양을 낮추고 물약의 값을 비싸게 해서 유저의 성장을 억제함으로 일정 수준의 난이도를 주어 플레이타임을 증가킴
        //단, 특정 지점에서 머물 경우 일정 시간마다 체력과 마력을 회복할 수 있도록 추가 (강제로 플레이타임을 추가로 증가시킴)
        //몹 처치 후 레벨업 과정에서 체력과 마력을 모두 회복시켜 줄 수 있도록 하는 것도 추가해야 됨 LevelUp event 등..
        //델리게이트도 써야되나..? 아직 잘 모르는데 추후 추가해보자
        //하나의 재미요소, 경험치를 계산해서 최적의 레벨링 루트를 유저가 정할 수 있도록 함
        //스테이터스를 계속 확인하도록 유도할 것인지(난이도 추가 상승) 
        //스테이터스를 특정 위치에 계속 공계를 하는게 나을지(난이도 하락)
        //전자가 나을듯 하긴한데.. 고민해 봐야겠음

        //스킬 관련
        //1. 상점에서 스킬을 구매?
        //안그래도 돈이 부족할 텐데 장비 사랴 물약 사랴... 애매함
        //2. 특정 레벨에 자동으로 획득하도록 로직을 추가??
        //스킬을 List에 담아 if문에 특정 레벨 달성 (예시 : n레벨 마다 스킬 랜덤 뽑기) for문을사용하여 List에 있는 것을 반환 반환한걸 줌..
        //이미 동일한 스킬을 가지고 있다면?
        //List에서 제거 후 다시 돌려 > 따란~ 스킬을 획득했습니다~
        //(유저에게 선물같은 이벤트가 될 거임)
        //3. 특정 Npc에게 스킬을 받음??? > 퀘스트로? 아니면 뭐... NPC가 더 추가될거 같음 그냥 2번 로직 만드는게 쉬울지도..
        //세개를 다 넣으면 좋겠지만 작업량이 기하급수 적으로 많아 질듯..
        //고민을 더 해봐야할 것 같음.

        //Npc 관련 
        //해당 맵에 도착하면 유저는 두가지 선택을 할 수 있다.
        //돌아간다?
        //npc와 대화한다.
        //대화를 진행할 경우 관련 메소드를 호출
        //상점인지 퀘스트인지 다른 무엇인지 제작 할지 고민

        //몬스터 전투 관련 - 완료
        //턴제가 좋을 듯 함 - 완료
        //대신 유저가 무조건 선공을 할 수 있도록함 - 완료

        //골드 파밍 후 좋은 장비 아이템 구매가 유리하다고 인식 시킨 상태로 노가다를 유도하여 플레이타임 증가시킴
        //각 상점마다 동일한 아이템을 판매할지 지역마다 다르게 할지 고민해 봐야 겠음

        
        //인벤토리...
        //유저 아이템 장착 관련 처리

    }
}
