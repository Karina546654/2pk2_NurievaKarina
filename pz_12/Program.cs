﻿using System;

namespace pz_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = " ";
            string a = " "; //Добавим разделение(пробел)
            while (true)
            {
                if (str == "exit") break; //Чтобы досрочно завершить программу

                str += Console.ReadLine() + a; //Прибавляем строку к предыдущей

                Console.WriteLine(str); //Выводим
            }
        }
    }
}