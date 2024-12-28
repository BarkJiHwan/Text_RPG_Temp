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

        public void TreasureChest(Player player, int mapType) //보물 상자 발견 했다면에 대한 행동(던전에서만 쓰일 기능)
        {
            Console.WriteLine("보물상자를 발견했습니다. 상자를 열겠습니까?");
            bool stop = true;
            while (stop)
            {
                Console.WriteLine("1. 상자를 연다, 2. 무시한다., 3.던전 탈출하기");
                var userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    Random random = new Random();
                    int rd = random.Next(15);
                    if (rd > 10)
                    {
                        Console.WriteLine($"{player.Name} : 뭐야? 아무것도 없잖아");
                        Console.ReadKey(true);
                        Console.WriteLine("상자를 버립니다.");
                        Console.ReadKey(true);
                        Console.WriteLine($"{player.Name} : 이번엔 운이 없네..");
                        stop = false;
                    }
                    else if (rd < 5)
                    {
                        Console.WriteLine($"아이템을 발견했습니다!");
                        Game.itemManager.ItemRooting(player, mapType);
                        stop = false;
                    }
                    else
                    {
                        Console.WriteLine("상자의 함정이 발동합니다");
                        Console.WriteLine("몬스터가 소환됩니다.");
                        Enemy enemyRnadomGet = Game.enemy.EnemyRandomGet(MapType);
                        BattleManager.Fight(player, enemyRnadomGet, stop, MapType);
                        stop = false;
                    }
                }
                else if (userInput == "2")
                {
                    Console.WriteLine($"{player.Name} : 저 보물상자는 수상해 보이는군..");
                    Console.ReadKey(true);
                    stop = false;
                }

                else if (userInput == "3")
                {
                    Console.WriteLine("던전을 나옵니다.");
                    ((Field)Game.map.Locations[2]).FirstField(player, stop);
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
                Eraser.Clear();
                Game.map.Locations[3].MapNamespace();
            while (Game.start)
            {
                while (start)
                {                    
                    //Console.WriteLine("퀘스트 내용");// 추가해야 됨, 던전 인덱스 마다 퀘스트 변경//할시간 없음
                    //Console.WriteLine("퀘스트 진행상황 ?/?");
                    Console.WriteLine("던전 탐험중..");
                    Thread.Sleep(1000);

                    int rd = random.Next(10); //던전 탐험중 1/10 확률로 보물상자를 발견
                    if (rd == 0) //보물상자 발견
                    {
                        TreasureChest(player, mapType);
                    }
                    else
                    {
                        Enemy enemyRnadomGet = Game.enemy.EnemyRandomGet(MapType);
                        BattleManager.Fight(player, enemyRnadomGet, start, MapType);
                    }
                    Console.WriteLine("전투가 끝났습니다. 무엇을 하시겠습니까?");
                    Console.WriteLine("1.스테이터스 확인, 2.인벤토리 확인, 3.장비창 확인\n" +
                       "4.이동하기, 5.던전 탈출하기 6.게임 종료");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            player.PlayerStats();
                            Console.ReadKey(true);
                            break;
                        case "2":
                            player.PrintInven();
                            player.playerinventory.SetingItem(player);
                            break;
                        case "3":
                            player.EquimentGetItem(player, start);
                            break;
                        case "4":
                            break;
                        case "5":
                            Console.WriteLine("던전을 나옵니다.");
                            ((Field)Game.map.Locations[2]).FirstField(player, start);
                            break;
                        case "6":
                            start = false;
                            Game.GameStop();
                            break;
                        default:
                            Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요."); //전투를 시작하지 않음 처리 3번과 동일한 상황//반복문에 넣음          
                            break;
                    }
                    Eraser.Clear();
                }
            }
        }
    }
}
        //Console.WriteLine("던전이다..."); //던전 설명

        //    //몬스터와 만남 메서드 /완료
            
        //    Console.WriteLine("몬스터와 전투를 합니다. 투닥투닥...."); //전투 관련 메서드 추가 /완료

        //    Console.WriteLine("전투가 끝났습니다.");

        //    Console.WriteLine("보물상자가 나타났다!"); //던전은 파밍이 가능하다는 것을 알려줌 //파밍 바꿈
        //    Console.WriteLine("보물상자에서 몬스터가 나왔다"); //랜덤 처리 //완료

        //    Console.WriteLine("던전의 보스가 나타났다!"); //몬스터 몇마리 잡았을 경우 또는 그냥 랜덤으로 설정 고민중 //할시간없음

        //    Console.WriteLine("던전의 보스를 처치했다..."); //원래 있던 필드로 이동 하기. //할시간없음

        
