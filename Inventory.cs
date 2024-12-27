﻿using System;
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

        public void SetingItem(Player player)
        {
            Console.WriteLine("몇번째 아이템을 사용 하시겠습니까?\n" +
                "첫번째 아이템은 0부터 시작합니다.");
            Console.WriteLine("숫자 이외의 키 입력시 인벤토리 종료");
            bool itemCheck = int.TryParse(Console.ReadLine(), out int InventoyrNumber);
            if (itemCheck == false)
            {
                Console.WriteLine("인벤토리 나가기");
            }
            else
            {
                if (inventories != null)
                {
                    if (InventoyrNumber >= 0 && InventoyrNumber < inventories.Count)
                    {
                        Item item = inventories[InventoyrNumber];
                        if (item.Tpye == ItemTpye.Weapon)
                        {
                            item.equip(player);
                            inventories.RemoveAt(InventoyrNumber);
                        }
                        else if (item.Tpye == ItemTpye.Armor)
                        {
                            item.equip(player);
                            inventories.RemoveAt(InventoyrNumber);
                        }
                        else if (item.Tpye == ItemTpye.Accessory)
                        {
                            item.equip(player);
                            inventories.RemoveAt(InventoyrNumber);
                        }
                        else if (item.Tpye == ItemTpye.Consumable)
                        {
                            item.equip(player);
                            inventories.RemoveAt(InventoyrNumber);
                        }
                        else
                        {
                            Console.WriteLine("기타아이템은 사용할 수 없습니다.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("아이템이 없습니다.");
                    }
                }
                else
                {
                    Console.WriteLine("인벤토리가 비었습니다.");
                }
            }
        }
    }
}
