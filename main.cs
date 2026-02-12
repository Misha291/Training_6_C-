using System;
using System.Diagnostics.Metrics;

namespace tran6
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int random_chislo = rand.Next(1, 101);

            int chislo = 0;
            int count = 0;

            while (chislo != random_chislo)
            {
                Console.Write("Угадайте число от 1 до 100: ");
                chislo = int.Parse(Console.ReadLine());
                count++;

                if (chislo > random_chislo)
                {
                    Console.WriteLine("Меньше");
                }

                else if (chislo < random_chislo)
                {
                    Console.WriteLine("Больше");
                }

                else if (chislo == random_chislo)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Правильно! Вы угадали за {count} попытки.");
                    break;
                }
            }
            Console.ReadKey();
        }

    }

}
