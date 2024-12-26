using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Temp
{
    static class BattleManager
    {        
        static public bool FightSeting()
        {
            bool isFighting;
            Console.WriteLine("1. 싸운다.");
            Console.WriteLine("2. 도망간다.");
            switch (Console.ReadLine())
            {
                case "1":
                    
                    return isFighting = true;
                case "2":

                    return isFighting = false; ;
                default:
                    Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요.");
                    return FightSeting();
            }
        }

        static public void HeroesNeverDying(Player player)
        {
            Console.WriteLine("1. 부활");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("부활합니다. ");

                    break;                
                
            }
        }

        public static void Fight(Player player, Enemy enemy ,bool start)
        {
            Random Random = new Random();
            Console.WriteLine($"{enemy.Name} 발견 싸우시겠습니까? ");

            bool isFighting = BattleManager.FightSeting();
            
            while (isFighting)
            {
                enemy.EnemyDisplayStats();
                Console.WriteLine("1. 공격한다.");
                Console.WriteLine("2. 인벤토리 확인.");
                Console.WriteLine("3. 상태창 확인.");
                Console.WriteLine("4. 도망간다.");
                switch (Console.ReadLine())
                {
                    case "1":                        
                        if (enemy.Health > 0)
                        {
                            player.Attack(enemy);
                            if (enemy.Health > 0)
                            {
                                enemy.Attack(player);
                                if (player.Health < 0)
                                {
                                    Console.WriteLine("당신은 죽었습니다");
                                    Console.WriteLine("3초 후 태초의 장소에서 부활합니다.");
                                    Console.WriteLine("3...");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("2...");
                                    Console.WriteLine("소지금의 절반을 몬스터가 훔쳐갑니다.");
                                    player.Gold = player.Gold / 2;
                                    Thread.Sleep(1000);
                                    Console.WriteLine("1... \t");
                                    Thread.Sleep(1000);
                                    ((Village)Game.map.Locations[0]).BeginningVillage(player,start);
                                }
                            }
                            else
                            {
                                Console.WriteLine("승리");
                                player.Exp += enemy.Exp;
                                player.Gold += enemy.Gold;
                                Console.WriteLine($"경험치 :{enemy.Exp}획득, 골드: {enemy.Gold}획득,");
                                isFighting = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("승리");
                            player.Exp += enemy.Exp;
                            player.Gold += enemy.Gold;
                            Console.WriteLine($"경험치 :{enemy.Exp}획득, 골드: {enemy.Gold}획득,");
                            isFighting = false;
                        }
                        break;

                    case "2":
                        Console.WriteLine("인벤토리 메소드 호출");
                        break;

                    case "3":
                        player.PlayerStats();                        
                        break;

                    case "4":
                        int Avoid = Random.Next(3);
                        if (Avoid == 0)
                        {
                            enemy.Attack(player);
                            Console.WriteLine("도망가는 도중 적에게 공격당했습니다.");
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
