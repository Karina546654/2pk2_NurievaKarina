using System;
using System.IO;

namespace pz_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string maxLine =null;
            StreamReader reader = new StreamReader("d:\\text.txt");
            {
                string a;
                while (!reader.EndOfStream) //Записываем каждую строку в массив, пока не дойдем до конца файла
                {
                    a = reader.ReadLine();
                    if (maxLine==null || maxLine.Length < a.Length)
                        maxLine = a;
                }
            }
            Console.WriteLine("Самая длинная строка: " + maxLine);
            reader.Close();      
        }
    }
}
