using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{

    class Student
    {
        public string name;
        public string sname;
        public double gpa=-1;


        public Student(string name, string sname, double gpa)
        {
            this.name = name;
            this.sname = sname;
            this.gpa = gpa;
        }

        public Student()
        {
        }

        public void ReadInfo()
        {
            name = Console.ReadLine();
            sname = Console.ReadLine();
            string x = Console.ReadLine();
            if(double.TryParse(x, out gpa) == false)
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
            Console.WriteLine(name + " "+sname+" " + gpa);
        }
        public override string ToString()
        {
            return this.sname+" "+name+" "+gpa;
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
