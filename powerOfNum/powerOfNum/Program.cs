using System;

namespace powerOfNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Base Value: ");
            int Base = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Power: ");
            string power = Console.ReadLine();
            int powNum = int.Parse(power);

            int result = 1;
            for ( ; powNum > 0; powNum--)
            {
                result = Base * result;
            }
            Console.WriteLine("Base " + Base + " with Power " + power + " is " + result);

            /*while(power > 0)
            {
                result = 2 * result;
                power--;
            }
            Console.WriteLine("Power of 2 with power" + power + "is" + result);*/


        }
    }
}
