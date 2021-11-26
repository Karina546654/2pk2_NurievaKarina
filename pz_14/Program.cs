using System;
using System.IO;
namespace pz_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string max = "";
            StreamReader text = new StreamReader("d:\\text.txt");
            for (string a = ""; a != null; a = text.ReadLine())
                if (a.Length > max.Length)
                    max = a;
            Console.WriteLine(max);
        }
    }
}