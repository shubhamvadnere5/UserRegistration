using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexAssignment;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidatingHappy()//Validating for Valid EmailAddress
        {
            //AAA Methology

            //Arrange
            string excepted = "happy";
            string input = "varunlad5@gmail.com";
            Regex058assignment EmailValidation = new Regex058assignment(input);

            //ACT
            string actual = EmailValidation.EmailValidation();

            //ASSERT
            Assert.AreEqual(excepted, actual); ;//Checking wether my actual rasult and Excepted Results Matches or not
        }
        [TestMethod]
        public void ValidatingSadEmail() //Validating for invalid EmailAddress
        {
            //AAA Methology

            //Arrange
            string excepted = "sad";
            string input = "varun??d5@gmail.com";
            Regex058assignment EmailValidation = new Regex058assignment(input); ;//Creating a object and passing a message

            //ACT
            string actual = EmailValidation.EmailValidation();

            //ASSERT
            Assert.AreEqual(excepted, actual); ;//Checking wether my actual rasult and Excepted Results Matches or not
        }
        [TestMethod]

        public void ValidatingHappyName()//Valid Name
        {
            //AAA Methology

            //Arrange
            string excepted = "happy";
            string input = "Varun";
            Regex058assignment EmailValidation = new Regex058assignment(input);

            //ACT
            string actual = EmailValidation.NameValidation();

            //ASSERT
            Assert.AreEqual(excepted, actual); ;//Checking wether my actual rasult and Excepted Results Matches or not
        }
        [TestMethod]
        public void ValidatingSadName()//Invalid Nmae
        {
            //AAA Methology

            //Arrange
            string excepted = "sad";
            string input = "varun?";
            Regex058assignment EmailValidation = new Regex058assignment(input); ;//Creating a object and passing a message

            //ACT
            string actual = EmailValidation.NameValidation();

            //ASSERT
            Assert.AreEqual(excepted, actual); ;//Checking wether my actual rasult and Excepted Results Matches or not
        }
        [TestMethod]

        public void ValidatingHappyMobile()//Valid Mobile Number
        {
            //AAA Methology

            //Arrange
            string excepted = "happy";
            string input = "91 9834978189";
            Regex058assignment EmailValidation = new Regex058assignment(input);

            //ACT
            string actual = EmailValidation.MobileNumberValidation();

            //ASSERT
            Assert.AreEqual(excepted, actual); ;//Checking wether my actual rasult and Excepted Results Matches or not
        }
        [TestMethod]
        public void ValidatingSadMobile()//Invalid Mobile Number
        {
            //AAA Methology

            //Arrange
            string excepted = "sad";
            string input = "varun?";
            Regex058assignment EmailValidation = new Regex058assignment(input); ;//Creating a object and passing a message

            //ACT
            string actual = EmailValidation.MobileNumberValidation();

            //ASSERT
            Assert.AreEqual(excepted, actual); ;//Checking wether my actual rasult and Excepted Results Matches or not
        }

        public void ValidatingHappyPassword()//Validating Correct PassWord
        {
            //AAA Methology

            //Arrange
            string excepted = "happy";
            string input = "Sa1_1ksHawsfn";
            Regex058assignment EmailValidation = new Regex058assignment(input);

            //ACT
            string actual = EmailValidation.PassWordValidation();

            //ASSERT
            Assert.AreEqual(excepted, actual); ;//Checking wether my actual rasult and Excepted Results Matches or not
        }
        [TestMethod]
        public void ValidatingSadPassWord()//Validating Incorrect PassWord
        {
            //AAA Methology

            //Arrange
            string excepted = "sad";
            string input = "9198scv8189";
            Regex058assignment EmailValidation = new Regex058assignment(input); ;//Creating a object and passing a message

            //ACT
            string actual = EmailValidation.PassWordValidation();

            //ASSERT
            Assert.AreEqual(excepted, actual); ;//Checking wether my actual rasult and Excepted Results Matches or not
        }
    }
}