using System;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if (i == 1&&j == 0|| i == 3&&j==0 || i == 5&&j==0 || i == 7 &&j==0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
        }
    }
}
