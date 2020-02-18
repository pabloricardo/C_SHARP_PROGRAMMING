using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum01 = Calculator.Sum(new int[] {1,2,3});
            System.Console.WriteLine(sum01);

            int sum02 = Calculator.SumParams(1,2,3);
            System.Console.WriteLine(sum02);
        }
    }
}
