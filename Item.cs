using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    public enum ItemTpye
    {
        Weapon, Armor, Accessory, Consumable, OtherItem
    }    
    public abstract class Item 
    {
        private ItemTpye weapon;

        public ItemTpye Tpye { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Damage { get; set; }
        public double Critical { get; set; }
        public double CriticalDam { get; set; }
        public int Armor { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Mana { get; set; }
        public int MaxMana { get; set; }
        protected Item(ItemTpye type, string name, string description, int price)
        {
            Tpye = type;
            Name = name;
            Description = description;            
            Price = price;
        }


        public virtual void ItemStats()
        {
            Console.WriteLine($"이름: {Name}, 타입: {Tpye}, 설명: \n{Description}\n 가격: {Price}");
        }
        public abstract void equip(Character player);
        public abstract void Unequip(Character player);
    }
}
