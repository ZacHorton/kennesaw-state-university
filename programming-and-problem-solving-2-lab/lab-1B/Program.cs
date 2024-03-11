using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1B
{
    class Program
    {
        public static int findLargest(int[] arr)
        {
            int largest = arr[0];
            foreach (int i in arr)
            {
                if (i > largest)
                {
                    largest = i;
                }
            }
            return largest;
        } // END findLargest

        public static int fillArray(int[] arr)
        {
            int min = -100;
            int max = 100;
            Random randNum = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randNum.Next(min, max);
            }
            return findLargest(arr);
        } // END fillArray

        public static int positiveSeries(int[] arr)
        {
            int count = 0;
            int series = 0;
            for (int counter = 0; counter < arr.Length; counter++)
            {
                if (arr[counter] > 0)
                {
                    count += 1;
                }
                if (arr[counter] <= 0)
                {
                    if (count > series)
                    {
                        series = count;
                    }
                    count = 0;
                }
            } // END outer for loop
            return series;
        } // END positiveSeries

        static void Main(string[] args)
        {
            int[] nums = { 1, 4, 13, 43, -25, 17, 22, -37, 29 };
            int[] data = new int[20];
            fillArray(data);
            int numsLargest = findLargest(nums);
            int dataLargest = findLargest(data);
            int sum = numsLargest + dataLargest;
            Console.WriteLine("Contents of array nums:");
            foreach (int i in nums)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine("The largest value in array nums is {0}.", numsLargest);
            Console.WriteLine();
            Console.WriteLine("Contents of array data:");
            foreach (int i in data)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine("The largest value in array data is {0}.", dataLargest);
            Console.WriteLine();
            Console.WriteLine("The sum of the largest values from array nums and array data is {0}.", sum);
            Console.WriteLine("In array data, the length of the longest continuous series of positive numbers is {0}.", positiveSeries(data));
            Console.ReadKey();
        } // END Main
    } // END class Program
} // END namespace Lab_1B
