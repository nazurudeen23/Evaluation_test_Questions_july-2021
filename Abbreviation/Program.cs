
using System;

namespace Abbreviation
{
    class Program
    {
        public static string GetAbbreviation(string str)
        {
            char[] tempArray = new char[str.Length];
            string abbr = "";
            int loop = 0;


            tempArray = str.ToCharArray();

            abbr += (char)((int)tempArray[0] ^ 32);
            abbr += '.';

            for (loop = 0; loop < str.Length - 1; loop++)
            {
                if (tempArray[loop] == ' ' || tempArray[loop] == '\t' || tempArray[loop] == '\n')
                {

                    abbr += (char)((int)tempArray[loop + 1] ^ 32);
                    abbr += '.';
                }
            }

            return abbr;
        }
        public static void Main()
        {
            string str = "world wide web";
            string abr = "";

            abr = GetAbbreviation(str);

            Console.WriteLine("Abbreviation: " + abr);
        }
    }

}

