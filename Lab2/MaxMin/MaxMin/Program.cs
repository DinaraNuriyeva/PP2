using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MaxMin
{
    class Program

    {

        static void Main(string[] args)

        {
            FileStream fs = new FileStream(@"C:\Users\Admin\Desktop\pp2\Lab2\MaxMin\MaxMin\bin\Debug\input.txt", FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            //string text = System.IO.File.ReadAllText(@"C:\Users\Admin\Desktop\pp2\Lab2\MaxMin\MaxMin\bin\Debug\input.txt"); //Читаем текст

            args = text.Split(); //сплитим текст

            int[] n = new int[args.Count()];//заводим массив интов с количеством аргуметнов
           
            
                for (int i = 0; i < args.Length; i++)//заводим цикл 

                {
                    n[i] = int.Parse(args[i]);//и каждый аргумент переводим в инт и сохраняем в массиве интов 
                    

                }
            

            Console.WriteLine(n.Max()); //используем метод для определения макс

            Console.WriteLine(n.Min());//мин

            Console.ReadKey();

        }

    }
}
