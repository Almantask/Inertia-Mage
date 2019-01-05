using System;

namespace InertiaMage.Game.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            const int applesInKentucky = 5;
            const int applesInOregon = 6;
            var totalApples = SumAndPrint(applesInKentucky, applesInOregon);

            const int bannanasInKentucky = 1;
            const int bannanasInOregon = 2;
            var sum2 = SumAndPrint(bannanasInKentucky, bannanasInOregon);
        }

        static int SumAndPrint(int a, int b)
        {
            var sum = a + b;
            Print(a, b, sum);
            return sum;
        }
 
        static void Print(int a, int b, int sum)
        {
            Console.WriteLine($"{a} + {b} = {sum}");
        }
    }
}
