// Implement a function that replaces each digit in the given string with a '#' character.
using System;
using System.Text.RegularExpressions;

namespace DailyChalleges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(replaceAllDigitsRegExp("as12123asfas"));
            
        }
        static string replaceAllDigitsRegExp(string input) => Regex.Replace(input, "\\d", "#");


    }
}
