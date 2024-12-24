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
        public static MapManager map {  get; private set;} = new MapManager();
        public static EnemyManager enemy { get; private set;} = new EnemyManager();
        
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
                        Console.WriteLine("시작의 마을, 낯선 풍경이지만 왠지 익숙한 느낌이 든다.");
                        map.Village.StartingVillage(player);
                        break;
                    case "2":
                        player.PlayerStats();
                        MainLoop();
                        break;
                    case "3":
                        Console.WriteLine("게임을 종료합니다. 안녕히가세요.");
                        return;
                    default:
                        Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요.");
                        MainLoop();
                        break;
                }
            }
        }        
        public void GoToField(Player player)
        {
            map.field.OneField(player);
        }
        public static void Fight(Player player, Enemy enemy)
        {
            Random Random = new Random();
            Console.WriteLine($"{enemy._Name} 발견 싸우시겠습니까? ");
            bool isFighting = true;
            while (isFighting)
            {
                Console.WriteLine("1. 싸운다.");
                Console.WriteLine("2. 도망간다.");
                switch (Console.ReadLine())
                {
                    case "1":
                        enemy.EnemyDisplayStats();
                        if (enemy._Health > 0)
                        {
                            player.Attack(enemy);
                            if (enemy._Health > 0)
                            {
                                enemy.Attack(player);
                            }
                            else
                            {
                                Console.WriteLine("승리");
            
                                player._Exp += enemy._Exp;
                                player._Gold += enemy._Gold;
                                Console.WriteLine($"경험치 :{enemy._Exp}획득, 골드: {enemy._Gold}획득,");
                                isFighting = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("승리");
                            player._Exp += enemy._Exp;
                            player._Gold += enemy._Gold;
                            Console.WriteLine($"경험치 :{enemy._Exp}획득, 골드: {enemy._Gold}획득,");
                            isFighting=false;
                        }
                        break;
                    case "2":
                        int Avoid = Random.Next(3);
                        if (Avoid == 0)
                        {
                            player._Health -= 10;
                            Console.WriteLine("도망에 성공했지만 체력이 감소했습니다.");
                            isFighting = false;
                        }
                        else
                        {
                            Console.WriteLine("성공적으로 도망쳤습니다.");
                            isFighting = false;
                        }                        
                        break;
                    default:
                        Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요.");
                        break;
                }
            }
        }
    }
}