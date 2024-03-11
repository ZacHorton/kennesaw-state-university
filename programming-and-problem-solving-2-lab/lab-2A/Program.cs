using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2A
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Person Object
            Person paul = new Person();
            paul.Name = "Paul Green";
            paul.Address = "Woodstock, GA";
            paul.PhoneNumber = "(123)456-789";
            paul.EmailAddress = "example1@outlook.com";
            paul.DisplayPerson();
            Console.WriteLine();

            // Create Student Object
            Student zac = new Student();
            zac.Name = "Zac Horton";
            zac.Address = "Roswell, GA";
            zac.PhoneNumber = "(234)567-891";
            zac.EmailAddress = "zhorton1@students.kennesaw.edu";
            zac.Status = zac.ClassStatus[1];
            zac.DisplayStudent();
            Console.WriteLine();

            // Create Employee Object
            Employee john = new Employee();
            john.Name = "John Brown";
            john.Address = "Brookhaven, GA";
            john.PhoneNumber = "(345)678-912";
            john.EmailAddress = "example2@outlook.com";
            john.Office = "Atlanta Branch";
            john.Salary = 100000;
            john.DateHired = "1/1/2010";
            john.DisplayEmployee();
            Console.WriteLine();

            // Create Faculty Object
            Faculty mike = new Faculty();
            mike.Name = "Mike Purple";
            mike.Address = "Evans, GA";
            mike.PhoneNumber = "(456)789-123";
            mike.EmailAddress = "example3@outlook.com";
            mike.Office = "Augusta Branch";
            mike.Salary = 75000;
            mike.DateHired = "1/1/2015";
            mike.OfficeHours = "8am to 5pm";
            mike.Rank = "Instructor";
            mike.DisplayFaculty();
            Console.WriteLine();

            // Create Staff Object
            Staff george = new Staff();
            george.Name = "George Red";
            george.Address = "Kennesaw, GA";
            george.PhoneNumber = "(567)891-234";
            george.EmailAddress = "example4@outlook.com";
            george.Office = "Kennesaw Branch";
            george.Salary = 60000;
            george.DateHired = "1/1/2019";
            george.Title = "Manager";
            george.DisplayStaff();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
