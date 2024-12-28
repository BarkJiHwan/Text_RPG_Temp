using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Temp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string Textrpg =
                @"

                                  ▐▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▌
                                  ▐ _______        _        _____  _____   _____ ▌
                                  ▐|__   __|      | |      |  __ \|  __ \ / ____|▌
                                  ▐   | | _____  _| |_     | |__) | |__) | |  __ ▌
                                  ▐   | |/ _ \ \/ / __|    |  _  /|  ___/| | |_ |▌
                                  ▐   | |  __/>  <| |_     | | \ \| |    | |__| |▌
                                  ▐   |_|\___/_/\_\\__|    |_|  \_\_|     \_____|▌
                                  ▐        /\   | |                (_)           ▌
                                  ▐       /  \  | | __ _ _ __   ___ _  __ _      ▌
                                  ▐      / /\ \ | |/ _` | '_ \ / __| |/ _` |     ▌
                                  ▐     / ____ \| | (_| | | | | (__| | (_| |     ▌
                                  ▐    /_/    \_\_|\__,_|_| |_|\___|_|\__,_|     ▌
                                  ▐▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▌";

            Console.WriteLine(Textrpg);
            Console.SetCursorPosition(41, 22);
            Console.WriteLine("스페이스바를 눌러 게임 시작하기");
            
            Console.SetCursorPosition(52, 18);
            Console.WriteLine("게임 시작");
            Console.SetCursorPosition(50, 18);
            Console.WriteLine("→");
            Console.SetCursorPosition(50, 18);
            bool start = true;
            while (start)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Spacebar)
                {
                    start = false;
                    Console.WriteLine("  ");
                    Console.SetCursorPosition(50, 18);
                    Thread.Sleep(500);
                    Console.WriteLine("→");
                    Console.SetCursorPosition(50, 18);
                }                
            }
            Thread.Sleep(1000);
            Eraser.Clear();
            Game game = new Game();
            game.Start();
        }
    }
}
