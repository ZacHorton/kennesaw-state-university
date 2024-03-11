using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1B
{
    class Tests
    {
        // Field firstName 
        private string firstName;
        // Field lastName
        private string lastName;
        // Field testScores
        private double[] testScores;

        public string FirstName
        {
            // Getter of the property "FirstName"
            get
            {
                return this.firstName;
            }
            // Setter of the property "FirstName"
            set
            {
                this.firstName = value;
            }
        } // END property

        public string LastName
        {
            // Getter of the property "LastName"
            get
            {
                return this.lastName;
            }
            // Setter of the property "LastName"
            set
            {
                this.lastName = value;
            }
        } // END property

        public double[] TestScores
        {
            // Getter of the property "TestScores"
            get
            {
                return this.testScores;
            }
            // Setter of the property "TestScores"
            set
            {
                this.testScores = value;
            }
        } // END property

        // Default constructor
        public Tests()
        {
            this.firstName = "unknown";
            this.LastName = "unknown";
            this.testScores = new double[5];
        }

        // Constructor with parameters
        public Tests(string firstName, string lastName, double[] testScores)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.testScores = testScores;
        }

        // Returns average test scores
        public double studentAverage()
        {
            double total = 0;
            int count = this.testScores.Length;
            foreach (var element in testScores) {
                total += element;
            }
            double average = total / count;
            return Math.Round(average, 2);
        } // END studentAverage()

        // Returns character grade
        public char studentGrade()
        {
            char grade;
            double temp = this.studentAverage();
            if (temp >= 90)
            {
                grade = 'A';
                return grade;
            }
            else if (temp >= 80)
            {
                grade = 'B';
                return grade;
            }
            else if (temp >= 70)
            {
                grade = 'C';
                return grade;
            }
            else if (temp >= 60)
            {
                grade = 'D';
                return grade;
            }
            else
            {
                grade = 'F';
                return grade;
            }
        } // END studentGrade()

        // Returns all data for given object
        public void returnAll()
        {
            Console.WriteLine(this.firstName + "\t\t" + this.lastName + "\t\t" + this.testScores[0] + "\t" + this.testScores[1] + "\t" + this.testScores[2] + "\t" + this.testScores[3] + "\t" + this.testScores[4] + "\t" + this.studentAverage() + "\t" + this.studentGrade());
        }
        // END returnAll()
    } // END class Tests
} // END namespace Assignment_1B