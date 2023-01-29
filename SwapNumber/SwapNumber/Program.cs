using System;

namespace SwapNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 25;
            int num2 = 45;

            //int temp = num2;
            num2 = num1;
            num1 = num2;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            //Console.WriteLine(temp);
        }
    }
}
