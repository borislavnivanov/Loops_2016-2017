using System;


namespace Calculate
{
    class Calculate
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            double X = double.Parse(Console.ReadLine());
            double sum = 1 + 1 / X;
            long F = 1;

            for (int i = 2; i <= N; i++)
            {
                F = F * i;
                double pow = Math.Pow(X, i);
                sum = sum + (F / pow);
            }

            Console.WriteLine("{0:F5}", sum);

        }
    }
}
