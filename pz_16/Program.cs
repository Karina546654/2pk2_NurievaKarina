using System;

namespace pz_16
{
    class Program
    {
        static void Pra( int a, int b, int c) {

            if (a < b && a < c && b < c)
                Console.WriteLine("{0},{1},{2}", c, b, a);
            if (a < b && a < c && c < b)
                Console.WriteLine("{0},{1},{2}", b, c, a);
            if (b < a && b < c && a < c)
                Console.WriteLine("{0},{1},{2}", c, a, b);
            if (b < a && b < c && c < a)
                Console.WriteLine("{0},{1},{2}", a, c, b);
            if (c < a && c < b && a < b)
                Console.WriteLine("{0},{1},{2}", b, a, c);
            if (c < a && c < b && b < a)
                Console.WriteLine("{0},{1},{2}", a, b, c);
        }

        static void Main(string[] args)
        {
            int a, b, c;
          
            Console.WriteLine("Введите значение a: ");

            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение b: ");

            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение c: ");

            c = int.Parse(Console.ReadLine());

            Pra(a, b, c);

            Console.ReadLine();
        }
    }
}
