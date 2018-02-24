using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    public class Frame
    {
        public  int origRow;
        public  int origCol;

        public  void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(origCol + x, origRow + y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(s);
                Console.ForegroundColor = ConsoleColor.Red;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        public void DrawFrame()
        {
            // Clear the screen, then save the top and left coordinates.
            //Console.Clear();
            origRow = Console.CursorTop;
            origCol = Console.CursorLeft;

            // Draw the left side of a 5x5 rectangle, from top to bottom.
            
            
            WriteAt("#", (Console.WindowWidth) / 2 - 9, (Console.WindowHeight) / 2 -22);
            WriteAt("#", (Console.WindowWidth) / 2 - 9, (Console.WindowHeight) / 2-21);
            WriteAt("#", (Console.WindowWidth) / 2 - 9, (Console.WindowHeight) / 2-20 );
            WriteAt("#", (Console.WindowWidth) / 2 - 9, (Console.WindowHeight) / 2-19 );
            WriteAt("#", (Console.WindowWidth) / 2 - 9, (Console.WindowHeight) / 2 -18);

            // Draw the bottom side, from left to right.
            WriteAt("#", (Console.WindowWidth) / 2 - 9, (Console.WindowHeight) / 2 - 17);
            WriteAt("#", (Console.WindowWidth) / 2 - 8, (Console.WindowHeight) / 2 - 17); // shortcut: WriteAt("---", 1, 4)
            WriteAt("#", (Console.WindowWidth) / 2 - 7, (Console.WindowHeight) / 2 - 17); // ...
            WriteAt("#", (Console.WindowWidth) / 2 - 6, (Console.WindowHeight) / 2 - 17); // ...
            WriteAt("#", (Console.WindowWidth) / 2 - 5, (Console.WindowHeight) / 2 - 17);
            WriteAt("#", (Console.WindowWidth) / 2 - 4, (Console.WindowHeight) / 2 - 17);
            WriteAt("#", (Console.WindowWidth) / 2 - 3, (Console.WindowHeight) / 2 - 17);
            WriteAt("#", (Console.WindowWidth) / 2 - 2, (Console.WindowHeight) / 2 - 17);
            WriteAt("#", (Console.WindowWidth) / 2 - 1, (Console.WindowHeight) / 2 - 17);
            WriteAt("#", (Console.WindowWidth) / 2 , (Console.WindowHeight) / 2 - 17); // shortcut: WriteAt("---", 1, 4)
            WriteAt("#", (Console.WindowWidth) / 2 +1, (Console.WindowHeight) / 2 - 17); // ...
            WriteAt("#", (Console.WindowWidth) / 2 +2, (Console.WindowHeight) / 2 - 17); // ...
            WriteAt("#", (Console.WindowWidth) / 2 +3, (Console.WindowHeight) / 2 - 17);
            WriteAt("#", (Console.WindowWidth) / 2 +4, (Console.WindowHeight) / 2 - 17);
            WriteAt("#", (Console.WindowWidth) / 2 +5, (Console.WindowHeight) / 2 - 17);
            WriteAt("#", (Console.WindowWidth) / 2 +6, (Console.WindowHeight) / 2 - 17);
            WriteAt("#", (Console.WindowWidth) / 2 +7, (Console.WindowHeight) / 2 - 17);
            WriteAt("#", (Console.WindowWidth) / 2 + 8, (Console.WindowHeight) / 2 - 17);

            // Draw the right side, from bottom to top.


            WriteAt("#", (Console.WindowWidth) / 2 + 8, (Console.WindowHeight) / 2 - 22);
            WriteAt("#", (Console.WindowWidth) / 2 + 8, (Console.WindowHeight) / 2 - 21);
            WriteAt("#", (Console.WindowWidth) / 2 + 8, (Console.WindowHeight) / 2 - 20);
            WriteAt("#", (Console.WindowWidth) / 2+8,(Console.WindowHeight) / 2 - 19);
            WriteAt("#", (Console.WindowWidth) / 2 +8, (Console.WindowHeight) / 2 - 18);


            // Draw the top side, from right to left.
            WriteAt("#", (Console.WindowWidth) / 2 - 9, (Console.WindowHeight) / 2 - 23);
            WriteAt("#", (Console.WindowWidth) / 2 - 8, (Console.WindowHeight) / 2-23); // shortcut: WriteAt("---", 1, 4)
            WriteAt("#", (Console.WindowWidth) / 2 - 7, (Console.WindowHeight) / 2 - 23); // ...
            WriteAt("#", (Console.WindowWidth) / 2 - 6, (Console.WindowHeight) / 2 - 23); // ...
            WriteAt("#", (Console.WindowWidth) / 2 - 5, (Console.WindowHeight) / 2 - 23);
            WriteAt("#", (Console.WindowWidth) / 2 - 4, (Console.WindowHeight) / 2 - 23);
            WriteAt("#", (Console.WindowWidth) / 2 - 3, (Console.WindowHeight) / 2 - 23);
            WriteAt("#", (Console.WindowWidth) / 2 - 2, (Console.WindowHeight) / 2 - 23);
            WriteAt("#", (Console.WindowWidth) / 2 - 1, (Console.WindowHeight) / 2 - 23);
            WriteAt("#", (Console.WindowWidth) / 2, (Console.WindowHeight) / 2 - 23); // shortcut: WriteAt("---", 1, 4)
            WriteAt("#", (Console.WindowWidth) / 2 + 1, (Console.WindowHeight) / 2 - 23); // ...
            WriteAt("#", (Console.WindowWidth) / 2 + 2, (Console.WindowHeight) / 2 - 23); // ...
            WriteAt("#", (Console.WindowWidth) / 2 + 3, (Console.WindowHeight) / 2 - 23);
            WriteAt("#", (Console.WindowWidth) / 2 + 4, (Console.WindowHeight) / 2 - 23);
            WriteAt("#", (Console.WindowWidth) / 2 + 5, (Console.WindowHeight) / 2 - 23);
            WriteAt("#", (Console.WindowWidth) / 2 + 6, (Console.WindowHeight) / 2 - 23);
            WriteAt("#", (Console.WindowWidth) / 2 + 7, (Console.WindowHeight) / 2 - 23);
            WriteAt("#", (Console.WindowWidth) / 2 + 8, (Console.WindowHeight) / 2 - 23);
            // WriteAt("All done!", 0, 6);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
