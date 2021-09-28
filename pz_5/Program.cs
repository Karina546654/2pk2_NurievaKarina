using System;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Первое задание
            Console.WriteLine("Задание 1:");
            int a = 10;
            int b = 60;
           
            for (int i = a; i <= b; i += 3)
            {
                Console.WriteLine(i);
            }
            //Второе задание
            Console.WriteLine("Задание 2:");

            char  simv= 'Д';
            for (var i = 0; i < 7; i++)
            {
                Console.WriteLine(simv);
                simv++;
            }
            //Третье задание
            Console.WriteLine("Задание 3:");
            var dd = '#';
            for (int i = 0; i != 9; i++)
            {
                for (int i1 = 0; i1 != 5; i1++)
                {
                    Console.Write(dd);
                }
                Console.WriteLine();
            }
            //Четверое задание
            Console.WriteLine("Задание 4:");
            for (int i = 1; i != 100; i++)
            {
                var k = i % 7;
                if (k == 0)
                {
                    Console.WriteLine(i);
                }
            }
            //Пятое задание
            Console.WriteLine("Задание 5:");

            for (int i = 3, j = 82; Math.Abs(i - j) != 35; i++, j--)
            {
                Console.WriteLine("{0} {1}", i, j);
            }
        }

    }
}