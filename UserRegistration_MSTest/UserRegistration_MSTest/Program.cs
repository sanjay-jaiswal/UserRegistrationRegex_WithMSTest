using System;

namespace UserRegistration_MSTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            RegexPattern pattern = new RegexPattern();
            Console.WriteLine("====================Welcome To User Registration Program=======================");

            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine(pattern.ValidateFirstName(firstName));
           
            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine(pattern.ValidateLastName(lastName));

            Console.WriteLine("Enter Email ID:");
            string emailID = Console.ReadLine();
            Console.WriteLine(pattern.ValidateEmail(emailID));

            Console.WriteLine("Enter Mobile Number:");
            string mobileNumber = Console.ReadLine();
            Console.WriteLine(pattern.ValidateMobileNumber(mobileNumber));

            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            Console.WriteLine(pattern.ValidatePassword(password));
        }
    }
}