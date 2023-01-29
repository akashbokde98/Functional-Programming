using System;

namespace division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  First Number :");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter  Second Number :");
            int num2 = int.Parse(Console.ReadLine());


            int quotient = num1 / num2;
            Console.WriteLine("quotient: " + quotient);

            int remainder = num1 % num2;
            Console.WriteLine("remainder: " + remainder);
        }
    }
}
