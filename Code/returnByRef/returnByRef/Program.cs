using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace returnByRef
{
    class Program
    {
        static void Main(string[] args)
        {
            var runner = new Runner();
            runner.Test();
        }
    }

    public class Runner
    {
        public ref int Changer(int newNumber, int[] numbers)
        {
            for (int i = 0; i< numbers.Length; i++)
            {
                if (numbers[i] == newNumber)
                {
                    return ref numbers[i];
                }
            }

            throw new IndexOutOfRangeException($"{nameof(newNumber)} not found!");
        }

        public void Test()
        {
            int[] array = { 1, 3, 5, 7, 9, 11 };
            Console.WriteLine(array[3]);                // prints 7
            ref int index = ref Changer(7, array);      // find it
            index = 24;
            Console.WriteLine(array[3]);                // prints 24 

        }
    }
}
