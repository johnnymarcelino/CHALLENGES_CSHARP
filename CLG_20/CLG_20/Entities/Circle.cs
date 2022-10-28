using CLG_20.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CLG_20.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Colors colors) : base(colors)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }

    }
}
