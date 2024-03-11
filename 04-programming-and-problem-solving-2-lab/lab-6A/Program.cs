using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6A
{
    class TimeFormatException
    {
        public static DateTime SafeTime(int hours, int minutes)
        {
            if (hours >= 0 && hours <= 24 && minutes >= 0 && minutes <= 60 )
            {
                return new DateTime(2019, 3, 24, hours, minutes, 0);
            }
            throw new System.Exception();
        }

        public static void StartUpCode()
        {
            char answer = 'y';
            DateTime result = new DateTime();
            do
            {
                Console.Write("Enter time in 24-hour notation: ");
                string input = Console.ReadLine();
                string[] words = input.Split(':');
                string hours = words[0];
                string minutes = words[1];
                int intHours = Convert.ToInt32(hours);
                int intMinutes = Convert.ToInt32(minutes);
                try
                {
                    result = SafeTime(intHours, intMinutes);
                    Console.WriteLine("That is the same as: "+ result.ToString("h:mm tt"));
                }
                catch (System.Exception e)
                {
                    Console.Write($"There is no such time as: {input}\n");
                    Console.Write("Try again\n");
                    StartUpCode();
                }
                Console.Write("Again?(y/n) ");
                answer = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (answer == 'y');
            Console.WriteLine("Thank you – end of program.");

            Console.ReadKey();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TimeFormatException.StartUpCode();
        }
    }
}
