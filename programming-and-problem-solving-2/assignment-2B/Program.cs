using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2B
{
    public abstract class Vacation
    {
        private decimal budget;
        private string destination;


        public decimal Budget
        {
            get
            {
                return this.budget;
            }

            set
            {
                this.budget = value;
            }
        }

        public string Destination
        {
            get
            {
                return this.destination;
            }

            set
            {
                this.destination = value;
            }
        }

        public Vacation() { }

        public Vacation(decimal budget, string destination)
        {
            this.Budget = budget;
            this.Destination = destination;
        }

        abstract public decimal BudgetReview(decimal budget);
    }

    class AllInclusiveVacation : Vacation
    {
        private string brand;
        private int rating;
        private decimal price;

        public string Brand
        {
            get
            {
                return this.brand;
            }

            set
            {
                this.brand = value;
            }
        }

        public int Rating
        {
            get
            {
                return this.rating;
            }

            set
            {
                this.rating = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                this.price = value;
            }
        }

        //public AllInclusiveVacation()
        //    : base() { }

        public AllInclusiveVacation(decimal budget, string destination)
        : base(budget, destination) { }

        public override decimal BudgetReview(decimal budget)
        {
            decimal difference = budget - this.Price;
            return difference;
        }

        public string getData()
        {
            return $"Compare Budget: ${this.BudgetReview(this.Budget)}\nDestination: {this.Destination}\nBrand: {this.Brand}\nRating: {this.Rating} Stars\nPrice: ${this.Price}\n";
        }
    }

    class PiecemealVacation : Vacation
    {
        private string hotelItem;
        private decimal hotelCost;
        private string mealItem;
        private decimal mealCost;
        private string airfareItem;
        private decimal airfareCost;
        private decimal totalCost;

        public string HotelItem
        {
            get
            {
                return this.hotelItem;
            }

            set
            {
                this.hotelItem = value;
            }
        }

        public decimal HotelCost
        {
            get
            {
                return this.hotelCost;
            }

            set
            {
                this.hotelCost = value;
            }
        }

        public string MealItem
        {
            get
            {
                return this.mealItem;
            }

            set
            {
                this.mealItem = value;
            }
        }

        public decimal MealCost
        {
            get
            {
                return this.mealCost;
            }

            set
            {
                this.mealCost = value;
            }
        }

        public string AirfarelItem
        {
            get
            {
                return this.airfareItem;
            }

            set
            {
                this.airfareItem = value;
            }
        }

        public decimal AirfareCost
        {
            get
            {
                return this.airfareCost;
            }

            set
            {
                this.airfareCost = value;
            }
        }

        public decimal TotalCost
        {
            get
            {
                return this.totalCost;
            }

            set
            {
                this.totalCost = value;
            }
        }

        //public PiecemealVacation()
        //    : base() { }

        public PiecemealVacation(decimal budget, string destination)
            : base(budget, destination) { }

        public override decimal BudgetReview(decimal budget)
        {
            this.TotalCost = this.HotelCost + this.MealCost + this.AirfareCost;
            decimal difference = budget - this.TotalCost;
            return difference;
        }

        public string getData()
        {
            return $"Compare Budget: ${this.BudgetReview(this.Budget)}\nDestination: {this.Destination}\nHotel: {this.HotelItem} ${this.HotelCost}\nMeal: {this.MealItem} ${this.MealCost}\nAirfare: {this.AirfarelItem} ${this.AirfareCost}\n";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            bool more = true;
            Console.Write("What is your vacation budget? ");
            decimal budget = Decimal.Parse(Console.ReadLine());
            do
            {
                Console.Write("Where is your destination? ");
                string destination = Console.ReadLine();
                Console.WriteLine("Do you prefer an All-Inclusive Vacation or a Piecemeal Vacation?");
                Console.Write("Enter a '1' for the first option or a '2' for the second option. ");
                int choice = Int32.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    AllInclusiveVacation myVacation = new AllInclusiveVacation(budget, destination);
                    Console.Write("Which vacation brand will you be using (i.e. ClubMed, Delta Vacations, etc.)? ");
                    myVacation.Brand = Console.ReadLine();
                    Console.WriteLine("How would you rate this brand? ");
                    Console.Write("Enter a number between 1 and 5 inclusive where 1 is the worst and 5 is the best. ");
                    myVacation.Rating = Int32.Parse(Console.ReadLine());
                    Console.Write("What is their bundled price for this vacation? ");
                    myVacation.Price = Decimal.Parse(Console.ReadLine());
                    Console.WriteLine("--------------------");
                    Console.WriteLine($"Budget: ${myVacation.Budget}");
                    Console.WriteLine();
                    Console.WriteLine(myVacation.getData());
                }

                else if (choice == 2)
                {
                    PiecemealVacation myVacation = new PiecemealVacation(budget, destination);
                    Console.Write("Which hotel would you stay in? ");
                    myVacation.HotelItem = Console.ReadLine();
                    Console.Write("How much would hotel rooms cost? ");
                    myVacation.HotelCost = Decimal.Parse(Console.ReadLine());
                    Console.Write("Where would you eat? ");
                    myVacation.MealItem = Console.ReadLine();
                    Console.Write("How much would meals cost? ");
                    myVacation.MealCost = Decimal.Parse(Console.ReadLine());
                    Console.Write("Which airline would you fly with? ");
                    myVacation.AirfarelItem = Console.ReadLine();
                    Console.Write("How much would airfare cost? ");
                    myVacation.AirfareCost = Decimal.Parse(Console.ReadLine());
                    Console.WriteLine("--------------------");
                    Console.WriteLine($"Budget: ${myVacation.Budget}");
                    Console.WriteLine();
                    Console.WriteLine(myVacation.getData());

                }
                Console.WriteLine("Would you like to compare more options? ");
                Console.Write("Please enter 'yes' or 'no'. ");
                string adjust = Console.ReadLine();
                if (adjust == "yes")
                {
                    Console.WriteLine();
                    continue;
                }
                else if (adjust == "no")
                {
                    more = false;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("You did not enter 'yes' or 'no'.");
                    more = false;
                }
            } while (more == true);
            Console.WriteLine();
            Console.Write("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
