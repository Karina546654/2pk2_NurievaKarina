using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1;
            double y;
            while (x <= 3)
            {
                x += 0.2;
                y = (8 * x) + (4 * (Math.Pow(x, 4))) - (1.5 * (Math.Pow(x, 3)));
                Console.WriteLine(y);
            }
        }
    }
}
