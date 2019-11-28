using System;
using System.Text.RegularExpressions;

namespace passwordCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PasswordCheck("11llI"));
        }

        static bool PasswordCheck(string inputString)
        {

            if (inputString.Length < 5)
            {
                return false;
            }
            if(!Regex.IsMatch(inputString, @"(.*[a-z].*)(.*[A-Z].*)(.*\d.*)"))
            {
                return false;
            }
            return true;
        }
    }
}
