using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace DirectoryInfo1 
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\WebServers ");

            DirectoryInfo[] q = d.GetDirectories(); //Массив папок

            foreach(DirectoryInfo s in q )//форичем перебираем все папки
            {
                Console.WriteLine(s.Name);//выводим
            }
            Console.ReadKey();
        }
    }
}
