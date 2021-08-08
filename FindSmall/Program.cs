using System;

namespace FindSmall
{

    class Program
    {

       
        static void print2Smallest(int[] arr)
        {
            int first, second;
                
            int arr_size = arr.Length;

  
            if (arr_size < 2)
            {
                Console.Write(" Invalid Input ");
                return;
            }

            first = second = int.MaxValue;

            for (int i = 0; i < arr_size; i++)
            {
               
                if (arr[i] < first)
                {
                    second = first;
                    first = arr[i];
                }

                /* If arr[i] is in between first and second
                then update second */

                else if (arr[i] < second && arr[i] != first)
                    second = arr[i];
            }
            if (second == int.MaxValue)
                Console.Write("There is no second" +
                                "smallest element");
            else
                Console.Write("The smallest element is " +
                                first + " and second Smallest element is " + second);
        }

        /* Driver program to test above functions */
        public static void Main()
        {
            int[] arr = { 12, 13, 1, 10, 34, 1 };
            print2Smallest(arr);
        }
    }
}
