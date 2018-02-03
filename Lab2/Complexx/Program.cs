using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complexx
{
    class Complex //Создаем класс комплекс
    {
        public int a;
        public int b;
        public int GCD(int x, int y)
        {
            while (x != y)
            {
                if (x > y)
                {
                    x = x - y;
                }
                else
                {
                    y = y - x;
                }
            }
            return x;

        }
        public Complex (int ax,int bx)//Нужен конструктор который принимает два параметра
        {
            a = ax;
            b = bx;

        }

        public Complex()//Пустой конструктор нужен потомучто когда мы создаем новый экземпляр ничего не передаем
        {
        }

        public void Simple()
        {
            int z = GCD(this.a, this.b);
            this.a = this.a / z;
            this.b = this.b / z;

        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex m = new Complex();
            m.a = c1.a * c2.b + c2.a * c1.b;
            m.b = c1.b * c2.b;
            m.Simple();
            return m;
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            Complex m  = new Complex();
            m.a = c1.a * c2.b -c2.a * c1.b;
            m.b = c1.b * c2.b;
            m.Simple();
            return m;
        }
        public override string ToString()//оверрайд с методом тустринг чтоб вывести строковое отображение
        {
            return a + "/" + b; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(2, 4);
            Complex c2 = new Complex(5, 2);
            Complex add = c1 + c2;
            Complex sub = c1 - c2;

            Console.WriteLine(add);
            Console.WriteLine(sub);
            Console.ReadKey();
        }
    }
}
