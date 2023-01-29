using System;

namespace OddEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Number: ");
            int num = int.Parse(Console.ReadLine());

            if ( num%2 == 0 )
            {
                Console.WriteLine(num + "is a Odd Number");
            }
            else
            {
                Console.WriteLine(num + "is a Even Number");
            }
        }
    }
}
