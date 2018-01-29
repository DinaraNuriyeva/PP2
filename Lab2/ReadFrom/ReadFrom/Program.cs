using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\test\text.txt");
            System.Console.WriteLine("{0}", text);
            Console.ReadKey();
        }
    }
}
