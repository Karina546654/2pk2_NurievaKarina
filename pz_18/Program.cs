using System;

namespace pz_18
{
    class Program
    {
        static void Main(string[] args)
        {   //з1
            double a = 6;
            double d = 2;
            Console.Write("Задание1. Введите значение n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Arifm(n,a,d));
            //з2
            double b = 10;
            double q = 5;
            Console.Write("Задание2. Введите значение с: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(Arifm(c, b, q));
            //з3
            Console.WriteLine("Задание3. ");
            int a1 = 1;
            int b1 = -77;

            Recurs(a1, b1);
            Console.WriteLine(Recurs(a1,b1));


        }
        //задание 1
        static double Arifm( int n, double a, double d)
        {
            if (n < 1) return 0;
            else if (n == 1) return a; 
            return Arifm(n - 1, a, d) + d;
           
        }
        
        //задание 2 
        static double GeoProgress (int с, double b,double q)
        { 
            if (с == 1) return b;
            else return q*GeoProgress(с - 1, b, q);

        }
        //задание 3
        static String Recurs(int a1, int b1)
        {

            if (a1 > b1)
            {
                return a1 + " " + Recurs(a1 - 1, b1); //порядок убывания
            }

            if (b1 > a1)
            {
                return a1 + " " + Recurs(a1 + 1, b1); //порядок возрастания
            }
            else
            {
                return ($"{a1}");
            }

        }
    }
}
