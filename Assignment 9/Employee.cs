
namespace Assignment_9
{
    class Employee
    {
        // Employee properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }

        // Constructor
        public Employee(string firstName, string lastName, int age, string position)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Position = position;
        }

        public double CalculateWeeklySalary(Dictionary<string, int> weeklyHours)
        {
            double hourlyRate = GetHourlyRate(Position);
            double overtimeRate = hourlyRate + 5;
            double weekendRate = hourlyRate * 2;

            double totalSalary = 0;
            int totalHours = 0;

            // Loop to calculate salary for each day
            foreach (var entry in weeklyHours)
            {
                string day = entry.Key;
                int dailyHours = entry.Value;
                totalHours += dailyHours;

                if (day == "Saturday" || day == "Sunday")  // Weekend
                {
                    totalSalary += dailyHours * weekendRate;
                }
                else
                {
                    if (dailyHours > 8)  // Overtime for weekdays
                    {
                        totalSalary += 8 * hourlyRate + (dailyHours - 8) * overtimeRate;
                    }
                    else
                    {
                        totalSalary += dailyHours * hourlyRate;
                    }
                }
            }

            // Bonus for working > 50 hours 
            if (totalHours > 50)
            {
                totalSalary += totalSalary * 0.2;
            }

            return totalSalary;
        }

        // დამხმარე მეთოდი პოზიციის მიხედვით ანაზღაურების განსაზღვრისთვის
        private double GetHourlyRate(string position)
        {
            switch (position.ToLower())
            {
                case "manager":
                    return 40;
                case "developer":
                    return 30;
                case "tester":
                    return 20;
                default:
                    return 10;
            }
        }
    }
}

