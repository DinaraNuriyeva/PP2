using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakee
{
    class StatusBar
    {
        public static void ShowInfo(string info)
        {
            Console.SetCursorPosition(0, 46);
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.DarkGray;

            for (int i = 0; i < 52; ++i)
            {
                for (int j = 49; j <= 51; ++j)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(' ');
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(20, 50);
            Console.Write(info);
        }
    }
}
