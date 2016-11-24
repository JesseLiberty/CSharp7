using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunctions
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
        public void Run()
        {
            Console.WriteLine(Fibonacci(6));
        }

        public int Fibonacci(int x)
        {
            if (x < 0) throw new ArgumentException();
            return Fib(x).current;

            (int current, int previous) Fib(int i)
            {
                if (i == 0) return (1, 0);
                var (p, pp) = Fib(i - 1);
                Console.WriteLine($"{p}");
                return (p + pp, p);

            }
        }
    }
}
