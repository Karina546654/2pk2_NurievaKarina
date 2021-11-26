using System;

namespace pz_13
{
    class Program
    {
        public enum Sc //объявляем перечисления
        {
            Плохо = 1, Неудовлетворительно = 2, Удовлетворительно = 3,
            Хорошо = 4, Отлично = 5
        }
    public static void Main(string[] args) { 
        Console.Write("Выберите оценку "); //просим пользователя ввести оценку
        int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case (int)Sc.Плохо:
                Console.WriteLine("плохо");
                break;

                case (int)Sc.Неудовлетворительно:
                    Console.WriteLine("неудовлетворительно");
                    break;
                case (int)Sc.Удовлетворительно:
                    Console.WriteLine("удовлетворительно");
                    break;
                case (int)Sc.Хорошо:
                    Console.WriteLine("хорошо");
                    break;
                case (int)Sc.Отлично:
                    Console.WriteLine("отлично");
                    break;
            }
        }
    }
}