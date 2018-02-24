using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
         static void Main(string[] args)
         {
            
            Console.SetWindowSize(Game.boardW, Game.boardH);
            Console.SetBufferSize(Game.boardW, Game.boardH);
            Console.CursorVisible = false;

            // Menu m = new Menu();
            // m.Draw();
            // Frame f = new Frame();
            // f.DrawFrame();
            Game g = new Game();

            g.Start();

            g.SetupBoard();

            while (true)
            {
                ConsoleKeyInfo pressedButton = Console.ReadKey();

                g.Process(pressedButton);

            }
            
            /* while (true)
             {
                 ConsoleKeyInfo pressedButton = Console.ReadKey();
                 m.Process1(pressedButton);

                // f.DrawFrame();
             }*/

        }
    }
}

