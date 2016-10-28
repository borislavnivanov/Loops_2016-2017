using System;


namespace NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
