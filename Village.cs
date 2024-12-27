using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Temp
{
    internal class Village : Location
    {
        public Village(string name, string description, int maptype) : base(name, description, maptype)
        {
        }

        public override void MapNamespace()
        {
            Console.WriteLine($"{Name} , {Description}");
        }

        public void BeginningVillage(Player player,bool start)
        {
            while (Game.start)
            {
                Console.WriteLine("\n무엇을 하시겠습니까?");
                Console.WriteLine("1. 캐릭터 정보 확인");
                Console.WriteLine("2. 마을 이동");
                Console.WriteLine("3. 게임 종료");
                switch (Console.ReadLine())
                {
                    case "1":
                        player.PlayerStats();
                        break;
                    case "2":
                        Game.map.Locations[1].MapNamespace();
                        StartingVillage(player, start);                        
                        break;
                    case "3":
                        Game.GameStop();                        
                        break;
                    default:
                        Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요.");
                        break;
                }
            }
        }
        public void StartingVillage(Player player, bool start) // 그린힐 마을
        {            
            while (Game.start)
            {
                Console.WriteLine("무엇을 하시겠습니까?");
                Console.WriteLine("1.스테이터스 확인, 2.인벤토리 확인, 3.촌장의 집으로 이동\n" +
                "4.상점으로 이동, 5.초원으로 이동, 6.게임 종료");
                switch (Console.ReadLine())
                {
                    case "1":
                        player.PlayerStats();
                        break;
                    case "2":
                        player.PrintInven();
                        break;
                    case "3":
                        Console.WriteLine("촌장님"); //NPC + 퀘스트 관련 내용 추가 해야 됨                        
                        break;
                    case "4":
                        Console.WriteLine("상점"); //분수대 추가해야 됨                        
                        break;
                    case "5":
                        ((Field)Game.map.Locations[2]).MapNamespace();
                        ((Field)Game.map.Locations[2]).FirstField(player, start);
                        break;
                    case "6":
                        Game.GameStop();
                        break;
                    default:
                        Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요.");
                        break;
                }
            }
        }
        public void SecondVillage(Player player, bool start) // 브라이튼 마을
        {
            
            while (Game.start)
            {
                Console.WriteLine("1.스테이터스 확인, 2.촌장의 집으로 이동, 3.상점으로 이동\n" +
                "4.분수대로 이동, 5.초원으로 이동, 6.대편원으로 이동 7.게임 종료");
                switch (Console.ReadLine())
                {
                    case "1":
                        player.PlayerStats();
                        break;
                    case "2":
                        Console.WriteLine("촌장님");
                        break;
                    case "3":
                        Console.WriteLine("상점");
                        break;
                    case "4":
                        Console.WriteLine("분수대");
                        break;
                    case "5":
                        ((Field)Game.map.Locations[2]).MapNamespace();
                        ((Field)Game.map.Locations[2]).FirstField(player, start);
                        break;
                    case "6":
                        ((Field)Game.map.Locations[5]).MapNamespace();
                        ((Field)Game.map.Locations[5]).SecondField(player, start);
                        break;
                    case "7":
                        Game.GameStop();
                        break;
                    default:
                        Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요.");
                        break;
                }
            }
        }
        public void ThirdVillage(Player player, bool start) // 벨 플로라 마을
        {            
            while (Game.start)
            {
                Console.WriteLine("1.스테이터스 확인, 2.촌장의 집으로 이동, 3.상점으로 이동\n" +
                "4.분수대로 이동, 5.대평원으로 이동, 6.플로럴 밸리로 이동 7.게임 종료");
                switch (Console.ReadLine())
                {
                    case "1":
                        player.PlayerStats();
                        break;
                    case "2":
                        Console.WriteLine("촌장님");
                        break;
                    case "3":
                        Console.WriteLine("상점");
                        break;
                    case "4":
                        Console.WriteLine("분수대");
                        break;
                    case "5":
                        ((Field)Game.map.Locations[5]).MapNamespace();
                        ((Field)Game.map.Locations[5]).FirstField(player, start);
                        break;
                    case "6":
                        ((Field)Game.map.Locations[8]).MapNamespace();
                        ((Field)Game.map.Locations[8]).SecondField(player, start);
                        break;
                    case "7":
                        Game.GameStop();
                        break;
                    default:
                        Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요.");
                        break;
                }
            }
        }
        public void FourthVillage(Player player, bool start) // 네번째 마을
        {
            
            while (Game.start)
            {
                Console.WriteLine("1.스테이터스 확인, 2.촌장의 집으로 이동, 3.상점으로 이동\n" +
                "4.분수대로 이동, 5.플로럴 밸리로 이동, 6.네번째필드로 이동 7.게임 종료");
                switch (Console.ReadLine())
                {
                    case "1":
                        player.PlayerStats();
                        break;
                    case "2":
                        Console.WriteLine("촌장님");
                        break;
                    case "3":
                        Console.WriteLine("상점");
                        break;
                    case "4":
                        Console.WriteLine("분수대");
                        break;
                    case "5":
                        ((Field)Game.map.Locations[8]).MapNamespace();
                        ((Field)Game.map.Locations[8]).FirstField(player, start);
                        break;
                    case "6":
                        ((Field)Game.map.Locations[11]).MapNamespace();
                        ((Field)Game.map.Locations[11]).SecondField(player, start);
                        break;
                    case "7":
                        Game.GameStop();
                        break;
                    default:
                        Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요.");
                        break;
                }
            }
        }
        public void FifthVillage(Player player, bool start) // 다섯번째 마을
        {           
            while (Game.start)
            {
                Console.WriteLine("1.스테이터스 확인, 2.촌장의 집으로 이동, 3.상점으로 이동\n" +
                "4.분수대로 이동, 5.네번째필드로 이동, 6.다섯번째필드로 이동 7.게임 종료");
                switch (Console.ReadLine())
                {
                    case "1":
                        player.PlayerStats();
                        break;
                    case "2":
                        Console.WriteLine("촌장님");
                        break;
                    case "3":
                        Console.WriteLine("상점");
                        break;
                    case "4":
                        Console.WriteLine("분수대");
                        break;
                    case "5":
                        ((Field)Game.map.Locations[11]).MapNamespace();
                        ((Field)Game.map.Locations[11]).FirstField(player, start);
                        break;
                    case "6":
                        ((Field)Game.map.Locations[14]).MapNamespace();
                        ((Field)Game.map.Locations[14]).SecondField(player, start);
                        break;
                    case "7":
                        Game.GameStop();
                        break;
                    default:
                        Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요.");
                        break;
                }
            }
        }
    }
}