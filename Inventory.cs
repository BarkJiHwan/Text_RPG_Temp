using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Temp
{
    public class Inventory
    {
        public List<Item> inventories { get; set; }
        public Item item;
        public Inventory()
        {
            inventories = new List<Item>();
            {

            }
        }

        public void SetingItem(Player player) //인벤토리 기능
        {
            Console.WriteLine("몇번째 아이템을 사용 하시겠습니까?\n" +
                "첫번째 아이템은 0부터 시작합니다.");
            Console.WriteLine("숫자 이외의 키 입력시 인벤토리 종료");
            bool itemCheck = int.TryParse(Console.ReadLine(), out int InventoryIndex);
            if (itemCheck == false)
            {
                Console.WriteLine("인벤토리 나가기");
            }
            else
            {
                if (player.playerinventory.inventories.Count != 0)
                {
                    //여기부분 오류 생김 예외처리가 삭제 됐음
                        Item item = inventories[InventoryIndex];
                        if (item.Tpye == ItemTpye.Weapon)
                        {
                            if (player.Equipment.Equip[ItemTpye.Weapon] != null)
                            {
                                player.ReturnInven(player);
                                player.EquimentItem(item); //장비창에 장착 시킴
                                item.Equip(player); //장비에 따른 플레이어 능력치 증가
                                inventories.RemoveAt(InventoryIndex);
                            }
                            else if (player.Equipment.Equip[ItemTpye.Weapon] == null)
                            {
                                player.EquimentItem(item);
                                item.Equip(player);
                                inventories.RemoveAt(InventoryIndex);
                            }
                        }
                        else if (item.Tpye == ItemTpye.Armor)
                        {
                            if (player.Equipment.Equip[ItemTpye.Armor] != null)
                            {
                                player.ReturnInven(player);
                                player.EquimentItem(item);
                                item.Equip(player);
                                inventories.RemoveAt(InventoryIndex);
                            }
                            else if (player.Equipment.Equip[ItemTpye.Armor] == null)
                            {
                                player.EquimentItem(item);
                                item.Equip(player);
                                inventories.RemoveAt(InventoryIndex);
                            }
                        }
                        else if (item.Tpye == ItemTpye.Accessory)
                        {
                            if (player.Equipment.Equip[ItemTpye.Accessory] != null)
                            {
                                player.ReturnInven(player);                                
                                player.EquimentItem(item);
                                item.Equip(player);
                                inventories.RemoveAt(InventoryIndex);
                            }
                            else if (player.Equipment.Equip[ItemTpye.Accessory] == null)
                            {
                                player.EquimentItem(item);
                                item.Equip(player);
                                inventories.RemoveAt(InventoryIndex);
                            }
                        }
                        else if (item.Tpye == ItemTpye.Consumable)
                        {
                            item.Equip(player);
                            inventories.RemoveAt(InventoryIndex);
                        }
                        else
                        {
                            Console.WriteLine("기타아이템은 사용할 수 없습니다."); //기타 아이템 추가 못함
                        }
                    }                   
                else
                {
                    Console.WriteLine("해당 번수의 인벤토리가 비었습니다.");
                }
            }
        }
    }
}
