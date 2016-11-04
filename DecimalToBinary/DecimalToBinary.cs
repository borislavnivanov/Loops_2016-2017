using System;
using System.Collections.Generic;
using System.Numerics;


namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            string result = null;

            while (number > 0)
            {
                if (number % 2 == 0)
                {
                    list.Add("0");
                }
                else
                {
                    list.Add("1");
                }
                number = number / 2;
            }
            list.Reverse();
            result = string.Join("", list.ToArray());
            Console.WriteLine(result);
        }
    }
}
