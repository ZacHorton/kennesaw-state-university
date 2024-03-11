using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4B
{
    class Program
    // Write a recursive method to check whether a string is a palindrome.
    {
        public static bool Palindrome(string s)
        {
            if (s.Length == 1 || s.Length == 0)
                return true;
            else if (s[0] != s[s.Length - 1])
                return false;
            return Palindrome(s.Substring(1, s.Length - 2));
        }

        public static string Reverse(string s)
        {
            if (s.Length == 1)
                return s;
            else
                return Reverse(s.Substring(1)) + s[0];
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter a string. ");
            string s = Console.ReadLine();
            string reversed = Reverse(s);
            Console.WriteLine($"The reversed string is \"{reversed}\".");
            Console.WriteLine();
            if (Palindrome(s) == true)
                Console.WriteLine("This is a palindrome. ");
            else
                Console.WriteLine("This is not a palindrome. ");

            Console.ReadKey();
        }
    }
}
