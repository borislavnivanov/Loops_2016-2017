using System;
using System.Numerics;


namespace CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger nF = 1;
            BigInteger n1 = 1;
            BigInteger n2 = 1;
            for (int i = 1; i <= n; i++)
            {
                nF *= i;
            }
            for (int i = 1; i <= n + 1; i++)
            {
                n1 *= i;
            }
            for (int i = 1; i <= n * 2; i++)
            {
                n2 *= i;
            }
            Console.WriteLine(n2 / (n1 * nF));
        }
    }
}
