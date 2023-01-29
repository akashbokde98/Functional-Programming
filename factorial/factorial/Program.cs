using System;

namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int fact = 1;
            for (int num = 5; num > 0; num--)
            {
                fact = num * fact;
            }
            Console.WriteLine(fact);*/

            int num = 5;
            int fact = 1;
            while(num>0)
            {
                fact = num * fact;
                num--;
            }
            Console.WriteLine(fact);
        }
    }
}
