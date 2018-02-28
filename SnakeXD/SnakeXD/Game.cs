using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeXD
{
    public class Game : IDrawable
    {
        public static int WIDTH;
        public static int HEIGTH;
        public static int SPEED;
        Random r = new Random();

        public Game()
        {
            Game.WIDTH = 40;
            Game.HEIGTH = 40;
            Game.SPEED = 300;
            Console.SetWindowSize(Game.WIDTH, Game.HEIGTH);
            Console.SetBufferSize(Game.WIDTH, Game.HEIGTH);
            Console.CursorVisible = false;
        }

        Worm worm = null;
        Wall wall = null;
        Food food = null;
        Thread t = null;

        public void Draw()
        {
            worm.Draw();
            wall.Draw();
        }

        public void Save()
        {
            worm.Save();
            wall.Save();
        }

        public void Load()
        {
            
            worm.LinkToGame(this);

            worm = new Worm(new Point { x = 10, y = 10 },
                           ConsoleColor.Green, '■');
            food = new Food(new Point { x = r.Next(0, 34), y = r.Next(0, 34) },
                          ConsoleColor.Red, '$');
            wall = new Wall(null, ConsoleColor.White, '#');
           // food.Generate();
           // worm.Generate();
           // wall.Generate();
            worm.Draw();
            wall.Draw();
            food.Draw();
        }

        public bool CanEat()
        {
            if (worm.body[0].Equals(food.body[0]))
            {
                worm.body.Add(food.body[0]);
                return true;
            }
            return false;
        }



        public void Start()
        {
            Load();

            t = new Thread(new ThreadStart(worm.Move));

            t.IsBackground = true;
            t.Start();


            while (true)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                switch (pressedKey.Key)
                {
                    case ConsoleKey.F3:
                        wall = wall.Load() as Wall;
                        worm = worm.Load() as Worm;
                        worm.LinkToGame(this);
                        t.Abort();

                        t = new Thread(new ThreadStart(worm.Move));
                        t.IsBackground = true;
                        t.Start();

                        break;
                    case ConsoleKey.F2:
                        this.Save();
                        break;
                    case ConsoleKey.UpArrow:
                        worm.dx = 0;
                        worm.dy = -1;
                        break;
                    case ConsoleKey.DownArrow:
                        worm.dx = 0;
                        worm.dy = 1;
                        break;
                    case ConsoleKey.LeftArrow:
                        worm.dx = -1;
                        worm.dy = 0;
                        break;
                    case ConsoleKey.RightArrow:
                        worm.dx = 1;
                        worm.dy = 0;
                        break;
                    case ConsoleKey.Escape:
                        break;
                }
            }
        }

    }
}
