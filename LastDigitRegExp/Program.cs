using System;
using System.Collections.Generic;
using System.Linq;

namespace LastDigitRegExp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList<string> myList = new LinkedList<string>();
            List<string> myList2 = new List<string>();

            Console.WriteLine(lastDigitRegExp("asadsg4.sdgasdg"));
        }

        static char lastDigitRegExp(string inputString)
        {
            return inputString.Last(x => x <= 57 && x >= 48);
        }

    }
}
