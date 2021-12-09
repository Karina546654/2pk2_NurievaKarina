using System;
using System.Linq;

namespace pz_17
{
    class Program {
        static int GetMedian(int[] arr)
        {
             var s = arr.Sum();
             var ser = 0;
              for (int i = 0; i < arr.Length; i++)  
             {
               ser += arr[i];
               if (ser >= s / 2)
               return i;  
             }
              return arr.Length;

        }
          // в гет медиан метод 
          // массив
          //сортирует по возрастанию и элемент  по середине
        static void Main(string[] args)

        {
            var rnd = new Random();
            var arr = new int[7];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(7);
                Console.WriteLine(arr[i] + " ");
            }

            var med = GetMedian(arr);
            Console.WriteLine("Медиана равна: " + med);
        }
    }
}
