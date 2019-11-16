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
