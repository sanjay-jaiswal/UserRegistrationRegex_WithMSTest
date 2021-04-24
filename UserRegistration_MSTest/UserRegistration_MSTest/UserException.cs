using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration_MSTest
{
    public class UserException : Exception
    {
        public enum ExceptionType
        {
            ENTERD_NULL_EXCEPTION,
            ENTERD_EMPTY_EXCEPTION, 
            IVALID_INPUT,
            INVALID_FIRSTNAME,
            INVALID_LASTNAME,
            INVALID_PASSWORD,
            INVALID_EMAIL_ID,
            INVALID_MOBILE_NUMBER
        }

        /// <summary>
        /// Created a type variable of Type ExceptionType
        /// </summary>
        ExceptionType type;
        readonly string message;

        /// <summary>
        /// Parameterised constructor 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public UserException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
            this.message = message;
        }
    }
}