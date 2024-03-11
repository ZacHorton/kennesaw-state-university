using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4B
{
    class Program
    /* Write a program that uses a recursive method to convert a number in decimal to a given base b, 
     * where b is between 2 and 36.  Your program should prompt the user to enter the number in decimal and the desired base. */
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number in decimal. ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the desired base. ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"{n} base 10 = {Converter(n, b)} base {b}");

            Console.ReadKey();
        }

        public static String Converter(int n, int b)
        {
            string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int quotient = n / b;
            int remainder = n % b;
            if (quotient == 0)
            {
                return chars[remainder].ToString();
            }
            else
            {
                return Converter(quotient, b) + chars[remainder].ToString();
            }
        }
    }
}