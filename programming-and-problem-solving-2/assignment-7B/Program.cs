using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Assignment_7B
{
    public class ParallelSort
    {
        public static void QSSequential<T>(T[] array) 
            where T : IComparable<T>
        {
            QSSequential(array, 0, array.Length - 1);
        }

        public static void QSParallel<T>(T[] array) 
            where T : IComparable<T>
        {
            QSParallel(array, 0, array.Length - 1);
        }

        private static void QSSequential<T>(T[] array, int left, int right)
            where T : IComparable<T>
        {
            if (right > left)
            {
                int pivot = Partition(array, left, right);
                QSSequential(array, left, pivot - 1);
                QSSequential(array, pivot + 1, right);
            }
        }

        private static void QSParallel<T>(T[] array, int left, int right)
            where T : IComparable<T>
        {
            const int SEQUENTIAL_THRESHOLD = 2048;
            if (right > left)
            {
                if (right - left < SEQUENTIAL_THRESHOLD)
                {
                    QSSequential(array, left, right);
                }
                else
                {
                    int pivot = Partition(array, left, right);
                    Parallel.Invoke(new Action[] { delegate {QSParallel(array, left, pivot - 1);},
                                               delegate {QSParallel(array, pivot + 1, right);}
                });
                }
            }
        }

        private static void Swap<T>(T[] arr, int i, int j)
        {
            T tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }

        private static int Partition<T>(T[] array, int low, int high)
            where T : IComparable<T>
        {
            int pivotPos = (high + low) / 2;
            T pivot = array[pivotPos];
            Swap(array, low, pivotPos);
            int left = low;
            for (int i = low + 1; i <= high; i++)
            {
                if (array[i].CompareTo(pivot) < 0)
                {
                    left++;
                    Swap(array, i, left);
                }
            }
            Swap(array, low, left);
            return left;
        }
    }

        class Program
        {
            static void Main(string[] args)
            {
                int[] randomArray1 = new int[10000];
                Random rnd = new Random();
                for (int i = 0; i < randomArray1.Length; i++)
                {
                    randomArray1[i] = rnd.Next(101);
                }
                int[] randomArray2 = new int[10000];
                randomArray2 = randomArray1;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            bubbleSort(randomArray1);
            sw.Stop();
            string ExecutionTimeTakenBubble = string.Format("Minutes: {0}\nSeconds: {1}\nMilliseconds: {2}", sw.Elapsed.Minutes, sw.Elapsed.Seconds, sw.Elapsed.TotalMilliseconds);
            sw.Reset();
            sw.Start();
            ParallelSort.QSParallel(randomArray2);
            sw.Stop();
            string ExecutionTimeTakenParallel = string.Format("Minutes: {0}\nSeconds: {1}\nMilliseconds: {2}", sw.Elapsed.Minutes, sw.Elapsed.Seconds, sw.Elapsed.TotalMilliseconds);
            Console.WriteLine("For two equal 10,000 integer arrays...");
            Console.WriteLine($"Bubble Sort Execution Time Takes\n{ExecutionTimeTakenBubble}\n");
            Console.WriteLine($"Parallelism Sort Execution Time Takes:\n{ExecutionTimeTakenParallel}\n");

            Console.ReadKey();
            }

            private static void bubbleSort(int[] array)
            {
                int temp = 0;

                for (int write = 0; write < array.Length; write++)
                {
                    for (int sort = 0; sort < array.Length - 1; sort++)
                    {
                        if (array[sort] > array[sort + 1])
                        {
                            temp = array[sort + 1];
                            array[sort + 1] = array[sort];
                            array[sort] = temp;
                        }
                    }
                }
            }
        }
    }