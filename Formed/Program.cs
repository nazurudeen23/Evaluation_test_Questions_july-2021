using System;

namespace Formed
{
    class Program
    {
        static int MAX = 256;
        static bool canMakeStr2(string str1, string str2)
        {
            int[] count = new int[MAX];
            for (int i = 0; i < str1.Length; i++)
                count[str1[i]]++;

 
            for (int i = 0; i < str2.Length; i++)
            {
                if (count[str2[i]] == 0)
                    return false;
                count[str2[i]]--;
            }
            return true;
        }
            static void Main(string[] args)
        {

            string str1 = "Include Help";
            string str2 = "Help";
            if (canMakeStr2(str1, str2))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
