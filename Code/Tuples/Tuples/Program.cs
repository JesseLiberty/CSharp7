using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            var runner = new Runner();
            runner.Test1();
            runner.Test2();
            runner.Test3();
            runner.Test4();
            runner.Test5();
            runner.Test6();
        }
    }

    public class Runner
    {
        #region tuples
        public (string, string, int) LookUpCustomer1(int Id)
        {
            var first = "Jesse";
            var last = "Liberty";
            var age = 21;

            return (first, last, age);
        }

        public void Test1()
        {
            var customer = LookUpCustomer1(5);
            Console.WriteLine($"Customer is {customer.Item1} {customer.Item2}, who is {customer.Item3} years old");
        }


        public (string first, string last, int age) LookUpCustomer2(int Id)
        {
            var first = "Jesse";
            var last = "Liberty";
            var age = 21;
            return (first, last, age);
        }

        public void Test2()
        {
            var customer = LookUpCustomer2(5);
            Console.WriteLine($"Customer is {customer.first} {customer.last}, who is {customer.age} years old");
        }

#endregion 


        #region deconstruction

        public void Test3()
        {
            (string first, string last, int age) = LookUpCustomer2(5);
            Console.WriteLine($"Customer name: {first} {last}");

        }

        public void Test4()
        {
            (var first, var last, var age) = LookUpCustomer2(14);
            Console.WriteLine($"Customer name: {first} {last}");

        }

        public void Test5()
        {
            var (first, last, age) = LookUpCustomer2(12);
            Console.WriteLine($"Customer name: {first} {last}");
        }


        private string firstName;
        private string lastName;
        private int customerAge;

        public void Test6()
        {
            (firstName, lastName, customerAge) = LookUpCustomer2(99);

            Console.WriteLine($"Customer name: {firstName} {lastName}");
        }


        #endregion





    }

}
