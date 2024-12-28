using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    internal class Story
    {
        public void StratStory()
        {
            Console.WriteLine("따스한 햇살이 내리쬐는 들판 위. 푸른 하늘에서 번쩍이는 빛이 내려친다. \n" +
                "빛이 사라지며, 그 자리에 낯선 남자가 누워 있다.\n");
            Console.ReadKey(true);
            Console.WriteLine("촌장은 마을 주변을 순찰하던 중, 들판에 쓰러져 있는 남자를 발견한다. \n" +
                "촌장은 조심스럽게 다가가 남자의 상태를 살피고, 그가 아직 살아있음을 확인한다.\n" +
                "촌장은 이전에도 이런 일이 있었음을 떠올리며, 걱정스러운 표정을 짓는다.\n");
            Console.ReadKey(true);
            Console.WriteLine("마을촌장 : 음.. 이번에도...");
            Console.ReadKey(true);
            Console.WriteLine("??? : 으윽....");
            Console.ReadKey(true);
            Console.WriteLine("마을촌장 : 이보게 정신이 드는가?");
            Console.ReadKey(true);
            Console.WriteLine("??? : ....누구시죠?");
            Console.ReadKey(true);
            Console.WriteLine("마을촌장 : 나는 마을촌장일세 괜찮다면 우리 마을로 가겠는가?");
            Console.ReadKey(true);
            Console.WriteLine("??? : ....");
        }
        public void WhatsYourName()
        {
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
        }
        public void FirstQuarter(Player player) 
        {
            Console.WriteLine($"{player.Name} : 제 이름은 {player.Name} 입니다.");            
            Console.ReadKey(true);
            Console.WriteLine($"마을촌장 : {player.Name}..?  \'처음듣는 이름이지만 낯설지 않은 기분이군...\' ");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : 왜.. 그러십니까?");
            Console.ReadKey(true);
            Console.WriteLine("마을촌장 : 허허 아닐세 저기 보이는 마을이 우리 \'그린힐\'마을일세");
            Console.WriteLine();
            Game.map.Locations[0].MapNamespace();
            Console.WriteLine();
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} :!? 윽...");
            Console.ReadKey(true);
            Console.WriteLine("마을촌장 : ?!..자네 괜찮은가? ");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : 괜찮습니다.. 조금 어지러워서요. \'분명 처음 보는 풍경일텐데 낯설지가 않아...\'");
            Console.ReadKey(true);
            Console.WriteLine("마을촌장 : 다행이구만 깨어난지 얼마되지 않아서 그럴 수 있으니 마을 좀 둘러보다 우리집으로 오게나 \n" +
                "마을은 안전하지만 마을 밖에는 몬스터들이 많으니 준비 없이 섣불리 나가지 말게");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : 몬스터라니...");
            Console.ReadKey(true);
            Console.WriteLine("마을촌장 : 마을안쪽으로는 몬스터들이 들어오지 못하지만 마을밖에는\n" +
                "어디선가 몬스터들이 계속 나타나고 있다네...");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : ....");
            Console.ReadKey(true);
            Console.WriteLine("마을촌장 : 허허 생각을 정리할 시간이 필요할테니 생각을 정리하고 우리집으로 오게나");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : ..알겠습니다.");
            Console.ReadKey(true);
            Eraser.Clear();
            Console.WriteLine("마을 촌장은 돌아가고 혼자 남은 주인공은 근처의 밴치에 앉아 혼란스러운 마음을 정리하기 시작한다.\n" +
                " 그는 전이된 충격과 낯선 환경에 대한 불안감을 느끼며 깊은 생각에 잠긴다. \n" +
                "차가운 바람이 그의 얼굴을 스치고 지나간다.\n" +
                " 주인공은 자신이 왜 이곳에 있게 되었는지, 앞으로 어떤 여정을 걷게 될지 고민하며 자신을 다독인다.\n");
            Console.ReadKey(true);
            Console.WriteLine("마을은 비교적 안전하지만, 그 밖에는 몬스터들이 도사리고 있는 위험한 세상이 기다리고 있다.\n" +
                "주인공은 이제 이 새로운 세상에서 살아남기 위해 자신을 다잡는다.\n");
            Console.ReadKey(true);
        }
        public void FirstQuarter2(Player player)
        {
            Console.WriteLine($"{player.Name} : 제 이름은 {player.Name}입니다. ");
            Console.ReadKey(true);
            Console.WriteLine("마을촌장 : 알겠네. 입구에 자네 이름을 말해둘테니 언제든 들려 주게나..");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : .. 알겠습니다.");
            Console.WriteLine("마을 촌장은 돌아가고 혼자 남은 주인공은 들판에 앉아 혼란스러운 마음을 정리하기 시작한다.\n" +
                " 그는 전이된 충격과 낯선 환경에 대한 불안감을 느끼며 깊은 생각에 잠긴다. \n" +
                "차가운 바람이 그의 얼굴을 스치고 지나간다.\n" +
                " 주인공은 자신이 왜 이곳에 있게 되었는지, 앞으로 어떤 여정을 걷게 될지 고민하며 자신을 다독인다.\n");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : 분명.. 몬스터라고 했지?");
            Console.ReadKey(true);
            Console.WriteLine("이곳은 비교적 안전하지만, 밖에는 몬스터들이 도사리고 있는 위험한 세상이 기다리고 있다.\n" +
                "주인공은 이제 이 새로운 세상에서 살아남기 위해 자신을 다잡는다.\n");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : 재미있겠는걸?");
            Console.WriteLine($"{player.Name} : 일단 마을로 가야겠군");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : 주인공은 결의에 찬 표정으로 마음을 다잡으며 촌장이 사라진 길을 따라간다.\n " +
                $"그의 눈빛에는 강한 의지가 담겨있다.");
            Console.ReadKey(true);
        }
    }
}
