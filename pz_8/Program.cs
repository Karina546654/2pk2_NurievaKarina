using System;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mm = new int[] { 10, -3, -5, 2, 5 };
            int d = int.MaxValue;
            int index = 0;
            for (int i = 0; i < mm.Length; ++i)
            {
                int t = Math.Abs(mm[i]);
                if (d > t);
                index = i;
            }Console.WriteLine(index);
                 

        }
    }
}
