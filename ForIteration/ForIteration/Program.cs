using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Teaches for-loop iterations

namespace ForIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(i); // For printing out number sequences from for-loop
                if (i == 7)
                {
                    Console.WriteLine("Found seven!");
                    break;
                }
            }


            /*
             * Built-in for-loop code snippet in Visual Studio
             * 
            for (int i = 0; i < length; i++)
            {
                
            }
            */


            Console.ReadLine();
        }
    }
}
