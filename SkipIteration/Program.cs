using System;

namespace SkipIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 1, 2, 3, 4, 5, 6, 7 };

            for(int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 0)
                {
                    continue;
             
                }
                Console.Write(number[i]+" ");

            }

            Console.WriteLine();

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i]%3 == 0)
                {
                    continue;

                }
                Console.Write(number[i]+" ");

            }
        }
    }
}
