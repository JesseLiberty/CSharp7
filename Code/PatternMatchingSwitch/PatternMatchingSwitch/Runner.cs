using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingSwitch
{
    public class Runner
    {
        public void Run()
        {

            Shape shape = new Square(75);  // from some collection?

            switch (shape)
            {
                case Circle c:
                    {
                        Console.WriteLine($"this circle has a radius of {c.Radius}");
                    }
                    break;

                case Rectangle r:
                    {
                        Console.WriteLine($"Rectangle with area of { r.Height * r.Width}");
                    }
                    break;
                case Square s when s.Side > 50:
                    {
                        Console.WriteLine($"A big square, area: {s.Side * s.Side}");
                    }
                    break;
                case Square s when s.Side <= 50:
                    {
                        Console.WriteLine($"A smaller square, area:  {s.Side * s.Side}");
                    }
                    break;
                case null:
                    throw new ArgumentNullException(nameof(shape));
                default:
                    Console.WriteLine("Unknown shape");
                    break;

            }

        }
    }

    public class Shape
    {

    }
    public class Circle : Shape
    {
        public int Radius { get; }

        public Circle(int radius) { Radius = radius; }
    }

    public class Rectangle : Shape
    {
        public int Width { get; }
        public int Height { get; }

        public Rectangle(int h, int w)
        {
            Width = w;
            Height = h;
        }
    }

    public class Square : Shape
    {
        public int Side { get; }

        public Square(int side) { Side = side; }
    }
}
