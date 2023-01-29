using System;

namespace FlipCoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randNum = rnd.Next(2);

            int head = 1;
            int tail = 0;

            if (randNum == head)
            {
                Console.WriteLine("Head");
            }
            else
            {
                Console.WriteLine("Tail");
            }
        }
    }
}
