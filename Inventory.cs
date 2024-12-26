using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    internal class Inventory
    {

        List<List<Item>> inventories;
        public Inventory()
        {            
            inventories = new List<List<Item>>();
            { 
                inventories.Add(Game.itemManager._WeaponItems);
                inventories.Add(Game.itemManager._ArmorItmes);
                inventories.Add(Game.itemManager._AccessoryItems);
                inventories.Add(Game.itemManager._ConsumableItems);
                inventories.Add(Game.itemManager._OtherItems);
            }
        }
        public void Getitem(ItemTpye itemTpye)
        {
            if (itemTpye == 0)
            {
                inventories[0].Add();
            }
            Console.WriteLine("아이템을 획득하시겠습니까?" +
                "1번, 획득한다, 2번, 버린다.");            
            var inPut = Console.ReadLine();
            if (inPut == "1")
            {
            }
            else if (inPut == "2")
            {

            }



        }
    }
}
