using System;
using System.Text.RegularExpressions;
using System.Numerics;


namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputarray = Regex.Split(input, "");
            BigInteger currentSum = 0;
            BigInteger counter = 1;
            BigInteger result = 0;

            for (int i = inputarray.Length - 2; i > 0; i--)
            {
                currentSum = counter * int.Parse(inputarray[i]);
                result = result + currentSum;
                counter = counter * 2;
            }
            Console.WriteLine(result);
        }
    }
}
