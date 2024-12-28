using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    static class Eraser
    {
        static string a = " ";

        public static void Init()
        {
            for (int i = 0; i < Console.WindowWidth-1; i++)
            {
                a = a + " ";                
            }            
        }
        
        
        public static void Clear()
        {
            Eraser.Init();
            int height = 50;
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < height; i++)
            {                
                Console.WriteLine($"{a}");
            }

            Console.SetCursorPosition(0, 0);
        }
    }
}
