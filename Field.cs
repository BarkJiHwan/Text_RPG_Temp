using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Temp
{
    
    internal class Field : Location
    {
        public int FieldNumber { get; protected set; }
        public Field(string name, string description) : base(name, description)
        {
            FieldNumber = 0;
        }

        public override void MapNamespace()
        { 
            Console.WriteLine($"{Name} , {Description}");
        }

        public void FirstField(Player player,bool start) //첫번째 필드 (사냥터)
        {
            FieldNumber = 1;
            Enemy enemyRnadomGet = Game.enemy.EnemyRandomGet(FieldNumber);
            BattleManager.Fight(player, enemyRnadomGet);
            while (enemyRnadomGet != null)
            {
                Console.WriteLine("전투가 끝났습니다. 다음 마을이 보입니다 이동하시겠습니까?");
                Console.WriteLine("1.스테이터스 확인, 2.그린빌 마을로 이동");
                Console.WriteLine("3.브라이튼 마을로 이동, 4.다른 몬스터와 전투, 5.게임 종료");
                switch (Console.ReadLine())
                {
                    case "1":
                        player.PlayerStats();
                        break;
                    case "2":
                        ((Village)Game.map.Locations[0]).MapNamespace();
                        ((Village)Game.map.Locations[0]).StartingVillage(player, start);
                        break;
                    case "3":
                        ((Village)Game.map.Locations[3]).MapNamespace();
                        ((Village)Game.map.Locations[3]).SecondVillage(player, start);
                        break;
                    case "4":
                        FirstField(player, start);
                        break;
                    case "5":
                        start = false;
                        break;
                    default:
                        Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요."); //전투를 시작하지 않음 처리 3번과 동일한 상황                    
                        break;
                }
            }
        }
        public void SecondField(Player player, bool start) //두번째 필드 (사냥터)
        {
            FieldNumber = 2;
            Enemy enemyRnadomGet = Game.enemy.EnemyRandomGet(FieldNumber);
            BattleManager.Fight(player, enemyRnadomGet);
            while (enemyRnadomGet != null)
            {
                Console.WriteLine("전투가 끝났습니다. 다음 마을이 보입니다 이동하시겠습니까?");
                Console.WriteLine("1.스테이터스 확인, 2.브라이튼 마을로 이동\n" +
                    "3.벨 플로라 마을로 이동, 4.다른 몬스터와 전투, 5.게임 종료");
                switch (Console.ReadLine())
                {
                    case "1":
                        player.PlayerStats();
                        break;
                    case "2":
                        ((Village)Game.map.Locations[3]).MapNamespace();
                        ((Village)Game.map.Locations[3]).SecondVillage(player, start);
                        break;
                    case "3":
                        ((Village)Game.map.Locations[6]).MapNamespace();
                        ((Village)Game.map.Locations[6]).SecondVillage(player, start);
                        break;
                    case "4":
                        SecondField(player, start);
                        break;
                    case "5":
                        start = false;
                        break;
                    default:
                        Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요."); //전투를 시작하지 않음 처리 3번과 동일한 상황                    
                        break;
                }
            }
        }
    }
}
