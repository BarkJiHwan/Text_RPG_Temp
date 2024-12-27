using System;
using System.Collections;
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
                Console.WriteLine("1. 상자를 연다, 2. 무시한다.");
                var userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    Random random = new Random();
                    int rd = random.Next(5);
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
                        Game.itemManager.ItemRooting(player, mapType);
                        stop = false;
                    }
                    else
                    {
                        Console.WriteLine("함정이 발동합니다");
                        Console.WriteLine("몬스터가 소환됩니다.");
                        Enemy enemyRnadomGet = Game.enemy.EnemyRandomGet(MapType);
                        BattleManager.Fight(player, enemyRnadomGet, stop);
                        stop = false;
                    }
                }
                else if (userInput == "2")
                {
                    Console.WriteLine($"{player.Name} : 저 보물상자는 수상해 보인다.");
                    Console.WriteLine($"스페이스바{Console.ReadKey(true)}");
                    ;
                    stop = false;
                }
                else
                {
                    Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요.");
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
                    Console.WriteLine("퀘스트 내용");// 추가해야 됨, 던전마다 퀘스트 변경 됨
                    Console.WriteLine("퀘스트 진행상황 ?/?");
                    Console.WriteLine("던전 탐험중..");
                    Thread.Sleep(1000);

                    int rd = random.Next(0, 4);
                    if (rd == 0) //보물상자 발견 메서드
                    {
                        TreasureChest(player, mapType);
                    }
                    else
                    {
                        Enemy enemyRnadomGet = Game.enemy.EnemyRandomGet(MapType);
                        BattleManager.Fight(player, enemyRnadomGet, start);
                        Console.WriteLine("전투가 끝났습니다. 무엇을 하시겠습니까?");
                        Console.WriteLine("1.스테이터스 확인, 2.이동하기, ,3.던전 탈출하기  4.게임 종료");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                player.PlayerStats();
                                break;
                            case "2":
                                break;
                            case "3":
                                ((Field)Game.map.Locations[2]).FirstField(player, start);
                                break;
                            case "4":
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
