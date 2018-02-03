using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student1
{
    class Student
    {
        string name;
        string sname;
        double gpa = -1;
        public void ReadInfo()
        {
            name = Console.ReadLine();
            sname = Console.ReadLine();
            // gpa = double.Parse(Console.ReadLine(),x);
            string x = Console.ReadLine();

            if (double.TryParse(x, out gpa) == false)
            {
                x = x.Replace('.', ',');
                if (double.TryParse(x, out gpa) == false)
                {
                    Console.WriteLine("error!");
                }
            }
        }
        public void PrintInfo()
        {
            Console.WriteLine(sname + " " + name + " " + gpa);
            //Console.WriteLine(this.sname + " " + this.name + " " + this.gpa);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.ReadInfo();
            s.PrintInfo();
            Console.ReadKey();
        }
    }
}