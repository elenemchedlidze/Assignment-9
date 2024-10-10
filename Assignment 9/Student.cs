using Microsoft.Graph.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EnrollmentYear { get; set; }

        public Student(string firstName, string lastName, int enrollmentYear) //კონსტრუქტორის გდატვირთვა
        {
            FirstName = firstName;
            LastName = lastName;
            EnrollmentYear = enrollmentYear;

        }

        public string RandomModule()
        {
            Console.WriteLine("Please provide a number of modules:");
            var providedNum = Console.ReadLine();
            int arraySize;
            bool isInt = int.TryParse(providedNum, out arraySize);
            var modules = new string[arraySize];
            for ( int i = 0; i < modules.Length; i++ ) // საგნების შევსება
            {
                Console.WriteLine($"Please provide # {i} module of the modules's array");
                string arrayValue = Console.ReadLine();
                modules[i] = arrayValue;

            }

            // რენდომ ინდექსი
            Random random = new Random();
            int minValue = 0;
            int maxValue = arraySize - 1;
            int randomNumber = random.Next(minValue, maxValue);
           
            return modules[randomNumber];
        }

        public int YearsUntilGraduation()
        {
            int totalYears = 4; 
            int currentYear = DateTime.Now.Year;
            int yearsPassed = currentYear - EnrollmentYear;
            return Math.Max(0, totalYears - yearsPassed); 
        }
    }
}
