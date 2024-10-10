using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9
{
    internal class Teacher
    {
        public string Name { get; set; }
        public bool IsCertified { get; set; }

        public Teacher(string name, bool isCertified)
        {
            Name = name;
            IsCertified = isCertified;
        }

        // Method to check the subject provided by the student
        public string CheckSubject(string subject)
        {
            switch (subject)
            {
                case "Mathematics":
                    int randomNum1 = new Random().Next(1, 100); // Random number between 1 and 100
                    int randomNum2 = new Random().Next(1, 100);
                    int sum = randomNum1 + randomNum2;
                    return $"Mathematics: The sum of {randomNum1} and {randomNum2} is {sum}.";

                case "Chemistry":
                    return "Chemistry: H2O  is a common chemical formula.";

                case "English":
                    return "English: Hello, how are you?";

                default:
                    return $"{subject}: The teacher is not competent in this subject.";
            }
        }
    }
}
