using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace far2
{
    enum FarMode
    {
        Explorer,//режим просмотра
        FileReader//режим чтения
    }

    class FAR
    {
        Stack<Layer> layerHistory = new Stack<Layer>();
        Layer activeLayer;
        FarMode mode = FarMode.Explorer;//изначально режим просмотра
       

        public FAR(string path)
        {
            this.activeLayer = new Layer(path, 0);
        }

        public void Draw()
        {
            switch (mode)
            {
                case FarMode.Explorer:

                    DrawExplorer();

                    break;
                case FarMode.FileReader:

                    DrawFileReader();

                    break;
                default:
                    break;
            }

            DrawStatusBar();
        }

        private void DrawStatusBar()
        {
            Console.SetCursorPosition(4, 38);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(mode);
        }

        private void DrawFileReader() 
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream(activeLayer.GetSelectedItemInfo(), FileMode.Open, FileAccess.Read); //для чтения файла
                sr = new StreamReader(fs);

                Console.WriteLine(sr.ReadToEnd());

            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot open file!");

            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }

                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        private void DrawExplorer()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            for (int i = 0; i < activeLayer.items.Count; ++i)
            {
                if (i == activeLayer.index)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }

                if (activeLayer.items[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                Console.WriteLine(activeLayer.items[i].Name);
            }
        }

        public void Process(ConsoleKeyInfo pressedKey)
        {
            switch (pressedKey.Key)
            {
                case ConsoleKey.UpArrow:
                    activeLayer.Process(-1);
                    break;
                case ConsoleKey.DownArrow:
                    activeLayer.Process(1);
                    break;
                case ConsoleKey.Enter:
                    try
                    {
                        if (activeLayer.items[activeLayer.index].GetType() == typeof(DirectoryInfo))
                        {
                            mode = FarMode.Explorer;
                            layerHistory.Push(activeLayer);
                            activeLayer = new Layer(activeLayer.GetSelectedItemInfo(), 0);
                        }
                        else if (activeLayer.items[activeLayer.index].GetType() == typeof(FileInfo))
                        {
                            mode = FarMode.FileReader;
}
                    }
                    catch (Exception e)
                    {
                        activeLayer = layerHistory.Pop();
                    }
                    break;
                case ConsoleKey.Backspace:
                    if (mode == FarMode.Explorer)
                    {
                        activeLayer = layerHistory.Pop();
                    }
                    else if (mode == FarMode.FileReader)
                    {
                        mode = FarMode.Explorer;
                    }

                    break;
                default:
                    break;
            }

        }
    }
    class Layer
    {
        public DirectoryInfo dirInfo;
        public string path;
        public int index;
        public List<FileSystemInfo> items;

        public Layer(string path, int index)
        {
            this.path = path;
            this.index = index;
            this.dirInfo = new DirectoryInfo(path);

            items = new List<FileSystemInfo>();
            items.AddRange(dirInfo.GetDirectories());
            items.AddRange(dirInfo.GetFiles());

        }

        public void Process(int v)
        {
            this.index += v;
            if (this.index < 0)
            {
                this.index = items.Count - 1;
            }
            if (this.index >= items.Count)
            {
                this.index = 0;
            }
        }

        public string GetSelectedItemInfo()
        {
            return this.items[index].FullName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Environment.GetLogicalDrives();
            Console.SetWindowSize(40, 40);
            FAR far = new FAR(@"C:\WebServers");

            bool quit = false;

            while (!quit)
            {
                far.Draw();
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                switch (pressedKey.Key)
                {
                    case ConsoleKey.Escape:
                        quit = true;
                        break;
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.Backspace:
                    case ConsoleKey.Enter:
                        far.Process(pressedKey);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}