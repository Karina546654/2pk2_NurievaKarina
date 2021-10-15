using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 1;

            //заполняем случайными числами от 0 до 100
            Random random = new Random();
            //Задаём случайный размер от 2х2 до 10х10
            int r = random.Next(2, 11);
            int[,] Matrix = new int[r, r];
            int rand;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    rand = random.Next(0, 100);
                    Matrix[i, j] = rand;
                }
            }


            //Выводим матрицу на экран
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();

                {
                    int j;

                    for (i = 0; i < Matrix.GetLength(0); i++)
                    {
                        Console.WriteLine();
                        for (j = 0; j < Matrix.GetLength(1); j++)
                        {
                            Console.Write(Matrix[i, j] + " ");
                            if (i == j) s *= Matrix[i, j];
                        }
                    }
                    Console.WriteLine();
                    Console.Write("Произведение элементов " + s);
                }
            }
        }
    }
}