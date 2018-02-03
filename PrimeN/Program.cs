using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeN
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine(); //Считываем строку 
            args = line.Split(' '); //Разделяем строку на отдельные аргументы

            foreach (string s in args)// Проходимся по всему аргументу
            {
                int x = int.Parse(s); //Переводим число которое в строке в инт
                bool ok = true; //Заводим бул для проверки на простоту

                for (int i = 2; i * i <= x; i++) //Цикл для проверки
                {
                    if (x % i == 0)
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok & x != 1) //Если все норм
                {
                    Console.WriteLine(x);//Выводим инт
                }
                ok = true;
            }
            Console.ReadKey();//Чтоб не закрывалась консоль

        }
    }
}
