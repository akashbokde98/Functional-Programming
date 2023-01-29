using System;

namespace Harmonic_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float harmonicNum = Harmonic(8);
            Console.WriteLine("Nth harmonic Vlaue is: " + harmonicNum);

            /*int N = 5;
            float harmonic = 1;
            for (int i = 2; i < N; i++)
            {
                harmonic = harmonic + (float)1 / i;
            }
            Console.WriteLine(" Nth Harmonic Number is: " + harmonic);*/
        }
        public static float Harmonic(int N)
        {
            float harmonic = 1;

            for (int i = 2; i < N; i++)
            {
                harmonic = harmonic + (float)1 / i;
            }
            return harmonic;

        }
    }
}
