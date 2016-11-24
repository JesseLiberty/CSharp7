using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    
    public class Runner
    {
        public string Name { get; }
        public Person (string name) => Name == name ?? throw new ArgumentNullException();

        public string GetFirstName()
        {
            var parts = Name.Split(" ");
            return (parts.Length > 0) ? parts[0] : throw new InvalidOperationException();
        }

        public string GetLastName() => throw new NotImplementedException();
    }
}
