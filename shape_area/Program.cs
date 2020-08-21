using shape_area.Entities;
using shape_area.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace shape_area
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shape_list = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Shape {i} data:");

                Console.Write("Rectangle or Circle (r/c)? ");
                char ch_input = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");
                Color color_input = Enum.Parse<Color>(Console.ReadLine());

                if (ch_input == 'r' || ch_input == 'R')
                {
                    Console.Write("Width: ");
                    double width_input = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Height: ");
                    double height_input = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shape_list.Add(new Rectangle(width_input, height_input, color_input));
                }

                else
                {
                    Console.Write("Radius: ");
                    double radius_input = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shape_list.Add(new Circle(radius_input, color_input));
                }
            }
         
            Console.WriteLine();
            
            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape obj in shape_list)
            {
                Console.WriteLine(obj.area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}