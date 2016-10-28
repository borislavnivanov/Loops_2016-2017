using System;
using System.Linq;

namespace MMSA
{
    class MMSA
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] value = new double[n];
            for (int i = 0; i < n; i++)
            {
                value[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("min={0:0.00}", value.Min());
            Console.WriteLine("max={0:0.00}", value.Max());
            Console.WriteLine("sum={0:0.00}", value.Sum());
            Console.WriteLine("avg={0:0.00}", value.Average());
        }
    }
}
