using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace center
{
     public  string s;

    public static void WriteLineCentered(string text)
    {
        int width = Console.WindowWidth;
        if (text.Length < width)
        {
            text = text.PadLeft((width - text.Length) / 2 + text.Length, ' ');
        }
        Console.WriteLine(text);
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
