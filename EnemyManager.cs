using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextRPGAlancia
{
    internal class EnemyManager
    {
        public List<Enemy> _enemies { get; set; }
        public Enemy enemy { get; set; }

        public EnemyManager()
        {
            _enemies = new List<Enemy>();
            {
                //이름, 체력, 공격력, 방어력, 골드, 경험치
                //0인덱스부터~40인덱스까지

                _enemies.Add(new Enemy("고블린", 70, 15, 8, 10, 10));
                _enemies.Add(new Enemy("임프", 85, 18, 9, 12, 12));
                _enemies.Add(new Enemy("슬라임", 100, 20, 10, 14, 15));
                _enemies.Add(new Enemy("스켈레톤", 120, 24, 12, 18, 18));

                _enemies.Add(new Enemy("망령", 150, 30, 15, 20, 20));
                _enemies.Add(new Enemy("붉은 슬라임", 180, 35, 18, 22, 25));
                _enemies.Add(new Enemy("붉은 스켈레톤", 200, 40, 20, 25, 28));
                _enemies.Add(new Enemy("경비대장 존", 1000, 80, 20, 220, 150));

                _enemies.Add(new Enemy("오크", 220, 45, 22, 30, 32));
                _enemies.Add(new Enemy("오우거", 280, 50, 25, 35, 38));
                _enemies.Add(new Enemy("트롤", 350, 60, 30, 50, 50));
                _enemies.Add(new Enemy("사이클롭스", 450, 70, 35, 70, 65));

                _enemies.Add(new Enemy("고블린 대장", 480, 75, 38, 75, 70));
                _enemies.Add(new Enemy("불의 임프", 510, 80, 40, 80, 75));
                _enemies.Add(new Enemy("독 슬라임", 540, 85, 42, 85, 78));
                _enemies.Add(new Enemy("강철 스켈레톤", 570, 90, 45, 90, 80));

                _enemies.Add(new Enemy("악몽의 망령", 600, 95, 48, 95, 82));
                _enemies.Add(new Enemy("파이어 슬라임", 630, 100, 50, 100, 85));
                _enemies.Add(new Enemy("유령", 660, 105, 52, 105, 88));

                _enemies.Add(new Enemy("엘리트 오크", 690, 110, 55, 110, 90));
                _enemies.Add(new Enemy("거대한 오우거", 720, 115, 58, 115, 93));
                _enemies.Add(new Enemy("거대 트롤", 750, 120, 60, 120, 95));
                _enemies.Add(new Enemy("눈의 사이클롭스", 780, 125, 62, 125, 98));

                _enemies.Add(new Enemy("지하 고블린", 810, 130, 65, 130, 100));
                _enemies.Add(new Enemy("거미 임프", 840, 135, 68, 135, 103));
                _enemies.Add(new Enemy("산성 슬라임", 870, 140, 70, 140, 105));
                _enemies.Add(new Enemy("그림자 스켈레톤", 900, 145, 72, 145, 108));

                _enemies.Add(new Enemy("빙하 망령", 930, 150, 75, 150, 110));
                _enemies.Add(new Enemy("번개 슬라임", 960, 155, 78, 155, 113));
                _enemies.Add(new Enemy("혼돈의 유령", 990, 160, 80, 160, 115));

                _enemies.Add(new Enemy("악마 오크", 1020, 165, 82, 165, 118));
                _enemies.Add(new Enemy("바위 오우거", 1050, 170, 85, 170, 120));
                _enemies.Add(new Enemy("흑마법 트롤", 1080, 175, 88, 175, 123));
                _enemies.Add(new Enemy("태양의 사이클롭스", 1110, 180, 90, 180, 125));

                _enemies.Add(new Enemy("마녀 고블린", 1140, 185, 92, 185, 128));
                _enemies.Add(new Enemy("불꽃 임프", 1170, 190, 95, 190, 130));
                _enemies.Add(new Enemy("얼음 슬라임", 1200, 195, 98, 195, 133));
                _enemies.Add(new Enemy("황금 스켈레톤", 1230, 200, 100, 200, 135));

                _enemies.Add(new Enemy("어둠의 망령", 1260, 205, 102, 205, 138));
                _enemies.Add(new Enemy("독의 슬라임", 1290, 210, 105, 210, 140));
                _enemies.Add(new Enemy("영혼의 유령", 1320, 215, 108, 215, 143));
                _enemies.Add(new Enemy("천상의 사이클롭스", 1350, 220, 110, 220, 145));

                
            }
        }
        public Enemy EnemyRandomGet(int mapIndex) 
        {//각 사냥터의 맵에 따라 나오는 몹이 달라지게 설정하고 싶었음            
            //맵의 인덱스 값이 높아질 수록 즉, 사냥터의 수준이 올라 갈수록 더 강한 몹들이 나오도록 구현하고 싶었음.
            //List를 활용하여 각 몹들이 갖는 수치를 직접 입력해 주면 되서 몹을 만들기가 매우 쉬움
                        
            Random random = new Random();
            int num = 0;
            if (mapIndex == 1)
            {
                num = random.Next(0, 4);
            }
            else if (mapIndex == 2)
            {
                num = random.Next(3, 8);
            }
            else if (mapIndex == 3)
            {
                num = random.Next(7, 10);
            }
            else if (mapIndex == 4)
            {
                num = random.Next(10, 16);
            }
            else if (mapIndex == 5)
            {
                num = random.Next(15, 20);
            }
            //맵의 인덱스를 받아와 그 값에 맞는 몹을 List에서 랜덤으로 한마리 뽑음
            //그 후에 랜덤으로 뽑은 값을 변수 num에 담고 List의 인덱스로 넣어 줌
            //값을 그냥 리턴하게 되면 원본의 수치가 바뀌게 되니
            //그 값을 복사할 수 있는 변수를 만듬
            //그리고 복사한 변수의 수치를 리턴하여 원본값이 바뀌지 않도록 했음.
            Enemy CopyEnemy = _enemies[num]; 
            return new Enemy(CopyEnemy.Name, CopyEnemy.Health, CopyEnemy.Damage, CopyEnemy.Armor, CopyEnemy.Gold,CopyEnemy.Exp);
        }

        //public Enemy EnemySeting(Enemy enemy)
        //{
            

        //    return enemy;
        //}
    }
}
