using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        private int a, b;
        //constructor
        public Rectangle(int a,int b)
        {
            this.a = a;
            this.b = b;
        }

    

        public int Perimeter()//method returns perimetr
        {
            return 2 * a + 2 * b;
        }
        public int Area()//method
        {
            return a * b;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Rectangle rect = new Rectangle(x, y);
            Console.WriteLine(rect.Area());
            Console.WriteLine(rect.Perimeter());
            Console.ReadKey();
            
        }
    }
}
