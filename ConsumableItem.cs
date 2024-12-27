using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    internal class ConsumableItem : Item
    {
        public ConsumableItem(string name, string description, int health, int mana, int price)
            : base(ItemTpye.Consumable, name, description, price)
        {
            Health = health;
            Mana = mana;
        }
        public override void equip(Character player)
        {
            Console.WriteLine($"{Name}을 사용하시겠습니까?n" +
                $"1. 사용한다, 2 사용하지않는다.");
            {
                var userInput = Console.ReadLine();
                bool PotionUse = true;
                while (PotionUse)
                {
                    if (userInput == "1")
                    {
                        Console.WriteLine($"{Name}을 사용합니다.");
                        if (Health > 0 && Mana == 0)
                        {
                            Console.WriteLine($"체력을 {Health} 회복합니다.");
                            player.Health += Health;
                            PotionUse = false;
                        }
                        else if (Mana > 0 && Health == 0)
                        {
                            Console.WriteLine($"마력을 {Mana} 회복합니다.");
                            player.Mana += Mana;
                            PotionUse = false;
                        }
                    }
                    else if (userInput == "2")
                    {
                        Console.WriteLine("물약을 사용하지 않습니다.");
                        PotionUse = false;
                    }
                    else
                    {
                        Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요.");
                    }
                    
                }
            }
        }

        public override void Unequip(Character player) { }
    }
}
