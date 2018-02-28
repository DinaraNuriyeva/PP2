using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.SetWindowSize(Game.boardW, Game.boardH);
            Console.SetBufferSize(Game.boardW, Game.boardH);
            Console.CursorVisible = false;

            Menu m = new Menu();
            Frame f = new Frame();
             m.Draw();
            f.DrawFrame();
            while (true)
            {
               
                ConsoleKeyInfo pressedButton = Console.ReadKey();
               
                m.Process1(pressedButton);
                f.DrawFrame();


            }
        }
    }
}