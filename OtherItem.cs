﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    internal class OtherItem : Item
    {
        public OtherItem(string name, string description, int price)
            : base(ItemTpye.OtherItem, name, description, price)
        {
        }
        public override void equip(Character player)
        {
            Console.WriteLine("장착할 수 없는 아이템 입니다.");
        }

        public override void Unequip(Character player)
        {

        }
    }
}