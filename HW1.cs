using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class HW1
    {
        static void Main(string[] args)
        {
            int sum, diff, prod, remainder;
            double quotient;
            int num1, num2;
            num1 = Utils.GetNumber("Enter a number: ", 100);
            num2 = Utils.GetNumber("Enter a number: ", 100);
            
            // add the two numbers
            sum = num1 + num2;
            Console.WriteLine($"{sum} = {num1} plus {num2}");

            diff = num1 - num2;
            Console.WriteLine($"{diff} = {num1} minus {num2}");

            prod = num1 * num2;
            Console.WriteLine("{0} = {1} multiplied by {2}", prod, num1, num2);
            
            quotient = (double)num1 / (double)num2;
            Console.WriteLine($"{quotient} = {num1} divided by {num2}");

            remainder= num1 % num2;
            Console.WriteLine($"{remainder} = {num1} % {num2}");
            
            Console.WriteLine("post ++ {0} pre ++ {1}", sum++, ++sum);

            Console.WriteLine((sum > 100) ? $"{sum} is > 100" : $"{sum} is <= 100");

        }       //  this is the end of the Main function
    }           //  this is the end of the HW1 class
}               //  this is the end of the whole thing
