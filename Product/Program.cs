using System;

namespace ProductOfSeriesNumber
{
    class Program
    {
        static public void LargestProductOfSeries(string input, int series)
        {
            double[] productArray = new double[input.Length - series + 1];
            for (int i = 0; i < productArray.Length; i++)
            {
                productArray[i] = 1;
                for (int j = i; j < series + i; j++)
                {
                    productArray[i] *= Char.GetNumericValue(input[j]);
                }
            }
            var maxProduct = productArray[0];
            for (int i = 0; i < productArray.Length; i++)
            {
                if (productArray[i] > maxProduct)
                {
                    maxProduct = productArray[i];
                }
            }
            Console.WriteLine($"{maxProduct}");

        }
        static void Main(string[] args)
        {
            var input = "1027839564";
            var series = 5;
            LargestProductOfSeries(input, series);
        }
    }
}
