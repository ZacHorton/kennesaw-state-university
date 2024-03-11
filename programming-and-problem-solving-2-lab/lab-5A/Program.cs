using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab_5A
{
    class Program
    {
        public class Node
        {
            public Node next;
            public Object data;
        }

        public class LinkedList
        {
            private Node head;

            public void printAllNodes()
            {
                Node current = head;
                while (current != null)
                {
                    Console.Write($"| {current.data} ");
                    current = current.next;
                }
                Console.Write("|\n");
            }

            public void AddFirst(Object data)
            {
                Node toAdd = new Node();
                toAdd.data = data;
                toAdd.next = head;
                head = toAdd;
            }

            public int SumList()
            {
                int sum = 0;
                Node current = head;
                while (current != null)
                {
                    sum += Convert.ToInt32(current.data);
                    current = current.next;
                }
                return sum;
            }
        }

        static int SumArray(ArrayList arr)
        {
            int sum = 0;
            foreach (int element in arr)
            {
                sum += element;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            for (int x = 0; x < 10; x++)
            {
                Console.Write("Enter an integer for the ArrayList. ");
                int arrInput = Int32.Parse(Console.ReadLine());
                arr.Add(arrInput);
            }
            Console.WriteLine("The integers of the ArrayList are:");
            foreach (int element in arr)
            {
                Console.Write($"| {element} ");
            }
            Console.Write("|\n");
            Console.Write($"The sum of all elements in this ArrayList of integer objects equals {SumArray(arr)}.\n");
            Console.WriteLine();
            LinkedList list = new LinkedList();
            for (int x = 0; x < 10; x++)
            {
                Console.Write("Enter an integer for the LinkedList. ");
                int listInput = Int32.Parse(Console.ReadLine());
                list.AddFirst(listInput);
            }
            Console.WriteLine("The integers of the LinkedList are:");
            list.printAllNodes();
            Console.Write($"The sum of all elements in this LinkedList of integers equals {list.SumList()}.");

            Console.ReadKey();
        }
    }
}
