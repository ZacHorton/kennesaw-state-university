using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many students are in the class? ");
            int objectTotal = Convert.ToInt32(Console.ReadLine());
            Tests[] objects = new Tests[objectTotal];
            for (int x = 0; x < objectTotal; x++)
            {
                objects[x] = new Tests();
                Console.Write("Enter student's first and last name seperated by a space: ");
                string input1 = Console.ReadLine();
                string[] fullName = input1.Split(' ');
                objects[x].FirstName = fullName[0];
                objects[x].LastName = fullName[1];
                Console.Write("Enter student's test scores, each seperated by a space: ");
                string input2 = Console.ReadLine();
                string[] testScores = input2.Split(' ');
                objects[x].TestScores = Array.ConvertAll(testScores, double.Parse);
                Console.WriteLine();
            } // END for loop

            Console.WriteLine("First Name\tLast Name\tTest1\tTest2\tTest3\tTest4\tTest5\tAverage\tGrade");
            double total = 0;
            double classAverage;
            foreach (var element in objects)
            {
                total += element.studentAverage();
                element.returnAll();
            }
            classAverage = total / objectTotal;
            Console.WriteLine();
            Console.WriteLine("Class Average = {0}", Math.Round(classAverage, 2));
            
            Console.ReadKey();
        } // END Main
    } // END class Program
} // END namespace Assignment_1B