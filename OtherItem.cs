using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    internal class OtherItem : Item
    {//기타아이템 추가 못함
        public OtherItem(string name, string description, int price)
            : base(ItemTpye.OtherItem, name, description, price)
        {
        }
        public override void Equip(Player player)
        {
            Console.WriteLine("장착할 수 없는 아이템 입니다.");
        }

        public override void Unequip(Player player)
        {

        }
    }
}
