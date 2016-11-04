using System;
using System.Numerics;


namespace DecimalToHex
{
    class DecimalToHex
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            string result = number.ToString("X");
            Console.WriteLine(result);
        }
    }
}