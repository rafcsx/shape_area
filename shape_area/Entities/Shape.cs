using shape_area.Entities.Enums;

namespace shape_area.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double area();
    }
}
