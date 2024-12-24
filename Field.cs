using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    
    internal class Field : Location
    {
        public Field(string name, string description) : base(name, description)
        {
        }

        public override void MapNamespace()
        { 
            Console.WriteLine($"{Name} , {Description}");
        }

        public void OneField(Player player) //첫번째 필드 (사냥터)
        {            
            //Console.WriteLine("초원입장 푸른 초원 위로 다양한 몬스터들이 보인다.");
            
            Enemy enemyRnadomGet = Game.enemy.EnemyRandomGet();

            BattleManager.Fight(player, enemyRnadomGet);

            Console.WriteLine("전투가 끝났습니다. 다음 마을이 보입니다 이동하시겠습니까?");
            Console.WriteLine("1.다음 마을로 이동");
            Console.WriteLine("2.이전 마을로 이동");
            Console.WriteLine("3.이동하지 않는다.");
            Console.WriteLine("4.스테이터스 확인");
            switch (Console.ReadLine())
            {
                case "1":                    
                    Console.WriteLine("전투 종료");
                    ((Village)Game.map.Locations[3]).MapNamespace();
                    ((Village)Game.map.Locations[3]).SecondVillage(player);
                    break;
                case "2":
                    ((Village)Game.map.Locations[0]).MapNamespace();
                    ((Village)Game.map.Locations[0]).StartingVillage(player);
                    break;
                case "3":
                    OneField(player);//다시 전투 시작 처리
                    break;
                case "4":
                    player.PlayerStats();
                    OneField(player);
                    break;
                default:
                    Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요."); //전투를 시작하지 않음 처리 3번과 동일한 상황
                    OneField(player);
                    break;
            }
        }
    }
}
