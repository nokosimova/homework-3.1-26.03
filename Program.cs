using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the sum:");
            double init_sum    = double.Parse(Console.ReadLine());
            double first_sale  = init_sum * 0.03;
            double second_sale = init_sum * 0.05;
            double total_sum;
            if (init_sum <= 500) {
                total_sum = init_sum;
            } else {
                total_sum = (init_sum > 500 && init_sum <= 1000)?
                            init_sum-first_sale:init_sum-second_sale;
            }
            Console.WriteLine($"{total_sum}");
        }
    }
}
