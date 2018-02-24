using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MinPrime
{
    class Program

    {
        static void Main(string[] args)

        {
            List<int> Primes = new List<int>();//лист праймов
            string text = File.ReadAllText(@"C:\Users\Admin\Documents\PP2\PP2\Lab2\MinPrime\MinPrime\bin\Debug\input.txt");//читаем тескт из файла в стринг
            string[] a = text.Split(' ');//сплитим этот текст и закидываем в массив
            int[] n = new int[a.Count()];//заводим массив интов

            for (int i = 0; i < a.Length; i++)
            {
                n[i] = int.Parse(a[i]);//в инт
                bool ok = true;

                for (int j = 2; j * j <= n[i]; j++)//находим праймы
                {
                    if (n[i] % j == 0)
                    {
                        ok = false;
                        break;
                    }

                }
                if (ok & n[i] != 1)//если все нормально 
                {
                    Primes.Add(n[i]);//в лист добавляем праймы

                }

            }
            Primes.Sort();//сортируем этот лист

            if (Primes.Count == 0)//если лист пустой  
            {
                File.WriteAllText(@"C:\Users\Admin\Documents\PP2\PP2\Lab2\MinPrime\MinPrime\bin\Debug\output.txt", "There are no primes");
            } else
            {
                File.WriteAllText(@"C:\Users\Admin\Documents\PP2\PP2\Lab2\MinPrime\MinPrime\bin\Debug\output.txt", Convert.ToString(Primes.Min()));

            }
            //Console.WriteLine(Primes.Min());
            

            for (int i = 0; i < Primes.Count; i++)//заводим цикл и брейком останавливаем прграмму он выведет первый элемент листа который минимальный
            {
                if (Primes.Count > 0)
                {
                    File.WriteAllText(@"C:\Users\Admin\Documents\PP2\PP2\Lab2\MinPrime\MinPrime\bin\Debug\output.txt", Convert.ToString(Primes[i]));

                }
                break;
            }
            Console.ReadKey();

        }

    }

}