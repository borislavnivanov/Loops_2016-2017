using System;


namespace OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] strArray = Console.ReadLine().Split(' ');
            int[] numArray = new int[strArray.Length];
            long sumEven = 1;
            long sumOdd = 1;
            for (int i = 0; i < strArray.Length; i++)
            {
                numArray[i] = Convert.ToInt32(strArray[i]);
            }
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sumEven = sumEven * numArray[i - 1];
                }
                else
                {
                    sumOdd = sumOdd * numArray[i - 1];
                }
            }
            if (sumEven == sumOdd)
            {
                Console.WriteLine("yes {0}", sumEven);
            }
            else
            {
                Console.WriteLine("no {0} {1}", sumOdd, sumEven);
            }
        }
    }
}
