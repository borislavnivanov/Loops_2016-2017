using System;
using System.Numerics;

namespace CalculateAgain
{
    class CalculateAgain
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            BigInteger NF = 1;
            BigInteger KF = 1;

            for (int i = 1; i <= N; i++)
            {
                NF = NF * i;
                if (i <= K)
                {
                    KF = KF * i;
                }
            }

            Console.WriteLine(NF / KF);
        }
    }
}
