using Interfaces.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public AbstractShape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
