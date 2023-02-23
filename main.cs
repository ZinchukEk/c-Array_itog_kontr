using System;

namespace MyProgram
{
   public class Program
    {
        public static void Main(string[] args)
        {
            // исходный массив
            string[] arr = new string[] {"Hello", "How", "Are", "You", "Today"};

            // массив на выходе
            string[] arr2 = new string[arr.Length];

            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length <= 3)
                {
                    arr2[count] = arr[i];
                    count++;
                }
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }
    }
}
