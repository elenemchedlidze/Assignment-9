using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9
{
    class Company
    {
        public bool isLocal { get; set; }

        // Constructor
        public Company(string companyType)
        {
            if (companyType.ToLower() == "local")
            {
                isLocal = true;
            }
            else if (companyType.ToLower() == "foreign")
            {
                isLocal = false;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'local' or 'foreign'");
            }
        }

        public double CalculateTax(double totalGrossSalary)
        {
            if (isLocal)
            {
                return totalGrossSalary * 0.18;
            }
            else
            {
                return totalGrossSalary * 0.05;
            }
        }
    }
}
    