using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Temp
{
    internal class Dungeon : Location
    {

        public Dungeon(string name, string description) : base(name, description)
        {
        }
        public override void MapNamespace()
        {
            Console.WriteLine($"{Name} , {Description}");
        }
        public void startDungeon() //첫번째 던전
        {
            Console.WriteLine("던전이다..."); //던전 설명

            //몬스터와 만남 메서드
            
            Console.WriteLine("몬스터와 전투를 합니다. 투닥투닥...."); //전투 관련 메서드 추가

            Console.WriteLine("전투가 끝났습니다.");

            Console.WriteLine("보물상자가 나타났다!"); //던전은 파밍이 가능하다는 것을 알려줌
            Console.WriteLine("보물상자에서 몬스터가 나왔다"); //랜덤 + if문 처리

            Console.WriteLine("던전의 보스가 나타났다!"); //몬스터 몇마리 잡았을 경우 또는 그냥 랜덤으로 설정 고민중

            Console.WriteLine("던전의 보스를 처치했다..."); //원래 있던 필드로 이동 하기. 

        }
    }
}
