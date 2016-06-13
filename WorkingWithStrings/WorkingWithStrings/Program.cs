using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Demonstrates more advanced methods of string manipulation
// This file is more of a reference than a valid running program

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Un-comment any line below to see the example actually run

            //string myString = "My \"so-called\" life"; // Demonstrates using backslash to escape quotes in strings (escape character)
            //string myString = "What if I need a\nnew line?"; // Demonstrates new-line character
            //string myString = "Go to your C:\\ drive"; // Demonstrates escaping the escape character - one instance in a string
            //string myString = @"Go to your C:\ drive"; // Demonstrates escaping the escape character - all instances in a string

            //string myString = String.Format("{1} = {0}", "First", "Second"); // Demonstrates using String.Format and changing order of formatted words

            //string myString = string.Format("{0:C}", 123.45); // Demonstrates formatting for currencies
            //string myString = string.Format("{0:N}", 1234567890); // Demonstrates auto-formatting of long numbers (adds commas and decimals)
            //string myString = string.Format("{0:P}", .123); // Demonstrates formatting a value as a percentage

            //string myString = string.Format("Phone Number: {0:(###) ###-####}", 1234567890); // Demonstrates custom formatting using U.S. phone # format as example

            // Below example demonstrates different methods of string slicing
            //string myString = " That summer we took threes across the board  ";
            //myString = myString.Substring(6); // Prints "summer we took threes across the board  "
            //myString = myString.Substring(6, 14); // Prints "summer we took"
            //myString = myString.ToUpper(); // Makes string all uppercase
            //myString = myString.Replace(" ", "--"); // Replaces all spaces with a double-dash
            //myString = myString.Remove(6, 14); // Prints " That  threes across the board  "

            //myString = String.Format("Length before: {0} -- Length after: {1}",
            //    myString.Length,
            //    myString.Trim().Length); // Trims extra spaces in string

            // Print out a string of numbers zero to ninety-nine
            /*
            string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            This is the crappy way
            */

            // Use string-builder instead!
            /*
            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }
            */

            Console.WriteLine(myString);
            Console.ReadLine();

        } // Main()
    } // Program
} // WorkingWithStrings
