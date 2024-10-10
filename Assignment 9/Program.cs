// See https://aka.ms/new-console-template for more information
using Assignment_9;
using Microsoft.Graph.Models;

Console.WriteLine($"Task 1 ****************** "); Task1();
Console.WriteLine($"Task 2 ****************** "); Task2();

static void Task1()
{
    // კომპანიის ტიპის განსაზღვრა
    Console.WriteLine("Is the company local or foreign?");
    string companyType = Console.ReadLine();

    Company company = new Company(companyType);

    // Employee object-ის შექმნა
    Console.WriteLine("Enter employee's first name:");
    string firstName = Console.ReadLine();
    Console.WriteLine("Enter employee's last name:");
    string lastName = Console.ReadLine();
    Console.WriteLine("Enter employee's age:");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter employee's position (manager, developer, tester, or other):");
    string position = Console.ReadLine();

    Employee employee = new Employee(firstName, lastName, age, position);

    // კვირს დღეების და ნამუშევარი საათების ცნობარის ინიციალიზაცია და შევსება
    var weeklyHours = new Dictionary<string, int>
        {
            { "Monday", 0 },
            { "Tuesday", 0 },
            { "Wednesday", 0 },
            { "Thursday", 0 },
            { "Friday", 0 },
            { "Saturday", 0 },
            { "Sunday", 0 }
        };
    foreach (KeyValuePair<string, int> hours in weeklyHours)
    {
        Console.WriteLine("please provide the number of hours for {0} ", hours.Key);
        var provideNumber = Console.ReadLine();
        bool isProvidedHoursInt = int.TryParse(provideNumber, out int providedHour);
        if (isProvidedHoursInt)
        {
            if (providedHour < 0 || providedHour > 24)
            {
                Console.WriteLine("working hours shouold be more than 0 and less than 24");
            }
            else
            {
                weeklyHours[hours.Key] = providedHour;
            }
        }
        else
        {
            Console.WriteLine("Please provide a proper number of hours");
        }
    }

    // კვირის განმავლობაში ნამუშევარი საათების დაანგარიშება
    double weeklySalary = employee.CalculateWeeklySalary(weeklyHours);

    // tax დაანგარიშება
    double tax = company.CalculateTax(weeklySalary);

    Console.WriteLine($"Employee Weekly Salary: {weeklySalary}");
    Console.WriteLine($"Tax is: {tax}");
}
static void Task2()
{

    Student student = new Student("Nick", "Black", 2022);

    string subject = student.RandomModule();
    Console.WriteLine($"Student's selected subject: {subject}");

    int remainingYears = student.YearsUntilGraduation();
    Console.WriteLine($"Years until graduation: {remainingYears}");

    Teacher teacher = new Teacher("Ms. Smith", true);

    string teacherResponse = teacher.CheckSubject(subject);
    Console.WriteLine(teacherResponse);


}