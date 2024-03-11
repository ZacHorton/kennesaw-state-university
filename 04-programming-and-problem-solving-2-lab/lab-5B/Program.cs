using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5B
{
    public class CA
    {
        private int rear;
        private int front;
        private int size;
        private int[] arr;

        //public void Queue(int s)
        //{
        //    front = rear = -1;
        //    size = s;
        //    arr = new int[s];
        //}

        //public static void enQueue(string[,] a, int n, string foodName, int caloriesPerServing, int servingsPerContainer)
        //{
        //    if ((a[0] == 0 && rear == size - 1) || (rear == (front - 1) % (size - 1)))
        //    {
        //        Console.WriteLine("Queue is Full");
        //    }
        //}

    public static void DisplayAll<T>(T[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void PrintFoodNames(string[,] a, int n, int ind)
        {
            // Create an auxiliary array with twice the size
            string[] b = new string[(2 * n)];

            // Copy a[] to b[] twice 
            for (int i = 0; i < n; i++)
            {
                b[i] = b[n + i] = a[i, 0];
            }

            // Print from ind - th index to(n+i)th index. 
            for (int i = ind; i < n + ind; i++)
            {
                Console.WriteLine(b[i] + " ");
            }
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            // https://www.linda-rd.com/fruit-vegetable-calories-chart-list/ 
            string[,] a = new string[,]  { { "Apple", "81", "1" }, { "Avocado", "250", "1" } , {"Banana", "105", "1" } , {"Blackberries", "37", ".5" },
                { "Blueberries", "40", ".5" }, {"Broccoli", "12", ".5" }, {"Carrot", "31", "1"}, {"Corn", "89", ".5" },
                {"Mango", "135", "1"}, {"Mushrooms", "9", ".5"}, {"Orange", "60", "1"},{ "Peache", "37", "1" }, 
                {"Pear", "98", "1"}, {"Pineapple", "76", "1"}, {"Plum", "36", "1" }, {"Raspberries", "30", ".5" },
                {"Radishes", "8", "10" }, {"Spinach", "6", ".5" }, {"Tangerine", "1", "37" }, {"Tomato", "26", "1"} } ;
            int n = 20;
            CA.PrintFoodNames(a, n, 3);

            //CA.AverageCalories(a, n, 3);
            //CA.DisplayAll(a);
            Console.ReadKey();
        }
    }
}
