using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace snake
{
    class Menu
    {
     
        public string[] items = { "New Game", "Load Level", "Save Game", "Settings", "Exit" };
        int SelectdItemIndex = 0;
       
        void NewGame()
        {
            
            StatusBar.PrintInfo("New Game!");
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Game g = new Game();
            
            g.Start();
            
            g.SetupBoard();
           
            while (true)
            {
                ConsoleKeyInfo pressedButton = Console.ReadKey();
               
                g.Process(pressedButton);
                
            }


        }
        void LoadLevel()
        {
            
            StatusBar.PrintInfo("Load Game!");

        }
        void SaveGame()
        {
            
            StatusBar.PrintInfo("Save Game!");

        }
        void Settings()
        {
            
            StatusBar.PrintInfo("Settings!");


        }
        void Exit()
        {
            
            StatusBar.PrintInfo("Exit!");
            
            Environment.Exit(0);
            

        }

        public void Centered(string args)
        {
            int width = Console.WindowWidth;
            if (args.Length<width)
            {
                args = args.PadLeft((width - args.Length) / 2 + args.Length, ' ');
            }
            Console.WriteLine(args);
        }
        
        public void Draw()
        {

            Console.SetCursorPosition(0, (Console.WindowHeight)/2-items.Length);
            Console.ForegroundColor = ConsoleColor.Black; 
            Console.BackgroundColor = ConsoleColor.Black;
            

            for (int i = 0; i < items.Length; ++i)
            {
                if (i == SelectdItemIndex)
                {
                    
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                }

                Centered((String.Format("{0}.{1}", i, items[i])));
                
                
            }
        }

       


        public void Process1(ConsoleKeyInfo pressedButton)
        {
            switch (pressedButton.Key)
                {
                    case ConsoleKey.UpArrow:
                        SelectdItemIndex--;
                        if (SelectdItemIndex < 0)
                        {
                            SelectdItemIndex = items.Length - 1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        SelectdItemIndex++;
                        if (SelectdItemIndex >= items.Length)
                        {
                            SelectdItemIndex = 0;
                        }
                        break;
                    case ConsoleKey.Enter:

                        switch (SelectdItemIndex)
                        {
                        case 0:
                            NewGame();
                            break;
                        case 1:
                            LoadLevel();
                            break;
                        case 2:
                            SaveGame();
                            break;
                        case 3:
                            Settings();
                            break;
                        case 4:
                            Exit();
                            break;

                    }
                    break;
                   
                
            }
            
            Draw();

            
        }
    
    }
}



