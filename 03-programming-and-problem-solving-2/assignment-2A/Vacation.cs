using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2A
{
    public abstract class Vacation
    {
        private decimal budget;
        private string destination;
        private decimal price;

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

        public virtual decimal BudgetReview(decimal budget)
        // Returns how much the vacation is over or under budget.
        {
            decimal difference = budget - this.Price;
            return difference;
        }

    } 

    public class AllInclusiveVacation : Vacation
    {
        private string brand;
        private int rating;

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
                if (value >= 1 && value <= 5)
                {
                    this.rating = value;
                }
                else
                {
                    Console.WriteLine("Please try again using a rating between 1 and 5 inclusive.");
                }

            }
        }
    }

    public class PiecemealVacation : Vacation
    {
        private decimal hotels;
        private decimal meals;
        private decimal airfare;
        private decimal gasoline;

        public override decimal BudgetReview(decimal budget)
        {
            decimal difference = budget - (this.Hotels + this.Meals + this.Airfare + this.Gasoline);
            return difference;
        }

        public decimal Hotels
        {
            get
            {
                return this.hotels;
            }

            set
            {
                this.hotels = value;
            }
        }

        public decimal Meals
        {
            get
            {
                return this.meals;
            }

            set
            {
                this.meals = value;
            }
        }

        public decimal Airfare
        {
            get
            {
                return this.airfare;
            }

            set
            {
                this.airfare = value;
            }
        }

        public decimal Gasoline
        {
            get
            {
                return this.gasoline;
            }

            set
            {
                this.gasoline = value;
            }
        }
    }
}