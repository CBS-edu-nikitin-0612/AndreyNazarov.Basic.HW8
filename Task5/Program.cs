using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type your date of birthday in format \"01-01-2000\" and press enter");
            string input = Console.ReadLine();
            DateTime birthdayDate;
            if (DateTime.TryParse(input, out birthdayDate))
            {
                TimeSpan timeSpan = birthdayDate.AddYears(DateTime.Now.Year - birthdayDate.Year) - DateTime.Now;
                Console.WriteLine($"Until your birthday left {timeSpan.Days} days");
            }
            else
            {
                Console.WriteLine("Date of your birthday had not parsed");
            }
        }
    }
}
