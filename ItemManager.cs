using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{

    internal class ItemManager
    {
        public List<List<Item>> AllItemList { get; set; }
        public List<Item> _WeaponItems { get; set; }
        public List<Item> _ArmorItmes { get; set; }
        public List<Item> _AccessoryItems { get; set; }
        public List<Item> _ConsumableItems { get; set; }
        public List<Item> _OtherItems { get; set; }
        public ItemTpye _ItemTpye { get; set; } = new ItemTpye();

        public ItemManager()
        {
            _WeaponItems = new List<Item>();
            {
                _WeaponItems.Add(new WeaponItem("긴 나무 몽둥이", 10, 2, 1.2, "단단한 나무로 만든 긴 몽둥이. 기본적인 무기로 사용된다", 500));
                _WeaponItems.Add(new WeaponItem("낡은검", 15, 2, 1.3, "사용한지 오래되어 날에 녹이쓴 낡은 검이다", 2000));
                _WeaponItems.Add(new WeaponItem("날카로운 단검", 20, 5, 1.5, "빠르고 날카로운 단검. 치명타 확률이 높다", 5000));
                _WeaponItems.Add(new WeaponItem("철제 롱소드", 25, 4, 1.6, "강철로 만든 긴 검. 평균적인 공격력을 지닌다", 8000));

                _WeaponItems.Add(new WeaponItem("어둠의 쌍검", 30, 6, 1.7, "어둠의 힘이 깃든 쌍검. 높은 치명타 확률과 데미지를 가짐", 15000));
                _WeaponItems.Add(new WeaponItem("불타는 클레이모어", 35, 8, 1.8, "불의 마법이 부여된 큰 검. 치명타 확률이 높고 데미지가 강하다", 22000));
                _WeaponItems.Add(new WeaponItem("절단 도끼", 40, 5, 1.9, "강력한 도끼. 데미지가 높고 치명타가 잘 터진다", 30000));
                _WeaponItems.Add(new WeaponItem("번개의 전쟁 망치", 45, 6, 2.0, "번개 마법이 부여된 무거운 망치. 공격력은 높으나 크리티컬 확률은 낮다", 38000));

                _WeaponItems.Add(new WeaponItem("신성한 창", 50, 7, 2.1, "신성한 힘이 깃든 창. 높은 치명타 확률과 적당한 데미지를 가진다", 45000));
                _WeaponItems.Add(new WeaponItem("냉기의 대검", 55, 8, 2.2, "냉기의 마법이 부여된 커다란 검. 높은 데미지를 자랑한다", 52000));
                _WeaponItems.Add(new WeaponItem("독의 단검", 60, 9, 2.3, "독 마법이 깃든 단검. 매우 높은 치명타 확률과 데미지를 가진다", 60000));
                _WeaponItems.Add(new WeaponItem("고대의 검", 65, 10, 2.4, "오래된 고대의 검. 강력한 공격력을 지닌다", 70000));

                _WeaponItems.Add(new WeaponItem("태양의 검", 70, 11, 2.5, "태양의 힘이 깃든 검. 치명타 확률이 높고 높은 데미지를 자랑함", 80000));
                _WeaponItems.Add(new WeaponItem("영혼의 단검", 75, 12, 2.6, "영혼의 힘이 깃든 단검. 높은 치명타 확률과 데미지를 자랑한다", 90000));
                _WeaponItems.Add(new WeaponItem("불사의 클레이모어", 80, 13, 2.7, "불사의 마법이 깃든 클레이모어. 치명타 확률이 매우 높고 파괴력이 강하다", 100000));

            }

            _ArmorItmes = new List<Item>();
            {
                _ArmorItmes.Add(new ArmorItem("낡은천옷", 6, 36, 0, "조금 낡았지만 성능에 문제가 없는 옷이다.", 500));
                _ArmorItmes.Add(new ArmorItem("가죽 갑옷", 9, 52, 1, "질긴 가죽으로 만든 기본적인 방어구.", 2000));
                _ArmorItmes.Add(new ArmorItem("전사의 갑옷", 13, 65, 2, "전사들이 착용하는 튼튼한 갑옷.", 5000));
                _ArmorItmes.Add(new ArmorItem("철제 갑옷", 16, 78, 3, "단단한 철로 만든 갑옷. 방어력이 뛰어나다.", 8000));

                _ArmorItmes.Add(new ArmorItem("은빛 갑옷", 20, 91, 4, "은빛으로 빛나는 갑옷. 고급 방어구.", 15000));
                _ArmorItmes.Add(new ArmorItem("마법의 로브", 23, 104, 5, "마법의 힘이 깃든 로브. 마법 저항력이 뛰어나다.", 22000));
                _ArmorItmes.Add(new ArmorItem("용의 갑옷", 27, 117, 6, "용의 비늘로 만든 갑옷. 매우 높은 방어력과 체력 증가.", 30000));
                _ArmorItmes.Add(new ArmorItem("빛의 갑옷", 30, 130, 7, "빛의 힘이 깃든 갑옷. 적의 공격을 반사한다.", 38000));

                _ArmorItmes.Add(new ArmorItem("어둠의 갑옷", 34, 143, 8, "어둠의 힘이 깃든 갑옷. 적의 공격을 흡수한다.", 45000));
                _ArmorItmes.Add(new ArmorItem("바람의 갑옷", 37, 156, 9, "가벼운 재질로 만들어진 갑옷. 민첩성이 증가한다.", 52000));
                _ArmorItmes.Add(new ArmorItem("불꽃의 갑옷", 41, 169, 10, "불꽃의 힘이 깃든 갑옷. 공격 시 불꽃 피해를 입힌다.", 60000));
                _ArmorItmes.Add(new ArmorItem("얼음의 갑옷", 44, 182, 11, "얼음의 힘이 깃든 갑옷. 방어력이 매우 높다.", 70000));

                _ArmorItmes.Add(new ArmorItem("전기의 갑옷", 48, 195, 12, "전기의 힘이 깃든 갑옷. 적에게 전기 충격을 준다.", 80000));
                _ArmorItmes.Add(new ArmorItem("신성한 갑옷", 52, 208, 13, "신성한 힘이 깃든 갑옷. 신성한 보호막을 제공한다.", 90000));
                _ArmorItmes.Add(new ArmorItem("고대의 갑옷", 55, 221, 14, "고대 유적에서 발굴된 갑옷. 매우 높은 방어력과 체력 증가.", 100000));
            }

            _AccessoryItems = new List<Item>();
            {
                _AccessoryItems.Add(new AccessoryItem("가죽 반지", 4, 5, 26, 30, "기본적인 반지로, 공격력과 방어력을 제공합니다.", 500));
                _AccessoryItems.Add(new AccessoryItem("작은 고리", 5, 6, 30, 35, "작은 고리 모양의 악세서리. 공격력과 방어력을 제공합니다.", 1500));
                _AccessoryItems.Add(new AccessoryItem("가죽 목걸이", 6, 7, 35, 40, "질긴 가죽으로 만든 목걸이. 체력과 방어력을 제공합니다.", 3000));
                _AccessoryItems.Add(new AccessoryItem("수호의 반지", 7, 8, 40, 45, "수호의 힘이 깃든 반지. 방어력과 체력을 증가시킵니다.", 5000));

                _AccessoryItems.Add(new AccessoryItem("은빛 펜던트", 8, 9, 45, 50, "은으로 만들어진 펜던트. 체력과 마나를 증가시킵니다.", 7000));
                _AccessoryItems.Add(new AccessoryItem("마법의 보석", 9, 10, 50, 55, "마법이 깃든 보석. 체력과 마나를 증가시킵니다.", 9000));
                _AccessoryItems.Add(new AccessoryItem("힘의 팔찌", 10, 11, 55, 60, "강한 힘이 느껴지는 팔찌. 공격력과 체력을 증가시킵니다.", 12000));
                _AccessoryItems.Add(new AccessoryItem("지혜의 목걸이", 11, 12, 60, 65, "지혜의 힘이 깃든 목걸이. 마나를 크게 증가시킵니다.", 15000));

                _AccessoryItems.Add(new AccessoryItem("용맹의 반지", 12, 13, 65, 70, "용맹한 자들이 착용한 반지. 공격력과 방어력을 동시에 증가시킵니다.", 18000));
                _AccessoryItems.Add(new AccessoryItem("속도의 귀걸이", 13, 14, 70, 75, "속도의 힘이 깃든 귀걸이. 공격력과 마나를 증가시킵니다.", 21000));
                _AccessoryItems.Add(new AccessoryItem("신성한 펜던트", 14, 15, 75, 80, "신성한 힘이 깃든 펜던트. 체력과 마나를 증가시킵니다.", 25000));
                _AccessoryItems.Add(new AccessoryItem("냉기의 목걸이", 15, 16, 80, 85, "냉기의 힘이 깃든 목걸이. 방어력과 마나를 증가시킵니다.", 30000));

                _AccessoryItems.Add(new AccessoryItem("불꽃의 반지", 16, 17, 85, 90, "불꽃의 힘이 깃든 반지. 공격력과 체력을 증가시킵니다.", 35000));
                _AccessoryItems.Add(new AccessoryItem("전기의 귀걸이", 17, 18, 90, 95, "전기의 힘이 깃든 귀걸이. 방어력과 마나를 증가시킵니다.", 40000));
                _AccessoryItems.Add(new AccessoryItem("어둠의 펜던트", 18, 19, 95, 100, "어둠의 힘이 깃든 펜던트. 체력과 마나를 증가시킵니다.", 50000));
            }

            _ConsumableItems = new List<Item>();
            {
                _ConsumableItems.Add(new ConsumableItem("초급 체력 회복 포션", "체력을 200 회복합니다.", 200, 0, 100));
                _ConsumableItems.Add(new ConsumableItem("초급 마력 회복 포션", "마력을 100 회복합니다.", 0, 100, 100));
                _ConsumableItems.Add(new ConsumableItem("중급 체력 회복 포션", "체력을 500 회복합니다.", 500, 0, 500));
                _ConsumableItems.Add(new ConsumableItem("중급 마력 회복 포션", "마력을 250 회복합니다.", 0, 250, 500));
                _ConsumableItems.Add(new ConsumableItem("상급 체력 회복 포션", "체력을 1000 회복합니다.", 1000, 0, 1000));
                _ConsumableItems.Add(new ConsumableItem("상급 마력 회복 포션", "마력을 500 회복합니다.", 0, 500, 1000));
                _ConsumableItems.Add(new ConsumableItem("최상급 체력 회복 포션", "체력을 1500 회복합니다.", 1500, 0, 2000));
                _ConsumableItems.Add(new ConsumableItem("최상급 마력 회복 포션", "마력을 750 회복합니다.", 0, 750, 2000));
                _ConsumableItems.Add(new ConsumableItem("극상의 체력 회복 포션", "체력을 3000 회복합니다.", 3000, 0, 5000));
                _ConsumableItems.Add(new ConsumableItem("극상의 마력 회복 포션", "마력을 1500 회복합니다.", 0, 1500, 5000));
            }

            AllItemList = new List<List<Item>>();
            {
                AllItemList.Add(_WeaponItems);
                AllItemList.Add(_ArmorItmes);
                AllItemList.Add(_AccessoryItems);
                AllItemList.Add(_ConsumableItems);
            }
        }

        //public Item ItemRandomGet(int mapNum)
        //{
        //    Random random = new Random();
        //    var itemTpye = (int)_ItemTpye;
        //    int num = 0;
        //    if (mapNum == 1)
        //    {
        //        num = random.Next(0, 4);
        //        itemTpye = random.Next(0, 5);
        //    }
        //    else if (mapNum == 2)
        //    {
        //        num = random.Next(3, 7);
        //        itemTpye = random.Next(0, 5);
        //    }
        //    else if (mapNum == 3)
        //    {
        //        num = random.Next(7, 10);
        //        itemTpye = random.Next(0, 5);
        //    }
        //    else if (mapNum == 4)
        //    {
        //        num = random.Next(7, 10);
        //        itemTpye = random.Next(0, 5);
        //    }
        //    else if (mapNum == 5)
        //    {
        //        num = random.Next(7, 10);
        //        itemTpye = random.Next(0, 5);
        //    }
        //    int CopyNum = num;

        //    if (itemTpye == 0)
        //    {
        //        Item CopyItem = _WeaponItems[CopyNum];
        //        return new WeaponItem(CopyItem.Name, CopyItem.Damage, CopyItem.Critical, CopyItem.CriticalDam, CopyItem.Description, CopyItem.Price);
        //    }
        //    else if (itemTpye == 1)
        //    {
        //        Item CopyItem = _ArmorItmes[CopyNum];
        //        return new ArmorItem(CopyItem.Name, CopyItem.Armor, CopyItem.Health, CopyItem.Mana, CopyItem.Description, CopyItem.Price);
        //    }
        //    else if (itemTpye == 2)
        //    {
        //        Item CopyItem = _AccessoryItems[CopyNum];
        //        return new AccessoryItem(CopyItem.Name, CopyItem.Damage, CopyItem.Armor, CopyItem.Health, CopyItem.Mana, CopyItem.Description, CopyItem.Price);
        //    }
        //    else if (itemTpye == 3)
        //    {
        //        Item CopyItem = _ConsumableItems[CopyNum];
        //        return new ConsumableItem(CopyItem.Name, CopyItem.Description, CopyItem.Health, CopyItem.Mana, CopyItem.Price);
        //    }
        //    else
        //    {
        //        Item CopyItem = _OtherItems[CopyNum];
        //        return new OtherItem(CopyItem.Name, CopyItem.Description, CopyItem.Price);
        //    }


        public void ItemRooting(Player player, int mapNum)
        {
            //인자값으로 맵 번호를 받아서 해당 맵 번호와 일치하는 아이템을 표시해줌
            //랜덤으로 무기,방어구,악세서리, 소비아이템 중 한개 나옴
            Random random = new Random();
            int itemType = random.Next(4);
            int itemNumber = random.Next(4);
            if (mapNum == 1)
            {
                itemNumber = random.Next(0, 3);
                itemType = random.Next(0, 4);
            }
            else if (mapNum == 2)
            {
                itemNumber = random.Next(3, 7);
                itemType = random.Next(0, 4);
            }
            else if (mapNum == 3)
            {
                itemNumber = random.Next(7, 10);
                itemType = random.Next(0, 4);
            }
            else if (mapNum == 4)
            {
                itemNumber = random.Next(10, 13);
                itemType = random.Next(0, 4);
            }
            else
            {
                itemNumber = random.Next(12, 15);
                itemType = random.Next(0, 4);
            }

            Item itemCopy;
            if (itemType == 0)
            {
                Console.WriteLine(Game.itemManager._WeaponItems[itemNumber].Name);
                itemCopy = new WeaponItem(_WeaponItems[itemNumber].Name, _WeaponItems[itemNumber].Damage, _WeaponItems[itemNumber].Critical, _WeaponItems[itemNumber].CriticalDam, _WeaponItems[itemNumber].Description, _WeaponItems[itemNumber].Price);
            }
            else if (itemType == 1)
            {
                Console.WriteLine(Game.itemManager._ArmorItmes[itemNumber].Name);
                itemCopy = new ArmorItem(_ArmorItmes[itemNumber].Name, _ArmorItmes[itemNumber].Armor, _ArmorItmes[itemNumber].MaxHealth, _ArmorItmes[itemNumber].MaxMana, _ArmorItmes[itemNumber].Description, _ArmorItmes[itemNumber].Price);
            }
            else if (itemType == 2)
            {
                Console.WriteLine(Game.itemManager._AccessoryItems[itemNumber].Name);
                itemCopy = new AccessoryItem(_AccessoryItems[itemNumber].Name, _AccessoryItems[itemNumber].Damage, _AccessoryItems[itemNumber].Armor, _AccessoryItems[itemNumber].Health, _AccessoryItems[itemNumber].Mana, _AccessoryItems[itemNumber].Description, _AccessoryItems[itemNumber].Price);
            }
            else
            {
                Console.WriteLine(Game.itemManager._ConsumableItems[itemNumber].Name);
                itemCopy = new ConsumableItem(_ConsumableItems[itemNumber].Name, _ConsumableItems[itemNumber].Description, _ConsumableItems[itemNumber].Health, _ConsumableItems[itemNumber].Mana, _ConsumableItems[itemNumber].Price);
            }
            Console.WriteLine($"{itemCopy.Name}아이템을 획득하시겠습니까?\n" +
                "1번, 획득한다, 2번, 버린다.");
            bool itemRooting = true;
            var inPut = Console.ReadLine();
            while (itemRooting)
            {
                if (inPut == "1")
                {
                    Console.WriteLine("아이템을 획득했습니다.");
                    player.ItemGet(itemCopy);
                    itemRooting = false;
                }
                else if (inPut == "2")
                {
                    Console.WriteLine("아이템을 버렸습니다.");
                    itemRooting = false;
                }
                else
                {
                    Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요.");
                }
            }
        }
    }
}