using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2A
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget; string destination;  int choice;
            Console.Write("How much is your vacation budget? ");
            budget = Decimal.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Where is your destination? ");
            destination = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Do you prefer an All-Inclusive Vacation or a Piecemeal Vacation?");
            Console.Write("Enter a '1' for the first option or a '2' for the second option. ");
            choice = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            if (choice == 1)
            {
                AllInclusiveVacation test1 = new AllInclusiveVacation();
                Console.Write("Which vacation brand will you be using (i.e. ClubMed, Delta Vacations, etc.)? ");
                test1.Brand = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("How would you rate this brand? ");
                Console.Write("Enter a number between 1 and 5 inclusive where 1 is the worst and 5 is the best. ");
                test1.Rating = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("What is their bundled price for this vacation? ");
                test1.Price = Decimal.Parse(Console.ReadLine());
                Console.WriteLine();
                Test.Testing(test1.BudgetReview(budget));
            }

            else if (choice == 2)
            {
                PiecemealVacation test2 = new PiecemealVacation();
                Console.Write("How much will hotels cost on this vacation? ");
                test2.Hotels = Decimal.Parse(Console.ReadLine());
                Console.Write("How much will meals cost on this vacation? ");
                test2.Meals = Decimal.Parse(Console.ReadLine());
                Console.Write("How much will airfare cost on this vacation? ");
                test2.Airfare = Decimal.Parse(Console.ReadLine());
                Console.Write("How much will gasoline cost on this vacation? ");
                test2.Gasoline = Decimal.Parse(Console.ReadLine());
                Console.WriteLine();
                Test.Testing(test2.BudgetReview(budget));
            }

            else
            {
                Console.WriteLine("You did not enter a '1' or '2'.");
            }

            Console.ReadKey();
        }
    }
}
