using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Practice
{
    class Program
    {
        static int sumArray(int[] array)
        {
            int sum = array.Sum();
            return sum;
        }

        public static void Main(string[] args)
        {
            int[] randomArray = new int[100000];
            Random rnd = new Random();
            for (int i = 0; i < randomArray.Length; i++)
                randomArray[i] = rnd.Next(10); // random int from 0-9 inclusive

            int[] partialArray1 = new int[20000];
            for (int i = 0; i < 20000; i++)
            {
                partialArray1[i] = randomArray[i];
            }

            int[] partialArray2 = new int[20000];
            for (int i = 0; i < 20000; i++)
            {
                partialArray2[i] = randomArray[i + 20000];
            }

            int[] partialArray3 = new int[20000];
            for (int i = 0; i < 20000; i++)
            {
                partialArray3[i] = randomArray[i + 40000];
            }

            int[] partialArray4 = new int[20000];
            for (int i = 0; i < 20000; i++)
            {
                partialArray4[i] = randomArray[i + 60000];
            }

            int[] partialArray5 = new int[20000];
            for (int i = 0; i < 20000; i++)
            {
                partialArray5[i] = randomArray[i + 80000];
            }

            new Thread(() =>
            {
                int sum1 = sumArray(partialArray1);
                int sum2 = sumArray(partialArray2);
                int sum3 = sumArray(partialArray3);
                int sum4 = sumArray(partialArray4);
                int sum5 = sumArray(partialArray5);
                int total = sum1 + sum2 + sum3 + sum4 + sum5;
                Console.WriteLine($"Sum of partialArray1 = {sum1}");
                Console.WriteLine($"Sum of partialArray2 = {sum2}");
                Console.WriteLine($"Sum of partialArray3 = {sum3}");
                Console.WriteLine($"Sum of partialArray4 = {sum4}");
                Console.WriteLine($"Sum of partialArray5 = {sum5}\n");
                Console.WriteLine($"Sum of randomArray = {total}");
            }).Start();

            Console.ReadKey();
        }
    }
}
