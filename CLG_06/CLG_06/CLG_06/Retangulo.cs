using System;
using System.Collections.Generic;
using System.Text;

namespace CLG_06 {
    internal class Retangulo {

        public double Width;
        public double Height;

        public double Area() {
            return (Width * Height);
        }

        public double perimeter() {
            return (Height + Width) * 2;
        }

        public double Diagonal() { 
            //return Math.Sqrt(Area() + Area());
            return Math.Sqrt(Width*Width + Height*Height);
        }

        override public string ToString() { 
            return Width + " " + Height;
        }
    }
}
