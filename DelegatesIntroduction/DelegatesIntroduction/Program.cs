using System;
using DelegatesIntroduction.Services;

namespace DelegatesIntroduction
{
    class Program
    {
        delegate double BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationServices.Sum;

            Console.WriteLine(op(a, b));


        }
    }
}
