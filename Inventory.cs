using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    internal class Inventory
    {

        List<Item> inventories;
        public Inventory()
        {
            inventories = new List<Item>();
            {
                
            }
        }
        public void GetItem(int maptype)
        {
            Random random = new Random();
            int itemType = random.Next(4);
            if (itemType == 0)
            {
                Console.WriteLine(Game.itemManager._WeaponItems[maptype].Name);
            }
            else if (itemType == 1)
            {
                Console.WriteLine(Game.itemManager._ArmorItmes[maptype].Name);
            }
            else if (itemType == 2)
            {
                Console.WriteLine(Game.itemManager._AccessoryItems[maptype].Name);
            }
            else if (itemType == 3)
            {
                Console.WriteLine(Game.itemManager._ConsumableItems[maptype].Name);
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
