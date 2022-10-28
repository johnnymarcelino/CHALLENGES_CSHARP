using CLG_20.Entities.Enums;

namespace CLG_20.Entities
{
    internal class Rectangle : Shape
    {

        public double Width { get; set; }
        public double Height { get; set; }

        // criar um construtor direto na subclasse, retira o erro de declaração da variavel passada
        public Rectangle(double width, double height, Colors colors) : base(colors)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            //throw new System.NotImplementedException();  // retorna algo pois tipo double
            //return 0;  // retorna algo pois tipo double
            return Width * Height;
        }


    }
}
