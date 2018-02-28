using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class StatusBar
    {
        public static void PrintInfo(string info)
        {
            Console.SetCursorPosition((Console.WindowWidth) / 2 - 5, (Console.WindowHeight) / 2 + 8);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Black;
            
            Console.Write(info);
            
        }
    }
}
