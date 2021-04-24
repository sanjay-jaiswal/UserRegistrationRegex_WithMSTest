using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration_MSTest;


namespace UserRegistration_TEST
{

    [TestClass]
    public class Test
    {
        private readonly RegexPattern regexPatterns;
        private readonly object DataRow;

        public Test()
        {
            regexPatterns = new RegexPattern();
        }

        /// <summary>
        /// Validate first name
        /// </summary>
        [TestMethod]
        [DataRow("Sanju")]
        [DataRow("Jaiswal")]
        [DataRow("Bridgelabz")]
        [DataRow("Solutions")]
        [DataRow("Sanjay")]
        [DataRow("Vishal")]
        [DataRow("Priyanshu")]
        [DataRow("Ankita")]
        [DataRow("Nilima")]
        [DataRow("Arjun")]
        [DataRow("Saurabh")]
        public void Given_FirstName_StartsWithCapital_MinThreeCharacter_ShouldReturnTrue(string name)
        {
            try
            {
                string result = regexPatterns.ValidateFirstName(name);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Valid First Name", e.Message);
            }
        }

        /// <summary>
        /// If entered Invalid last name should return false.
        /// </summary>
        [TestMethod]
        [DataRow("priyanshu")]
        [DataRow("sanju")]
        [DataRow("anshu")]
        [DataRow("himanshu")]
        [DataRow("shubham")]
        [DataRow("bridgelabz")]
        [DataRow("jobs")]
        public void GivenFirstName_IfNotStartsWithCapital_ButMinThreeCharacter_ShouldReturnFalse(string invalidFirstName)
        {
            try
            {
                string result = regexPatterns.ValidateFirstName(invalidFirstName);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Invalid First Name", e.Message);
            }
        }

        /// <summary>
        /// Test Method to validate first name
        /// </summary>
        [TestMethod]
        [DataRow("PRIYANSHU")]
        [DataRow("SANJU")]
        [DataRow("ANSHU")]
        [DataRow("HIMANSHU")]
        [DataRow("SHUBHAM")]
        [DataRow("BISHAL")]
        [DataRow("GIVEMEJOB")]
        public void GivenFirstName_IfAll_LettersAreCapital_AndMinThreeCharacters_ShouldReturnFalse(string invalidFirstName)
        {
            try
            {
                string result = regexPatterns.ValidateFirstName(invalidFirstName);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Invalid First Name", e.Message);
            }
        }


        /// <summary>
        /// InValidate last name
        /// </summary>
        [TestMethod]
        [DataRow("PR")]
        [DataRow("SA")]
        [DataRow("AN")]
        [DataRow("HI")]
        [DataRow("SH")]
        [DataRow("BIL")]
        [DataRow("GI")]
        public void GivenlastName_WhenStartsWithCapital_AndLessThanThreeCharacter_ShouldReturnFalse(string invalidLastName)
        {
            try
            {
                string result = regexPatterns.ValidateLastName(invalidLastName);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Invalid Last Name", e.Message);
            }
        }

        /// <summary>
        /// Validate last name
        /// </summary>
        [TestMethod]
        [DataRow("priyanshu")]
        [DataRow("sanju")]
        [DataRow("anshu")]
        [DataRow("himanshu")]
        [DataRow("shubham")]
        [DataRow("bridgelabz")]
        [DataRow("jobs")]
        public void GivenLastName_WhenNotStartsWithCapAndMinThreeChar_ShouldReturnFalse(string invalidLastName)
        {
            try
            {
                string result = regexPatterns.ValidateLastName(invalidLastName);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Invalid Last Name", e.Message);
            }
        }

        /// <summary>
        /// Validate last name
        /// </summary>
        [TestMethod]
        [DataRow("PRIYANSHU")]
        [DataRow("SANJU")]
        [DataRow("ANSHU")]
        [DataRow("HIMANSHU")]
        [DataRow("SHUBHAM")]
        [DataRow("BISHAL")]
        [DataRow("GIVEMEJOB")]
        public void GivenLastName_WhenAllLettersAreCapital_AndMinThreeChar_ShouldReturnFalse(string invalidLastName)
        {
            try
            {
                string result = regexPatterns.ValidateLastName(invalidLastName);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Invalid Last Name", e.Message);
            }
        }

        /// <summary>
        /// Test Method to pass invalid email id.
        /// </summary>
        [TestMethod]
        [DataRow("sanju@gmail")]
        [DataRow("sanju@gmail.comm")]
        [DataRow("sanju@gmail.com.ind.us")]
        [DataRow("sanju.#100@gmail")]
        [DataRow("sanju11@gmail.com.a12")]
        [DataRow("sanju@gmail.com.12sa")]
        [DataRow("_sanju@gmail.com")]
        public void GivenEmailId_WhenIsNotProper_ShouldReturnFalse(string emailInvalid)
        {
            try
            {
                string result = regexPatterns.ValidateEmail(emailInvalid);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Invalid email id", e.Message);
            }
        }

        /// <summary>
        /// passing invalid mobile number patterns should return invalid mobile number
        /// </summary>
        [TestMethod]
        [DataRow ("91 9976655")]
        [DataRow("91 776655")]
        [DataRow("91 8776655")]
        [DataRow("91 976655")]
        [DataRow("91 98776655")]
        [DataRow("91 988776655")]
        [DataRow("919445588776655")]
        [DataRow("91988776655")]
        public void GivenInvalidMobileNumber_ShouldReturnFalse(string invalidMobile)
        {
            try
            {
                string result = regexPatterns.ValidateMobileNumber(invalidMobile);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Invalid mobile number", e.Message);
            }
        }

        /// <summary>
        /// Pssing all possible invalid password patterns should return invalid password.
        /// </summary>
        [TestMethod]
        [DataRow("sanj55")]
        [DataRow("sanju.12")]
        [DataRow("Sanjujaisw")]
        [DataRow("SADFGH12345")]
        [DataRow("bridgelabz#")]
        [DataRow("Bridgelabz_#")]
        [DataRow("sanj55%djks")]
        [DataRow("sanj55SDFGH")]
        [DataRow("sanj_32SDFG")]
        [DataRow("sanj55_Ghsjs")]
        [DataRow("sanj55_@#$%")]
        public void GivenInvalidPassword_ShouldReturnFalse(string invalidPassword)
        {
            try
            {
                string result = regexPatterns.ValidatePassword(invalidPassword);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Invalid password", e.Message);
            }
        }

        /// <summary>
        /// Passing invalid email samples should return invalid nemail id.
        /// </summary>
        /// <param name="invlidEmailSamples"></param>
        [TestMethod]
        [DataRow("abc")]
        [DataRow("abc123@gmail.a")]
        [DataRow("abc123@.com")]
        [DataRow("abc123@.com.com")]
        [DataRow(".abc@abc.com")]
        [DataRow("abc()*@gmail.com")]
        [DataRow("abc@%*.com")]
        [DataRow("abc..2002@gmail.com")]
        [DataRow("abc.@gmail.com")]
        [DataRow("abc@abc@gmail.com")]
        [DataRow("abc@gmail.com.2a")]
        [DataRow("abc@gmail.com.aa.au")]
        public void GivenEmails_WhenChecked_ShouldReturnFalse(string invlidEmailSamples)
        {
            try
            {
                string result = regexPatterns.ValidateEmail(invlidEmailSamples);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Invalid email id", e.Message);
            }
        }

    }
}