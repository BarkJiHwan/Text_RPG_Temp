using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    internal class Game
    {
        private Player player;
        public static MapManager map { get; private set; } = new MapManager();
        public static EnemyManager enemy { get; private set; } = new EnemyManager();
        

        public Game()
        {
            
        }
        public void Start()
        {
            Console.WriteLine("[RPG 세계]에 오신 것을 환영합니다!");
            Console.Write("플레이어 이름을 입력하세요: ");
            string playerName = Console.ReadLine();
            player = new Player(playerName);
            Console.WriteLine($"환영합니다 {player._Name}님");
            
            MainLoop();
        }
        public void MainLoop()
        {
            while (true)
            {
                Console.WriteLine("\n무엇을 하시겠습니까?");
                Console.WriteLine("1. 마을 이동");
                Console.WriteLine("2. 캐릭터 정보 확인");
                Console.WriteLine("3. 게임 종료");
                switch (Console.ReadLine())
                {
                    case "1":
                        ((Village)map.Locations[0]).MapNamespace();
                        //클래스 형변환 이렇게도 할 수 있다는 것을 알았다.
                        ((Village)map.Locations[0]).StartingVillage(player);
                        break;
                    case "2":
                        player.PlayerStats();
                        break;
                    case "3":                        
                        Console.WriteLine("게임을 종료합니다. 안녕히가세요.");                        
                        return;
                    default:
                        Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요.");                        
                        break;
                }
            }
        }        
    }
}
