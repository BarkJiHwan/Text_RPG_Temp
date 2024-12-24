using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                    FightSeting();
                    return true;
            }
        }

        static public void HeroesNeverDying(Player player)
        {
            Console.WriteLine("1. 부활");
            Console.WriteLine("2. 죽음");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("");
                    break;
                case "2":
                    Console.WriteLine("");
                    break;
            }
        }

                

        public static void Fight(Player player, Enemy enemy)
        {
            Random Random = new Random();
            Console.WriteLine($"{enemy._Name} 발견 싸우시겠습니까? ");

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
                        if (enemy._Health > 0)
                        {
                            player.Attack(enemy);
                            if (enemy._Health > 0)
                            {
                                enemy.Attack(player);
                                if (player._Health < 0)
                                {
                                    Console.WriteLine("죽었습니다");
                                    Console.WriteLine("부활");

                                }
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
