using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2A
{
    class Test
    {
        public static void Testing(decimal difference)
        {
            if (difference < 0)
            {
                Console.WriteLine($"You are over budget by ${Math.Abs(difference)}.");
                Console.WriteLine("Please find a less expensive vacation or increase your budget.");
            }

            else if (difference == 0)
            {
                Console.WriteLine("You are exactly on budget.");
            }

            else if (difference > 0)
            {
                Console.WriteLine($"You are under budget by ${Math.Abs(difference)}. Way to go!");
            }
        }
    }
}
