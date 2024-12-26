using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Temp
{
    internal class Dungeon : Location
    {

        public Dungeon(string name, string description, int maptype) : base(name, description, maptype)
        {
        }
        public override void MapNamespace()
        {
            Console.WriteLine($"{Name} , {Description}");
        }

        public void TreasureChest(Player player, int mapType)
        {
            Console.WriteLine("보물상자를 발견했습니다. 상자를 열겠습니까?");
            bool stop = true;
            while (stop)
            {
                Console.WriteLine("1. 상자를 연다, 2. 상자를 버린다.");
                var userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    Random random = new Random();
                    int rd = random.Next(3);
                    if (rd == 0)
                    {
                        Console.WriteLine($"{player.Name} : 뭐야? 아무것도 없잖아");
                        Console.ReadKey(true);
                        Console.WriteLine("상자를 버립니다.");
                        Console.ReadKey(true);
                        Console.WriteLine($"{player.Name} : 던전도 힘든데 운도 없네..");
                        stop = false;
                    }
                    else if (rd == 1)
                    {
                        Console.WriteLine($"아이템을 발견했습니다!");


                    }
                }
                else if (userInput == "2")
                {


                }
                else
                {

                }
            }
        }

        public void FirstDungeon(Player player, bool start, int mapType) //첫번째 던전
        {
            Random random = new Random();
            while (Game.start)
            {
                while (start)
                {
                    Enemy enemyRnadomGet = Game.enemy.EnemyRandomGet(MapType);
                    BattleManager.Fight(player, enemyRnadomGet, start);
                    int rd = random.Next(0, 1);
                    Console.WriteLine("퀘스트 내용");// 추가해야 됨, 던전마다 퀘스트 변경 됨
                    Console.WriteLine("퀘스트 진행상황 ?/?");
                    Console.WriteLine("던전 탐험중..");
                    Thread.Sleep(1000);
                    if (rd == 0)
                    {
                        Console.WriteLine("보물상자를 발견했습니다~");
                        //보물상자 로직추가
                        //보물상자를 열겠습니까?
                        //연다. 꽝,아이템,몬스터
                        //꽝일 경우 다시 던전 탐험
                        //아이템 일경우 1타입 던전이라면 각 아이템별 0~4아이템 중 랜덤으로 한개를 인벤토리로 넣어준다
                        //몬스터라면? 해당 던전의 몬스터 등장~
                        //안연다, 다시 던전 탐험 진행
                    }
                    else
                    {
                        Console.WriteLine("전투가 끝났습니다. 무엇을 하시겠습니까?");
                        Console.WriteLine("1.스테이터스 확인, 2.다른 몬스터와 전투, 3.게임 종료");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                player.PlayerStats();
                                break;
                            case "2":
                                Console.WriteLine("다음몬스터 탐색");
                                break;
                            case "3":
                                start = false;
                                Game.GameStop();
                                break;
                            default:
                                Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요."); //전투를 시작하지 않음 처리 3번과 동일한 상황                    
                                break;
                        }
                    }
                }
            }
        }
    }
        //Console.WriteLine("던전이다..."); //던전 설명

        //    //몬스터와 만남 메서드
            
        //    Console.WriteLine("몬스터와 전투를 합니다. 투닥투닥...."); //전투 관련 메서드 추가

        //    Console.WriteLine("전투가 끝났습니다.");

        //    Console.WriteLine("보물상자가 나타났다!"); //던전은 파밍이 가능하다는 것을 알려줌
        //    Console.WriteLine("보물상자에서 몬스터가 나왔다"); //랜덤 + if문 처리

        //    Console.WriteLine("던전의 보스가 나타났다!"); //몬스터 몇마리 잡았을 경우 또는 그냥 랜덤으로 설정 고민중

        //    Console.WriteLine("던전의 보스를 처치했다..."); //원래 있던 필드로 이동 하기. 

        
}
