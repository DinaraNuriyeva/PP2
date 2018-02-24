using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    enum GameLevel
    {   
        First,
        Second,
        Bonus
    }

    class Game
    {
        public static int speed = 300;
        public static int boardW = 60;
        public static int boardH = 35;
        //Score s = new Score();

        bool[,] field = new bool[10, 10];

        Worm worm;
        Food food;
        Wall wall;
        public bool isAlive;

        GameLevel gameLevel;
        Random r = new Random();

        public void ReachBoard()
        {
            while (true)
            {


                if (worm.body[0].Y > boardH - 1)
                {

                    worm.body[0].Y = 0;
                }
                if (worm.body[0].Y < 0)
                {
                    worm.body[0].Y = boardH - 1;
                }
                if (worm.body[0].X > boardW - 1)
                {
                    worm.body[0].X = 0;
                }
                if (worm.body[0].X < 0)
                {
                    worm.body[0].X = boardW - 1;
                }
            }
        }

       // List<GameObject> g_objects = new List<GameObject>();
       
        public void SetupBoard()
        {
            Console.SetWindowSize(Game.boardW, Game.boardH);
            Console.SetBufferSize(Game.boardW, Game.boardH);
            Console.CursorVisible = false;
        }

        public Game()
        {
            isAlive = true;
            gameLevel = GameLevel.First;

            worm = new Worm(new Point { X = 10, Y = 10 },
                            ConsoleColor.Green, '@');
            food = new Food(new Point { X = r.Next(0,34), Y = r.Next(0,34)  },
                           ConsoleColor.Red, '6');
            wall = new Wall(null, ConsoleColor.DarkMagenta, '#');

            wall.LoadLevel(GameLevel.First);
            food.Draw();
            worm.Draw();
            wall.Draw();
           // g_objects.Add(worm);
              //g_objects.Add(food);
            //g_objects.Add(wall);
        }


        public void Start()
        {
            ThreadStart ts = new ThreadStart(Draw);
            Thread t = new Thread(ts);
            t.Start();
        }
       
        public void Draw()
        {
            while (true)
            {
                worm.Move();

                ReachBoard();
                if (worm.body[0].Equals(food.body[0]))
                {
                   
                    worm.body.Add(new Point { X = food.body[0].X, Y = food.body[0].Y });
                    food.body[0].X = r.Next(0, 34);
                    food.body[0].Y = r.Next(0, 34);
                }
                
                else
                {
                    foreach (Point p in wall.body)
                    {

                        if (p.Equals(worm.body[0]))
                        {
                            Console.Clear();
                            Console.WriteLine("GAME OVER!!!");
                            isAlive = false;
                            break;
                        }
                    }
                   
                }
                
                Console.Clear();
                foreach (GameObject g in g_objects)
                {
                    g.Draw();

                }
                Thread.Sleep(Game.speed);

            }
        }

        public void Exit()
        {

        }
       
        public void Process(ConsoleKeyInfo pressedButton)
        {
            switch (pressedButton.Key)
            {
                case ConsoleKey.UpArrow:
                    worm.Clear();
                    worm.DX = 0;
                    worm.DY = -1;
                    break;
                case ConsoleKey.DownArrow:
                   worm.Clear();
                    worm.DX = 0;
                    worm.DY = 1;
                    break;
                case ConsoleKey.LeftArrow:
                    worm.Clear();
                    worm.DX = -1;
                    worm.DY = 0;
                    break;
                case ConsoleKey.RightArrow:
                   worm.Clear();
                    worm.DX = 1;
                    worm.DY = 0;
                    break;
                case ConsoleKey.Escape:
                    break;
                case ConsoleKey.F2:
                    worm.Save();
                    food.Save();
                    break;
                case ConsoleKey.F1:
                    worm = worm.Load() as Worm;
                    food = food.Load() as Food;
                    
                    break;
              

            }
            
            
           
        }
    }
}