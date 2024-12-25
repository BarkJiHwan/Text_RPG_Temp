﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Temp
{
    internal class Game
    {
        private Player player;
        public static MapManager map { get; private set; } = new MapManager();
        public static EnemyManager enemy { get; private set; } = new EnemyManager();
        public static Story story { get; private set; } = new Story();
        public Game()
        { 
            
        }
        public void Start()
        {
            story.StratStory();
            Console.WriteLine("1번을 선택할 경우 메인스토리를 따라가게 됩니다.");
            Console.WriteLine("2번을 선택할 경우 당장 메인스토리를 따라갈 수 없지만 분기별로 메인스토리에 접근할 수 있습니다.");
            Console.WriteLine("현재 2번 스토리는 구현되지 않아 2번을 선택 후 촌장집에 가면 메인스토리가 실행됩니다.");
            Console.WriteLine("1. 촌장을 따라 간다, 2. 촌장을 따라가지 않는다., 3. 게임 종료");
            bool start = true;
            while (start)
            {

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("??? : 알겠습니다.");
                        Console.ReadKey(true);
                        Console.WriteLine("마을촌장 : 따라 오게나");
                        Console.ReadKey(true);
                        Console.WriteLine("??? : ...");
                        Console.ReadKey(true);
                        Console.WriteLine("촌장을 따라 마을에 도착할 때 쯤...");
                        Console.ReadKey(true);
                        Console.WriteLine("마을촌장 : 그러고보니 아직 자네 이름을 모르는군 자네의 이름이 뭔가?");
                        Console.WriteLine($"??? : ......!");
                        UserToName();
                        player.Mainstory = true;
                        story.FirstQuarter(player);
                        ((Village)map.Locations[0]).StartingVillage(player,start);
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("??? : 괜찮습니다. 처음보는 장소에서 아무나 믿고 따라 갈수는 없죠");
                        Console.ReadKey(true);
                        Console.WriteLine("마을촌장 : 허허.. 알겠네 나는 여기서 얼마 떨어지지 않은 그린힐 마을의 촌장이라네\n" +
                            "그래도 이곳에는 몬스터들이 없으니 마음이 조금 안정되면 마을에 들러주게나\n" +
                            "내 미리 일러두겠네");
                        Console.ReadKey(true);
                        Console.WriteLine("??? : ...알겠습니다");
                        Console.ReadKey(true);
                        Console.WriteLine("마을촌장 : 아! 그러고보니 자네 이름을 모르는군 자네의 이름이 뭔가?");
                        Console.WriteLine($"??? : 제..이름....");
                        UserToName();
                        story.FirstQuarter2(player);
                        MainLoop(start);
                        start = false;
                        break;
                    case "3":
                        start = false;
                        break;
                    default:
                        Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요.");
                        break;
                }
            }
        }
        public void UserToName()
        {
            Console.WriteLine("??? : \'내 이름이 뭐였지..\'");
            Console.Write("이름을 입력해주세요 : ");
            string playerName = Console.ReadLine();
            while (playerName.Length < 2)
            {
                Console.Write("두글자 이상 입력해 주세요 : ");
                playerName = Console.ReadLine();                
            }
            player = new Player(playerName);            
        }

        public void MainLoop(bool start)
        {
            while (start)
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
                        ((Village)map.Locations[0]).MapNamespace();
                        ((Village)map.Locations[0]).StartingVillage(player,start);
                        break;
                    case "3":                        
                        start = false;
                        Console.WriteLine("게임을 종료합니다. 안녕히가세요.");
                        break ;
                    default:
                        Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요.");                        
                        break;
                }
            }
        }        
    }
}
