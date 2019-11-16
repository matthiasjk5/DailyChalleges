//The NAND operation(also known as a Sheffer stroke) is an operation on two logical values.It produces true, if - and only if - at least one of the operands is false.
//Given two boolean values a and b, return the value of A NAND B.

using System;

namespace ShefferStroke
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(ShefferStroke(false, false));
        }

        static bool ShefferStroke(bool a, bool b)
        {
            if (!a.Equals(b) || (a == false && b == false))
                return true;
            else
                return false;
        }
    }
}
