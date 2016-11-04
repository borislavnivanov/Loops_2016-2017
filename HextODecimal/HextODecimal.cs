using System;


namespace HextODecimal
{
    class HextODecimal
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long result = Int64.Parse(input, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine(result);
        }
    }
}
