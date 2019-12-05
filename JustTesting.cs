using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class JustTesting
    {
        static void Main(string[] args)
        {
            string grade = Utils.GetInput("What was your grade? ");
            if (grade == "A")
            {
                Console.WriteLine("go you");
            }
            else if (grade == "B")
            {
                Console.WriteLine("not bad");
            }
            else if (grade == "C")
            {
                Console.WriteLine("average");
            }
            else if (grade == "D")
            {
                Console.WriteLine("Ouch");
            }
            else
            {
                Console.WriteLine("study harder");
            }
        }
    }
}
