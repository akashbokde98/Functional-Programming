using System;

namespace VowelConsonent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Character: ");
            char c = char.Parse(Console.ReadLine());

            if ( c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' )
            {
                Console.WriteLine("Entered Character is Vowel: ");
            }
            else
            {
                Console.WriteLine("Entered Character is Consonant: ");
            }
        }
    }
}
