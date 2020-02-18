using Interfaces.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Entities
{
    class Square : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Square(Color color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Square: Width = " + Width.ToString() + " Height = "+ Height.ToString() + " Color = " + Color.ToString() + " --- Área the Square is: " + Area().ToString();
        }
    }
}
