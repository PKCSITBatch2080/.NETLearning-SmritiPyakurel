using System;

namespace Greeter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the value of fullName from the user
            Console.Write("Please enter your full name: ");
            string fullName = Console.ReadLine();

            // Get the value of date of birth from the user
            Console.Write("Please enter your date of birth (YYYY/MM/DD): ");
            string dobString = Console.ReadLine();

            // Parse the user's input for date of birth
            DateTime dob;
            if (DateTime.TryParse(dobString, out dob))
            {
                // Define another variable cFullName and initialize it with fullName in uppercase
                string cFullName = fullName.ToUpper();

                Console.WriteLine("Welcome to the Greeter App!");

                // Print a personalized greeting using the formatted string and user-friendly date
                Console.WriteLine($"Hello, {cFullName} Ji! Have a great day.");
                Console.WriteLine($"Your user-friendly date of birth is: {dob.ToString("MMMM dd, yyyy")}");

                // Calculate the user's age
                TimeSpan age = DateTime.Now - dob;
                int years = (int)(age.TotalDays / 365.25);

                // Display the calculated age to the console
                Console.WriteLine($"You are approximately {years} years old.");
            }
            else
            {
                Console.WriteLine("Invalid date of birth format. Please enter the date in the format (YYYY/MM/DD).");
            }
        }
    }
}
