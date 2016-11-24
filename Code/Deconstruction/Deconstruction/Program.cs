using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deconstruction
{
    class Program
    {
        static void Main(string[] args)
        {
                 var runner = new Runner();
                runner.TestTuples();
        }

        public class Runner
        {
            private (string firstName, string lastName, int yearsOfService) GetEmployee(int id)
            {
                // loook up id in the database
                //  return ("Jesse", "Liberty", 5);
                return (firstName: "Jesse", lastName: "Liberty", yearsOfService: 5);
            }

            public void TestTuples()
            {
                //var Employee = GetEmployee(12);
                //var first = Employee.firstName;
                //var last = Employee.lastName;
                //var yos = Employee.yearsOfService;

                // (var first, var last, var yos) = GetEmployee(12);
                var (first, last, yos) = GetEmployee(12);

                Console.WriteLine($"{first} {last} has {yos} years of service.");
            }
        }
    }
}
