using System;

namespace HashPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string test1 = "hello";
            string test2 = "hello";

            Console.WriteLine(BCrypt.Net.BCrypt.HashPassword(test1));
            Console.WriteLine(BCrypt.Net.BCrypt.HashPassword(test2));
            Console.WriteLine(BCrypt.Net.BCrypt.Verify("hello", BCrypt.Net.BCrypt.HashPassword(test2)));
        }
    }
}
