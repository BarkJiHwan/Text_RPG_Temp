using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGAlancia
{
    internal class Story
    {
        public void StratStory()
        {
            Console.WriteLine("저녁 노을이 지는 들판 위. 붉게 물든 하늘에서 번쩍이는 빛이 내려친다.\n" +
                "빛이 사라지며, 그 자리에 낯선 남자가 누워 있다.\n");
            Console.ReadKey(true);
            Console.WriteLine("촌장은 마을 주변을 순회하던 중, 들판에 쓰러져 있는 남자를 발견한다. \n" +
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
        public void MainStory(Player player)
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
        public void FirstMainStory(Player player)
        {
            Console.WriteLine($"{player.Name} : 여기서부터는 몬스터를 만날 수도 있다는 건가..?");
            Console.WriteLine($"경비대장 : 음? 처음 보는 얼굴이군?");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : ?! 누구시죠? '위험한 기분이 들어...'");
            Console.ReadKey(true);
            Console.WriteLine($"경비대장 : 나는 그린힐 마을에서 경비대장을 맡고 있는 존이라고 하네만.. 자넨 누구지?");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : 저는 {player.Name}이라고 합니다.");
            Console.ReadKey(true);
            Console.WriteLine($"경비대장 존 : 아~ 아, 자네가 촌장님께서 말했던 그 친구구만~");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : 무슨.. 일이시죠?");
            Console.ReadKey(true);
            Console.WriteLine($"경비대장 존 : 하하 너무 경계할 건 없네, 난 여기 그린힐 마을의 토박이거든~ \n" +
                $"처음 보는 얼굴인데 마을에서 나오니 궁금해서 말 한번 걸어 본 거라네");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : ....");
            Console.ReadKey(true);
            Console.WriteLine($"경비대장 존 : 그런데.. 어딜 가는 건가?");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : 촌장님께서 부탁하신 물건이 있어서 가지러 가는 중입니다.");
            Console.ReadKey(true);
            Console.WriteLine($"경비대장 존 : 음? 부탁하신 물건?");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : 말씀드리기 조금 곤란하군요. 전 이만 가보겠습니다.");
            Console.ReadKey(true);
            Console.WriteLine($"경비대장 존 : 만난 지 얼마 되지도 않았는데 엄청 경계하는군 알겠네\n" +
                $"그래도 초원을 가로지를 때 보이는 공동묘지에는 절대 혼자 들어가지 말게나");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : 그러죠, 그럼...");
            Console.ReadKey(true);
            Console.WriteLine("자리를 떠나는 주인공의 뒷모습을 바라보며 존의 표정에는 어두운 그림자가 드리워졌다. \n" +
                "그의 눈에는 알 수 없는 악의가 서려 있었다. 주인공이 멀어질수록, 존은 무거운 생각에 잠기며 그 자리에서\n" +
                "주인공이 걸어간 자리를 한참동안 응시하고 있었다.");
            Console.ReadKey(true);
        }
        public void FirstMainSkeep(Player player)
        {
            Console.WriteLine($"{player.Name} : 제 이름은 \"{player.Name}\"입니다. ");
            Console.ReadKey(true);
            Console.WriteLine("마을촌장 : 알겠네. 입구에 자네 이름을 말해둘테니 언제든 들려 주게나..");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : .. 알겠습니다.");
            Console.ReadKey(true);
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
            Eraser.Clear();
            Console.WriteLine("조금 걷다보니 마을 입구가 보이기 시작한다.");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : 안녕하십니까?");
            Console.ReadKey(true);
            Console.WriteLine("마을 경비 : 음? 처음 보는 얼굴이군. 자넨 누구지?");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : 촌장님께서 부르셔서 왔습니다.");
            Console.ReadKey(true);
            Console.WriteLine("마을 경비 : 촌장님께서? 흠... 잠시만 기다려 보게.");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : 알겠습니다.");
            Console.ReadKey(true);
            Console.WriteLine("경비가 초소에 들어가서 장부를 살핀다.");
            Console.ReadKey(true);
            Console.WriteLine("마을 경비 : 음.. 이름이 어떻게 되나?");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : {player.Name}입니다.");
            Console.ReadKey(true);
            Console.WriteLine($"마을 경비 : {player.Name}... {player.Name}... 아, 여기 있군.");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : 확인됐습니까?");
            Console.ReadKey(true);
            Console.WriteLine("마을 경비 : 확인됐네. 촌장님은 지금 마을 순회 중이실 테니 촌장님 댁으로 가서 조금 기다리면 될 걸세.");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : 감사합니다.");
            Console.ReadKey(true);
            Console.WriteLine("마을 경비 : 촌장님 집은 저기 언덕 뒷편에 있다네.");
            Console.ReadKey(true);
            Console.WriteLine($"마을 검문소를 지나 {player.Name}는 마을로 들어간다.");
            Console.ReadKey(true);
        }
        public void secondMainSkeep2(Player player)
        {
            Console.WriteLine($"{player.Name} : 여기서부터는 몬스터를 만날 수도 있다는 건가..?");
            Console.WriteLine($"경비대장 : 음? 처음 보는 얼굴이군?");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : 누구시죠?");
            Console.ReadKey(true);
            Console.WriteLine($"경비대장 : 나는 경비대장을 맡고 있는 존이라네, 자넨 누구지?");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : 저는 {player.Name}이라고 합니다.");
            Console.ReadKey(true);
            Console.WriteLine($"경비대장 존 : {player.Name}? 처음 듣는 이름인데? 마을에는 어떻게 들어왔지?");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : 무슨.. 일이시죠?");
            Console.ReadKey(true);
            Console.WriteLine($"경비대장 존 : 웬만한 마을일은 전부 꿰고 있는 경비대장인 내가 처음 보는 사람을 경계하는 건 당연한 것 아니겠나?");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : ....");
            Console.ReadKey(true);
            Console.WriteLine($"경비대장 존 : 누군지 대답하지 않는다면 체포할 수밖에 없다네?");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : 그린힐 동산에서 촌장님을 만나 들어온 겁니다");
            Console.ReadKey(true);
            Console.WriteLine($"경비대장 존 : 음? 그린힐 동산에서? '그린힐 동산이라니 설마...'");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : 자세한 내용은 말씀드리기 조금 곤란하군요. 이만 가봐도 되겠습니까?");
            Console.ReadKey(true);
            Console.WriteLine($"경비대장 존 : 일단 촌장님의 확인이 있어야 할 것 같군? 그때까진 잠시 동행해 줘야겠네");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : 그럼 촌장님 댁으로 같이 가시죠");
            Console.ReadKey(true);
            Console.WriteLine("경비대장 존 : 그러지");
            Console.ReadKey(true);
            Console.WriteLine("경비대장과 촌장의 집으로 향하고....");
            Console.ReadKey(true);
            Console.WriteLine("경비대장 존 : 촌장님 계십니까?");
            Console.ReadKey(true);
            Console.WriteLine($"마을 촌장 : 음? 경비대장 아닌가? 오늘 아침에 봤는데 무슨 일인가?");
            Console.ReadKey(true);
            Console.WriteLine("경비대장 존 : 처음 보는 수상한 자가 마을에서 나왔는데 촌장님을 알고 있다 하기에 확인차 왔습니다");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : 안녕하십니까 촌장님 {player.Name}입니다.");
            Console.ReadKey(true);
            Console.WriteLine("마을 촌장 : 오 자네 몸은 좀 괜찮아졌는가?");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : 예.. 많이 좋아졌습니다.");
            Console.ReadKey(true);
            Console.WriteLine("경비대장 존 : 촌장님 아는 분이셨습니까?");
            Console.ReadKey(true);
            Console.WriteLine("마을 촌장 : 하하 그렇다네. 자세한 건 이따 이야기해줍세");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : 존 경비대장님? 이제 가봐도 되는 건가요?");
            Console.ReadKey(true);
            Console.WriteLine("경비대장 존 : 크흠.. 알겠네 의심해서 미안했네 가봐도 되네");
            Console.ReadKey(true);
            Console.WriteLine($"{player.Name} : 예, 나중에 또 뵙죠. 가보겠습니다.");
            Console.ReadKey(true);
            Console.WriteLine("주인공이 촌장의 집에서 멀어진다.");
            Console.ReadKey(true);
            Console.WriteLine("경비대장 존 : 촌장님, 그래서 저 자는 누구입니까?");
            Console.ReadKey(true);
            Console.WriteLine("마을 촌장 : 전이자라네..");
            Console.ReadKey(true);
            Console.WriteLine("경비대장 존 : !? 전이자요?");
            Console.ReadKey(true);
            Console.WriteLine("마을 촌장 : 그렇다네");
            Console.ReadKey(true);
            Console.WriteLine("경비대장 존 : 예전에도 그렇고..");
            Console.ReadKey(true);
            Console.WriteLine("마을 촌장 : 크흠!");
            Console.ReadKey(true);
            Console.WriteLine("경비대장 존 : !? 죄송합니다.");
            Console.ReadKey(true);
            Console.WriteLine("마을 촌장 : 자네도 알다시피 이전 전이자에 대한 내용은 극비라네, \n" +
                "요즘 그 자에 대한 기억만 사라지는 것 같아 찜찜하다네.. 이젠 얼굴도 잘 기억이 나지 않아");
            Console.ReadKey(true);
            Console.WriteLine("그렇게 둘만의 대화가 이어지고 경비대장은 의미심장한 눈으로 주인공이 떠난 자리를 잠시 응시한다..");
            Console.ReadKey(true);
        }
    }
}
