using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class Circle
    {
        private double a;

        public Circle (double a)
        {
            this.a = a;
        }
        public const double  pi= 3.14;
        public double Area()
        {
            return pi * a * a;

        }
        public double Circ()
        {
            return 2 * pi * a;
        }
        public double Diam()
        {
            return 2 * a;

        }
       
    }
  
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            Circle c = new Circle(x);
            Console.WriteLine(c.Area());
            Console.WriteLine(c.Circ());
            Console.WriteLine(c.Diam());
            Console.ReadKey();
        }
    }
}
