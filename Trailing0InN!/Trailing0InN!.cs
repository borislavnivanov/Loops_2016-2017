using System;


namespace Trailing0InN_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int Factor = 0;
            int devide = 0;
            int counter = 1;

            while (true)
            {
                devide = (int)Math.Pow(5, counter);
                Factor += n / devide;
                if ((n / devide) < 1)
                {
                    break;
                }
                counter++;
            }
            Console.WriteLine(Factor);
        }
    }
}
