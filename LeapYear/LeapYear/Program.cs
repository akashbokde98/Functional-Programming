using System;

namespace LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year to Check Leap Year or Not: ");
            int year = int.Parse(Console.ReadLine());

            if (year%4 == 0)
            {
                Console.WriteLine(year + " is a Leap Year.");
            }
            else
            {
                Console.WriteLine(year + " is Not a Leap Year.");
            } 

        }
    }
}
