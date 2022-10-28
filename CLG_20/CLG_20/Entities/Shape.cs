using System;
using System.Collections.Generic;
using System.Text;
using CLG_20.Entities.Enums;

namespace CLG_20.Entities
{
    abstract class Shape
    {
        public Colors Color { get; set; }


        public Shape(Colors color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
