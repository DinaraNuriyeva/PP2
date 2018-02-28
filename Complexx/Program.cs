using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Complexx
{
    [Serializable]
    public class Complex //Создаем класс комплекс
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
        public Complex(int ax, int bx)//Нужен конструктор который принимает два параметра
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
            Complex m = new Complex();
            m.a = c1.a * c2.b - c2.a * c1.b;
            m.b = c1.b * c2.b;
            m.Simple();
            return m;
        }
        public override string ToString()//оверрайд с методом тустринг чтоб вывести строковое отображение
        {
            return a + "/" + b;
        }
    }

    [Serializable]
    class Program
    {
        static void f1(Complex a,Complex b)
        {
            List<Complex> list =  new List< Complex > ();
            list.Add(a);
            list.Add(b);
            XmlSerializer xs = new XmlSerializer(typeof(List<Complex>));
            FileStream fs = new FileStream(@"complex.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            
            xs.Serialize(fs, list);
           

            fs.Close();
        }
        static void f3()
        {
            List<Complex> list1 = new List<Complex>();
            FileStream fs = new FileStream(@"complex.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(List<Complex>));
            list1 = xs.Deserialize(fs) as List<Complex>;
            Console.WriteLine(list1.Count);
            string s = "";
            for (int i = 0; i < list1.Count; ++i)
            {
                s += list1[i].ToString() + " ";
            }


            File.WriteAllText(@"C:\Users\Admin\Documents\PP2\PP2\Complexx\doc.txt", s);



            fs.Close();
        }
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string line2 = Console.ReadLine();
            string line3 = Console.ReadLine();
            string line4 = Console.ReadLine();
           /* string[] s = new string[2];
            string[] s2 = new string[2];
            s2 = line2.Split('/');
            s = line.Split('/');*/

            int a = int.Parse(line);
            int b = int.Parse(line2);
            int c = int.Parse(line3);
            int d = int.Parse(line4);
            Complex c1 = new Complex(a, b);
            Complex c2 = new Complex(c, d);
            Complex add = c1 + c2;
            Complex sub = c1 - c2;

            f1(c1,c2);
            f3();
            //Console.ReadKey();

            Console.WriteLine(add);
            Console.WriteLine(sub);
           Console.ReadKey();
        }
    }
}
