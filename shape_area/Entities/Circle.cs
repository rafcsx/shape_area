using System;
using shape_area.Entities.Enums;

namespace shape_area.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

       
        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double area()
        {
            return Math.PI * Math.Pow(Radius, 2.0);
        }

    }
}
