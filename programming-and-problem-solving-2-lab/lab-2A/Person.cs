using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2A
{
    class Person
    {   
        private string name;
        private string address;
        private string phoneNumber;
        private string emailAddress;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            } 
        } 

        public string Address
        {
            get
            {
                return this.address;
            }

            set
            {
                this.address = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }

            set
            {
                this.phoneNumber = value;
            }
        }

        public string EmailAddress
        {
            get
            {
                return this.emailAddress;
            }

            set
            {
                this.emailAddress = value;
            }
        }

        public void DisplayPerson()
        {
            // $ - string interpolation
            Console.WriteLine($"Class: {this.GetType().Name}\tName: {this.Name}\tAddress: {this.Address}\tPhone Number: {this.PhoneNumber}\tEmail Address: {this.EmailAddress}");
        }

    } // END class Person

    class Student : Person
    {
        // readonly to declare a const array
        private readonly string[] classStatus = {"freshman", "sophomore", "junior", "senior"};
        private string status;

        public string[] ClassStatus
        {
            get
            {
                return this.classStatus;
            }
        }

        public string Status
        {
            get
            {
                return this.status;
            }

            set
            {
                this.status = value;
            }
        }

        public void DisplayStudent()
        {
            // $ - string interpolation
            Console.WriteLine($"Class: {this.GetType().Name}\tName: {this.Name}\tAddress: {this.Address}\tPhone Number: {this.PhoneNumber}\tEmail Address: {this.EmailAddress}\nClass Status: {this.Status}");
        }

    } // END class Student

    class Employee : Person
    {
        private string office;
        private int salary;
        private string dateHired;

        public string Office
        {
            get
            {
                return this.office;
            }

            set
            {
                this.office = value;
            }
        }

        public int Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                this.salary = value;
            }
        }

        public string DateHired
        {
            get
            {
                return this.dateHired;
            }

            set
            {
                this.dateHired = value;
            }
        }

        public void DisplayEmployee()
        {
            Console.WriteLine($"Class: {this.GetType().Name}\tName: {this.Name}\tAddress: {this.Address}\tPhone Number: {this.PhoneNumber}\tEmail Address: {this.EmailAddress}\nOffice: {this.Office}\tSalary: {this.Salary}\tDate Hired: {this.DateHired}");
        }
    } // END class Employee

    class Faculty : Employee
    {
        private string officeHours;
        private string rank;

        public string OfficeHours
        {
            get
            {
                return this.officeHours;
            }

            set
            {
                this.officeHours = value;
            }
        }

        public string Rank
        {
            get
            {
                return this.rank;
            }

            set
            {
                this.rank = value;
            }
        
        
        }

        public void DisplayFaculty()
        {
            Console.WriteLine($"Class: {this.GetType().Name}\tName: {this.Name}\tAddress: {this.Address}\tPhone Number: {this.PhoneNumber}\tEmail Address: {this.EmailAddress}\nOffice: {this.Office}\tSalary: {this.Salary}\tDate Hired: {this.DateHired}\tOffice Hours: {this.OfficeHours}\tRank: {this.Rank}");
        }
    } // END class Faculty

    class Staff : Employee
    {
        private string title;

        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                this.title = value;
            }
        }

        public void DisplayStaff()
        {
            Console.WriteLine($"Class: {this.GetType().Name}\tName: {this.Name}\tAddress: {this.Address}\tPhone Number: {this.PhoneNumber}\tEmail Address: {this.EmailAddress}\nOffice: {this.Office}\tSalary: {this.Salary}\tDate Hired: {this.DateHired}\tTitle: {this.Title}");
        }
    } // END class Staff
} // END namespace Lab_2A
