//You are processing the results of an online poll and your task is to exclude answers that might have been submitted by bots from the final results. The poll consists of three questions, the answer to each one is either true or false. You think that a response is suspicious (i.e.it might be from a bot) if all of the submissions are the same.

//Given a response list to each of the three questions, check if it might have come from a bot using the above described criteria.

using System;

namespace isSuspiciousRespondent
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine(isSuspiciousRespondent(false, false, false));
        }

        static bool isSuspiciousRespondent(bool ans1, bool ans2, bool ans3)
        {
            if ((ans1 && ans2 && ans3) || (!ans1 && !ans2 && !ans3))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
