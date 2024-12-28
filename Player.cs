using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Temp
{
    public delegate void EquipItemReturn(Player player, Item item);
    public class Player : Character
    {
        public bool Mainstory;
        public Inventory playerinventory {  get; set; }
        public Equipment Equipment { get; set; }
        public Player(string name, int level) : base(name, 100, 10, 5)
        {
            Name = name;
            Level = level;
            MaxHealth = 300;
            MaxMana = 100;
            Health = MaxHealth;
            Mana = MaxMana;
            Damage = 50;
            Armor = 5;
            Critical = 5;
            CriticalDam = (Damage * 1.5);
            Gold = 0;
            
            MaxGold = 999_999_999;
            Exp = 0;
            MaxExp = 0;

            playerinventory = new Inventory();
            Equipment = new Equipment();            
        }

        public void EquimentItem(Item item)
        {            
            if (item.Tpye == ItemTpye.Weapon)
            {
                Equipment.Equip[ItemTpye.Weapon] = item;                
            }
            else if (item.Tpye == ItemTpye.Armor)
            {
                Equipment.Equip[ItemTpye.Armor] = item;                
            }
            else if (item.Tpye == ItemTpye.Accessory)
            {
                Equipment.Equip[ItemTpye.Accessory] = item;                
            }            
        }

        public void ReturnInven(Player player, Item item)
        {            
            //
            if (item.Tpye == ItemTpye.Weapon)
            {
                playerinventory.inventories.Add(Equipment.Equip[ItemTpye.Weapon]);
                Equipment.Equip[ItemTpye.Weapon].Unequip(player);
            }
            else if (item.Tpye == ItemTpye.Armor)
            {
                playerinventory.inventories.Add(Equipment.Equip[ItemTpye.Armor]);
                Equipment.Equip[ItemTpye.Armor].Unequip(player);
            }
            else if (item.Tpye == ItemTpye.Accessory)
            {
                playerinventory.inventories.Add(Equipment.Equip[ItemTpye.Accessory]);
                Equipment.Equip[ItemTpye.Accessory].Unequip(player);
            }
            else
            {
                return;
            }
        }

        public void EquimentGetItem(Player player, bool start)
        {
            Eraser.Clear();
            EquipItemReturn equipItemReturn = (p, i) =>
            {//델리게이트를 사용하여 함수를 한번에 호출해서 if문안의 내용을 줄임
                i.Unequip(p);
                Console.WriteLine();
                EquimentItem(i);
                Console.WriteLine();
                playerinventory.inventories.Add(i);
                Console.ReadKey(true);
            };
            Console.WriteLine("장비창");
            Console.WriteLine("무엇을 빼시겠습니까?");
            Console.WriteLine($"\n" +
                $"1번. 무기 : {Equipment.Equip[ItemTpye.Weapon]?.Name}\n" +
                $"2번. 방어구 : {Equipment.Equip[ItemTpye.Armor]?.Name}\n" +
                $"3번. 장신구 : {Equipment.Equip[ItemTpye.Accessory]?.Name}\n");
            Console.WriteLine("1,2,3 이외의 키 입력시 장비창 종료");                
            while (start)
            {
                var input = Console.ReadLine();
                if (input == "1")
                {
                    if (Equipment.Equip[ItemTpye.Weapon] != null)
                    {
                        Item item = Equipment.Equip[ItemTpye.Weapon];
                        equipItemReturn(player, item);
                        Equipment.Equip[ItemTpye.Weapon] = null;
                        start = false;
                    }
                    else if (Equipment.Equip[ItemTpye.Weapon] == null)
                    {
                        Console.WriteLine("무기창이 비었습니다.");
                    }
                }
                else if (input == "2")
                {
                    if (Equipment.Equip[ItemTpye.Armor] != null)
                    {
                        Item item = Equipment.Equip[ItemTpye.Armor];
                        equipItemReturn(player, item);
                        Equipment.Equip[ItemTpye.Armor] = null;
                        start = false;
                    }
                    else if (Equipment.Equip[ItemTpye.Armor] == null)
                    {
                        Console.WriteLine("방어구창이 비었습니다.");                        
                    }
                }
                else if (input == "3")
                {
                    if (Equipment.Equip[ItemTpye.Accessory] != null)
                    {
                        Item item = Equipment.Equip[ItemTpye.Accessory];
                        equipItemReturn(player, item);
                        Equipment.Equip[ItemTpye.Accessory] = null;
                        start = false;
                    }
                    else if (Equipment.Equip[ItemTpye.Accessory] == null)
                    {
                        Console.WriteLine("장신구창이 비었습니다.");                        
                    }
                }
                else
                {                    
                    start = false;
                    Eraser.Clear();
                }
            }
        }

        //public override void Attack(Character target)
        //{
        //    int actualDamage = Damage - target.Armor;
        //    if (actualDamage < 0)
        //    {
        //        actualDamage = 0;
        //    }
        //    target.Health-= actualDamage;
        //    Console.WriteLine($"{Name}이 {target.Name}에게 {actualDamage}의 데미지를 줌");

        //}

        public void PlayerStats()
        {
            Eraser.Clear();
            Console.WriteLine($"플레이어 스테이터스\n\n" +
                $"이름: {Name}, 레벨: {Level} \n" +
                $"체력: {Health}, 마력: {Mana}, \n" +
                $"공격력: {Damage}, 방어력: {Armor} \n" +
                $"크리티컬확률: {Critical} \n" +
                $"크리티컬데미지: {CriticalDam} \n" +
                $"골드: {Gold}\n" +
                $"경험치: {Exp}\n");

            Console.WriteLine("키 입력시 인벤토리 종료");
            Console.ReadKey(true);
            Eraser.Clear();
        }

        public void LevelUP()
        {
            Level++;
            Damage += 10;
            Armor += 3;
            MaxHealth += 30;
            Health = MaxHealth;
            MaxMana += 10;
            Mana = MaxMana;

            Console.WriteLine($"레벨이 올랐습니다.\n" +
                $"체력과 마력이 모두 회복됩니다.");
        }

        public void ItemGet(Item item)
        {            
            playerinventory.inventories.Add(item); //인벤토리의 앞으로 착착 쌓임
        }
        public void PrintInven() //인벤토리에 뭐가 있는지 보여주는 메서드
        {
            Eraser.Clear();
            Console.WriteLine("플레이어 인벤토리\n" +
                "몇번째 아이템을 사용 하시겠습니까?\n");
            int Number=0;
            foreach (var item in playerinventory.inventories)
            {
                Console.WriteLine($"{Number++}번 아이템 : {item.Name}");
            }
        }
    }
}