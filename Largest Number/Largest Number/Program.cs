using System;

namespace Largest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Third Number: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1 + " is Greater");
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine(num2 + " is Greater");
                }
                else
                {
                    Console.WriteLine(num3 + " is Greater");
                }
            }
        }
    }
}
