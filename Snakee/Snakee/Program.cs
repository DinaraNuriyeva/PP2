using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Snakee
{
   class Program
{


    public static int level = 1;
    public static string dir = "Right";
    public static Thread forTimer;
    public static Thread Direction = new Thread(new ParameterizedThreadStart(move));
    //public static Timer time = new Timer(new TimerCallback(seconding), st, 0, 1000);


    public static int seconds = 0;
    public static int minuts = 0;
    /*private static int st;

    public static void seconding(object st)
    {

            seconds++;
            minuts++;
            if (seconds == 60)
            {
                seconds = 0;
            }


        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(3, 47);
        Console.WriteLine("Time " + minuts + " : " + seconds);

    }*/
   public static void timer(object obj)
    {
        while (Game.isActive)
        {
            seconds++;
            if (seconds == 60)
            {
                minuts++;
                seconds = 0;
            }
            Thread.Sleep(1000);
        }

    }




   static void Main(string[] args)
    {

        MainFunction();
    }

   public static void MainFunction()
    {
        //Menu menu = new Menu();
        //menu.Draw();
        Game.Init();
        Game.LoadlLevel(level);
        Game.snake.Draw();
        Direction = new Thread(new ParameterizedThreadStart(move));
        forTimer = new Thread(new ParameterizedThreadStart(timer));
        Direction.Start();
        forTimer.Start();
        while (Game.isActive)
        {
            ConsoleKeyInfo pressedKey = Console.ReadKey();
            switch (pressedKey.Key)
            {
                case ConsoleKey.UpArrow:
                    dir = "Up";
                    break;
                case ConsoleKey.DownArrow:
                    dir = "Down";
                    break;
                case ConsoleKey.LeftArrow:
                    dir = "Left";
                    break;
                case ConsoleKey.RightArrow:
                    dir = "Right";
                    break;
                case ConsoleKey.Escape:
                    Game.isActive = false;
                    break;
                case ConsoleKey.F2:
                    Game.Save();
                    break;
                case ConsoleKey.F3:
                    Game.Resume();
                    break;
            }
        }
        Direction.Abort();
        forTimer.Abort();
        MainFunction();
    }
   public static void move(object obj) // основы
  
    {
            while (Game.isActive)
            {

                switch (dir)// меняем положение 
                {
                    case "Up":
                        Game.snake.Move(0, -1);
                        break;
                    case "Down":
                        Game.snake.Move(0, 1);
                        break;
                    case "Left":
                        Game.snake.Move(-1, 0);
                        break;
                    case "Right":
                        Game.snake.Move(1, 0);
                        break;

                }

                  Game.Draw();
                Thread.Sleep(200);

            }
        }

    }
}