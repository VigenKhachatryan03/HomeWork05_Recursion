using System;

namespace HomeWork05_Recursion
{
    class Program
    {
        static long fact(long Number)
        {
            long count = 1;
            if (Number == 1)
                return 1;

            count = (long)fact(Number - 1) * Number;

            return count;
        }
        static int fibonachi(int index)
        {
            int volue = 0;
            if (index <= 2)
            {
                return 1;
            }

            volue = fibonachi(index - 1) + fibonachi(index - 2);

            return volue;
        }
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine();
                Console.WriteLine("Enter the number whose factorial you want to know: ");
                long Number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"factorial {Number} = {fact(Number)}");

                Console.WriteLine();
                Console.WriteLine("Enter the number whose index's fibonachi volue you want to know: ");
                int fib = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Fibonachi volue of index {fib} = {fibonachi(fib)}");
            }
        }
    }
}
