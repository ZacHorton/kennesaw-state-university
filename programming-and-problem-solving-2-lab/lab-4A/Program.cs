using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4A
{
    class Program
    // Write a recursive method, vowels, that returns the number of vowels in a string.  Also, write a program to test your method.
    {
        public static int vowelCheck(char c)
        {
            c = char.ToLower(c);
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static int Vowels(string s, int n)
        {
            if (n == 1)
            {
                return vowelCheck(s[n - 1]);
            }
            return Vowels(s, n - 1) + vowelCheck(s[n - 1]);
        }

        public static void Main(string[] args)
        {
            Console.Write("Please enter a string. ");
            string s = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Your string contains {Vowels(s, s.Length)} vowels.");

            Console.ReadKey();
        }
    }
}
