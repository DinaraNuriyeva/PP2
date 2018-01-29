using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FileInfo1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\WebServers");
            FileInfo[] f = d.GetFiles();//Массив файлов
            foreach (FileInfo fi in f)
            {
                Console.WriteLine(fi.Name);
            }
            Console.ReadKey();

        }
    }
}
