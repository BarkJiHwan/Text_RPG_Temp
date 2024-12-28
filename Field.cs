using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextRPGAlancia
{
    
    internal class Field : Location
    {
        private bool FirstFieldEnter = true;
        private bool SecondFieldEnter = true;
        public Field(string name, string description, int maptype) : base(name, description, maptype)
        {            
        }

        public override void MapNamespace()
        { 
            Console.WriteLine($"{Name} , {Description}");
        }

        public void DiscoverDungeon(Player player , bool start, int mapType)
        {
            while (start)
            {
                Eraser.Clear();
                Console.WriteLine("던전을 발견했습니다.\n" +
                    "1. 들어간다, 2. 들어가지 않는다.");
                switch (Console.ReadLine())
                {
                    case "1":
                        if(mapType == 1)
                        {
                            //Quest = mapType; 퀘스트 테이블 추가 예정
                            ((Dungeon)Game.map.Locations[3]).MapNamespace();
                            ((Dungeon)Game.map.Locations[3]).FirstDungeon(player, start, mapType);
                            start = false;
                        }
                        break;
                    case "2":
                        Console.WriteLine("원래의 장소로 돌아갑니다.");  
                        start = false;
                        break;
                    default:
                        Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요.");
                        break;
                }
            }
        }

        public void FirstField(Player player, bool start) //첫번째 필드 (사냥터)
        {
            Eraser.Clear();
            ((Field)Game.map.Locations[2]).MapNamespace();
            if (FirstFieldEnter)
            {
                if (player.Mainstory == true)
                {
                    Game.story.FirstMainStory(player);
                }
                else if (player.Mainstory == false)
                {
                    Game.story.secondMainSkeep2(player);
                }
                FirstFieldEnter = false;
            }
            MapType = 1;
            Random random = new Random();
            while (Game.start)
            {
                Eraser.Clear();
                int rd = random.Next(0, 10); //필드 이동중 1/10확률로 던전에 들어가도록 설정
                Console.WriteLine("이동중..");
                Thread.Sleep(1000);                
                if (rd == 0)
                {
                    DiscoverDungeon(player, start, MapType);
                    FirstField(player, start);
                }
                else
                {
                    Enemy enemyRnadomGet = Game.enemy.EnemyRandomGet(MapType);
                    BattleManager.Fight(player, enemyRnadomGet, start, MapType);
                    while (start)
                    {
                        Console.WriteLine("전투가 끝났습니다. 다음 마을이 보입니다 이동하시겠습니까?");
                        Console.WriteLine("1.스테이터스 확인, 2.인벤토리 확인, 3.장비창 확인\n" +
                            "4.다른 몬스터와 전투, 5.그린힐 마을로 이동, 6.브라이튼 마을로 이동, 7.게임 종료");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                player.PlayerStats();
                                break;
                            case "2":
                                Eraser.Clear();
                                player.playerinventory.SetingItem(player);
                                break;
                            case "3":
                                player.EquimentGetItem(player, start);                                
                                break;
                            case "4":
                                FirstField(player, start);
                                break;
                            case "5":
                                ((Village)Game.map.Locations[1]).MapNamespace();
                                ((Village)Game.map.Locations[1]).StartingVillage(player, start);
                                break;
                            case "6":
                                ((Village)Game.map.Locations[4]).MapNamespace();
                                ((Village)Game.map.Locations[4]).SecondVillage(player, start);
                                break;
                            case "7":
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
        public void SecondField(Player player, bool start) //두번째 필드 (사냥터)
        {            
            MapType = 2;
            Enemy enemyRnadomGet = Game.enemy.EnemyRandomGet(MapType);
            BattleManager.Fight(player, enemyRnadomGet, start , MapType);
            while (Game.start)
            {
                Eraser.Clear();
                Game.map.Locations[5].MapNamespace();
                Console.WriteLine("전투가 끝났습니다. 다음 마을이 보입니다 이동하시겠습니까?");
                Console.WriteLine("1.스테이터스 확인, 2.인벤토리 확인, 3.장비창 확인\n" +
                    "4.다른 몬스터와 전투, 5.브라이튼 마을로 이동, 6.벨 플로라 마을로 이동, 7.게임 종료");
                 switch (Console.ReadLine())
                {
                    case "1":
                        player.PlayerStats();
                        break;
                    case "2":
                        Eraser.Clear();
                        player.playerinventory.SetingItem(player);
                        break;
                    case "3":
                        player.EquimentGetItem(player, start);
                        break;
                    case "4":
                        break;
                    case "5":                        
                        ((Village)Game.map.Locations[4]).SecondVillage(player, start);
                        break;
                    case "6":                        
                        ((Village)Game.map.Locations[7]).ThirdVillage(player, start);
                        break;
                    case "7":
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
