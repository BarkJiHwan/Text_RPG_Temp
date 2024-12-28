using System;
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
        public static ItemManager itemManager { get; private set; } = new ItemManager();
        public static LevelManager levelManager { get; private set; } = new LevelManager();
        public static bool start;
        public Game()
        {
            start = true;
        }
        public void Start()
        {
            
            story.StratStory();
            Console.WriteLine("1. 촌장을 따라 간다, 2. 촌장을 따라가지 않는다., 3. 게임 종료");
            while (start)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        Eraser.Clear();
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
                        ((Village)map.Locations[1]).StartingVillage(player, start);
                        break;
                    case "2":
                        Eraser.Clear();
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
                        ((Village)map.Locations[0]).BeginningVillage(player, start);
                        break;
                    case "3":
                        GameStop();
                        break;
                    default:
                        Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요.");
                        break;
                }
            }
        }
        public void UserToName()
        {
            Console.WriteLine("??? : \'내.. 이름? 이름이 뭐였지?\'");
            Console.Write("이름을 입력해주세요 : ");
            string playerName = Console.ReadLine();
            while (playerName.Length < 2)
            {
                Console.Write("두글자 이상 입력해 주세요 : ");
                playerName = Console.ReadLine();
            }
            player = new Player(playerName);
            Eraser.Clear();
        }

        public static void GameStop()
        {
            Console.WriteLine("정말 게임을 종료 하시겠습니까?");
            Console.WriteLine("1, 게임 종료 2,취소");
            bool stop = true;
            while (stop)
            {
                var userInput = Console.ReadLine();
                if (userInput == "1")
                {                    
                    Console.WriteLine("게임을 종료합니다. 안녕히가세요.");
                    start = false;
                    stop = false;
                }
                else if (userInput == "2")
                {
                    stop = false;
                    Console.WriteLine("게임종료를 취소합니다.\n" +
                        "행동을 선택하세요.");
                }
                else
                {
                    Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요.");
                }
            }
        }
    }
}
