using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            var runner = new Runner();
            runner.Run();
        }
    }

    public class Runner
    {
        Point p = new Point();

        public void Run()
        {
            PrintCoordinates(p);
            PrintStars("5");
            PrintStars(7);
            PrintStarsEitherWay("9");
            PrintStarsEitherWay(9);
        }

        public void PrintCoordinates(Point p)
        {
            p.GetCoordinates(out int x, out int y);
            Console.WriteLine($"{x}, {y}");
        }

        public void PrintStars(string s)
        {
            if (int.TryParse(s, out var i)) { Console.WriteLine(new String('*', i)); }
            else { Console.WriteLine("No stars"); }
        }

        public void PrintStars(object o)
        {
            if (o is null) return;
            if (!(o is int i)) return;
            Console.WriteLine(new String('*', i));
        }

        public void PrintStarsEitherWay(object o)
        {
            if ( o is int i || ( o is string s && int.TryParse(s, out i))) { Console.WriteLine(new String('*', i)); }
        }

       
    }

    public class Point
    {
        public int X = 20;
        public int Y = 10;

        public void GetCoordinates(out int x, out int y)
        {
            x = this.X;
            y = this.Y;
        }

    }
}
