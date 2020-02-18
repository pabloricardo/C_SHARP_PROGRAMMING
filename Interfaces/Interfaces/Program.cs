using Interfaces.Entities;
using Interfaces.Enum;
using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractShape square01 = new Square(Color.Black, 5, 4);
            AbstractShape circle01 = new Circle(Color.Blue, 3);
            Console.WriteLine(square01);
            Console.WriteLine(circle01);
        }
    }
}
