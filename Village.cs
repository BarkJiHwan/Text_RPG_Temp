using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    internal class Village : Location
    {
        
        public Village(string name, string description) : base(name, description)
        {
            
        }        

        public override void MapNamespace()
        {
            Console.WriteLine($"{Name} , {Description}");
        }

        public void StartingVillage(Player player) // 게임 시작 첫번째 빌리지(마을)
        {
            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine("1.촌장의 집으로 이동");
            Console.WriteLine("2.초원으로 이동");
            Console.WriteLine("3.상점으로 이동");
            Console.WriteLine("4.메인으로 이동");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("촌장님"); //NPC + 퀘스트 관련 내용 추가 해야 됨
                    StartingVillage(player);
                    break;
                case "2":
                    ((Field)Game.map.Locations[1]).MapNamespace();
                    ((Field)Game.map.Locations[1]).OneField(player);
                    break;
                case "3":
                    Console.WriteLine("상점");
                    StartingVillage(player); // 상점 추가해야 됨
                    break;
                case "4":
                    Console.WriteLine("메인"); //리턴 말고 다른 방법을 찾아야 겠음
                    return;
                default:
                    Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요.");
                    StartingVillage(player);
                    break;
            }
        }
        public void SecondVillage(Player player) // 게임 시작 첫번째 빌리지(마을)
        {            
            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine("1.촌장의 집으로 이동");
            Console.WriteLine("2.초원으로 이동");
            Console.WriteLine("3.상점으로 이동");
            Console.WriteLine("4.분수대로 이동");
            Console.WriteLine("5.대평원으로 이동");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("촌장님"); //NPC + 퀘스트 관련 내용 추가 해야 됨
                    SecondVillage(player);
                    break;
                case "2":
                    ((Field)Game.map.Locations[1]).MapNamespace();
                    ((Field)Game.map.Locations[1]).OneField(player);                    
                    break;
                case "3":
                    Console.WriteLine("상점");
                    SecondVillage(player);
                    break;
                case "4":
                    Console.WriteLine("상점");
                    SecondVillage(player);
                    break;
                case "5":
                    ((Field)Game.map.Locations[3]).MapNamespace();
                    ((Field)Game.map.Locations[3]).OneField(player);
                    break;
                default:
                    Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요.");                    
                    break;
            }
        }
    }
}
