using Interfaces.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return "Área do Circle: " + Area();
        }
    }
}
