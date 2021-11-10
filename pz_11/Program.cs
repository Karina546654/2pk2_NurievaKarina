using System;

namespace pz_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //19 Вариант Нуриева
            Console.Write("Введите строку: ");
            string text = Console.ReadLine();
            //удаляем пробелы 
            text = text.Trim();

            //заносим в массив слова, разделённые пробелом
            string[] Arr = text.Split(' ');

            int min = 999999;


            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i].Length < min) min = Arr[i].Length;

            }
            //Вывод
            Console.WriteLine("Самое короткое слово: {0}", min);
            Console.ReadKey();
        }
    }
}