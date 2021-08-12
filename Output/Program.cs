using System;

namespace Output
{
    class Program
    {
        static void Main(string[] args)
        {
            string test1 = "Welcome";
            string test2 = "to Gislen Software";
            string test3 = test2;
            Console.WriteLine((test3 == test2) + " " + (test2.Equals(test3)));   //true    true
            Console.ReadLine();
        }
    }

}

