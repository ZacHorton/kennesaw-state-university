using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a frequency between 37 and 32,767 hertz. ");
            int frequency = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter a duration in milliseconds. ");
            int duration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now listen to {0} hertz of frequency for {1} milliseconds.", frequency, duration);
            Console.Beep(frequency, duration);
            Console.Write("Press any key to exit. ");
            Console.ReadKey();
        }
    }
}
