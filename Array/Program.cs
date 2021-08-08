using System;
using System.Collections.Generic;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            Array ar = new Array();
            ar.ArrayOfMultiple(5, 3);
            
        }

    }

    class Array
    {

        public void ArrayOfMultiple(int n1, int n2)
        {

            for (int i = 1; i <= n2; i++)
            {
                Console.WriteLine(i * n1);
            }
           
        }
    }
}
