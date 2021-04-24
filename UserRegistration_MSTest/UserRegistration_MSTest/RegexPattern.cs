using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration_MSTest
{
    public class RegexPattern
    {
        //Regex patterns for name,email,mobile number andd password.
        public static string namePattern = "^[A-Z][a-z]{2,}$";
        public static string mailIDPattern = "^[0-9a-zA-Z]+([+_.-][0-9a-zA-Z]+)*@[a-zA-Z0-9]+([.][a-zA-Z]{2,3}){1,2}$";
        public static string mobileNumberPattern = "^[1-9]{2}[ ][0-9]{10}";
        public static string passwordPattern = "(?=.*[A-Z]{1,})(?=.*[a-z]{1,})(?=.*[0-9]{1,})(?=.*[@#$%+!]{1}).{8,}";

        //Validatinf first name, last name , email id, mobile number and password.
        public Func<string, string> ValidateFirstName = x => Regex.IsMatch(x, namePattern) ? "Valid First Name" :
           throw new UserException(UserException.ExceptionType.INVALID_FIRSTNAME, "Invalid First Name");

        public Func<string, string> ValidateLastName = x => Regex.IsMatch(x, namePattern) ? "Valid Last Name" :
           throw new UserException(UserException.ExceptionType.INVALID_LASTNAME, "Invalid Last Name");

        public Func<string, string> ValidateEmail = x => Regex.IsMatch(x, mailIDPattern) ? "Valid mailID" :
           throw new UserException(UserException.ExceptionType.INVALID_EMAIL_ID, "Invalid email id");

        public Func<string, string> ValidateMobileNumber = x => Regex.IsMatch(x, mobileNumberPattern) ? "Valid mobile number" :
           throw new UserException(UserException.ExceptionType.INVALID_MOBILE_NUMBER, "Invalid mobile number");

        public Func<string, string> ValidatePassword = x => Regex.IsMatch(x, passwordPattern) ? "Valid password" :
           throw new UserException(UserException.ExceptionType.INVALID_PASSWORD, "Invalid password");   
    }
}