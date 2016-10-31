using System;
using System.Numerics;

namespace Calculate3_
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger nF = 1;
            BigInteger kF = 1;
            BigInteger nkF = 1;
            for (int i = 1; i <= n; i++)
            {
                nF *= i;
                if (i <= k)
                {
                    kF *= i;
                }
            }
            for (int i = 1; i <= n - k; i++)
            {
                nkF *= i;
            }
            Console.WriteLine(nF / (kF * nkF));
        }
    }
}
