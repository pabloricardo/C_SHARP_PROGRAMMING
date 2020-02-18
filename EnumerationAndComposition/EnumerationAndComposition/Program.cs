using EnumerationAndComposition.Entities.Enums;
using System;
using System.Globalization;

namespace EnumerationAndComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter department's name");
            string departmentName = Console.ReadLine();
            Console.WriteLine("Enter work data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel workLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("How many ");

        }
    }
}
