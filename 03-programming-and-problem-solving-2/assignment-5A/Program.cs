using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5A
{
    class Program
    {
        public class Node
        {
            public Node next;
            public Object data;
        }

        public class BirdSurvey
        {
            private Node head;
            public void getReport()
            {
                Node current = head;
                while (current != null)
                {
                    Console.WriteLine($"Species: {current.data}, Count: {Count(Convert.ToString(current.data))}");
                    current = current.next;
                }
            }

            public void AddFirst(Object data)
            {
                string stringData = Convert.ToString(data);
                Node toAdd = new Node();
                toAdd.data = data;
                toAdd.next = head;
                head = toAdd;
                Console.WriteLine($"Added \"{stringData}\" there is now {Count(stringData)} of them");
            }

            int Count(string searchFor)
            {
                Node current = head;
                int count = 0;
                while (current != null)
                {
                    if (Convert.ToString(current.data) == searchFor)
                        count++;
                    current = current.next;
                }
                return count;
            }

            public void GetCount()
            {
                Node current = head;
                while (current != null)
                {
                    if (current == current.next)
                    {
                        current = current.next;
                    }
                    else
                    {
                        Console.WriteLine($"Counted {Count(Convert.ToString(current.data))} {current.data}(s)");
                        current = current.next;
                    }
                }
            }

            public void AddLast(Object data)
            {
                if (head == null)
                {
                    head = new Node();
                    head.data = data;
                    head.next = null;
                }
                else
                {
                    Node toAdd = new Node();
                    toAdd.data = data;
                    Node current = head;
                    while (current.next != null)
                    {
                        current = current.next;
                    }
                    current.next = toAdd;
                }
            }

            static void Main(string[] args)
            {
                BirdSurvey list = new BirdSurvey();
                for (int x = 0; x < 10; x++)
                {
                    Console.Write("Enter a bird species. ");
                    string listInput = Console.ReadLine();
                    list.AddFirst(listInput);
                }
                list.GetCount();
                Console.WriteLine("***Final Report***");
                list.getReport();

                Console.ReadKey();
            }
        }
    }
}