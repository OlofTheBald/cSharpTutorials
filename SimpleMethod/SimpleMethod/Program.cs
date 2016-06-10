using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Teaches simple method implementation and why methods are important
// Uses the Hello World concept for an ultra-simple example

namespace SimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            Console.ReadLine();
        }

        private static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
