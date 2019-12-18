using System;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringReverse("Hello"));
        }

        static string StringReverse(string str)
        {
            char[] chars = new char[str.Length];
            char[] arr = new char[200];
            int index = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                chars[index++] = str[i];
            }
            return new string(chars);
        }
    }
}
