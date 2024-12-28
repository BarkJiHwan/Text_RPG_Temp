using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGAlancia
{
    public class Equipment
    {
        public Dictionary<ItemTpye, Item> Equip { get; set; }
        public Item item;
        public Equipment()
        {
            Equip = new Dictionary<ItemTpye, Item>();
            {
                Equip[ItemTpye.Weapon] = null;
                Equip[ItemTpye.Armor] = null;
                Equip[ItemTpye.Accessory] = null;
            }
        }
        //public void ReplaceItem(Player player, Inventory inventory)
        //{
        //    Console.WriteLine("몇번째 아이템을 사용 하시겠습니까?\n" +
        //        "첫번째 아이템은 0부터 시작합니다.");
        //    Console.WriteLine("숫자 이외의 키 입력시 인벤토리 종료");
        //    bool itemCheck = int.TryParse(Console.ReadLine(), out int InventoyrNumber);
        //    if (itemCheck == false)
        //    {
        //        Console.WriteLine("인벤토리 나가기");
        //    }
        //    else
        //    {
        //        if (Equip != null)
        //        {
        //            if (inventory.item.Tpye == ItemTpye.Weapon)
        //            {
        //                Item item = player.playerinventory.inventories[InventoyrNumber];
        //                if (item.Tpye == ItemTpye.Weapon)
        //                {
        //                    item.equip(player);
        //                    inventories.RemoveAt(InventoyrNumber);
        //                }
        //                else if (item.Tpye == ItemTpye.Armor)
        //                {
        //                    item.equip(player);
        //                    inventories.RemoveAt(InventoyrNumber);
        //                }
        //                else if (item.Tpye == ItemTpye.Accessory)
        //                {
        //                    item.equip(player);
        //                    inventories.RemoveAt(InventoyrNumber);
        //                }
        //                else
        //                {
        //                    Console.WriteLine("착용할 수 없는 아이템 입니다.");
        //                }
        //            }
        //            else
        //            {
        //                Console.WriteLine("아이템이 없습니다.");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("인벤토리가 비었습니다.");
        //        }
        //    }
        //}
    }
}
