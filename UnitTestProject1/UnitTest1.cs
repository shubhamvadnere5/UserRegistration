using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexAssignment;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("varunlad5@gmail.com")]
        [DataRow("varunlad19@gmail.com")]
        [DataRow("varunbjscjbs9@gmail.com")]
        public void ValidatingHappy(string mail)//Validating for Valid EmailAddress
        {
            //AAA Methology

            //Arrange
            string excepted = "happy";
            Regex058assignment EmailValidation = new Regex058assignment();

            //ACT
            string actual = EmailValidation.EmailValidation(mail);

            //ASSERT
            Assert.AreEqual(excepted, actual); ;//Checking wether my actual rasult and Excepted Results Matches or not
        }
        [TestMethod]
        [DataRow("varun?>>SDAce.com")]
        [DataRow("varunlad1nckjbnl.com")]
        [DataRow("varunbjscwqcs9@gmail...?com")]
        public void ValidatingSadEmail(string mail) //Validating for invalid EmailAddress
        {
            //AAA Methology

            //Arrange
            string excepted = "sad";
            Regex058assignment EmailValidation = new Regex058assignment(); //Creating a object and passing a message

            //ACT
            string actual = EmailValidation.EmailValidation(mail);

            //ASSERT
            Assert.AreEqual(excepted, actual); ;//Checking wether my actual rasult and Excepted Results Matches or not
        }
        [TestMethod]
        [DataRow("Varun")]
        [DataRow("Chirag")]
        [DataRow("Anuraj")]
        public void ValidatingHappyName(string name)//Valid Name
        {
            //AAA Methology

            //Arrange
            string excepted = "happy";
            Regex058assignment EmailValidation = new Regex058assignment();

            //ACT
            string actual = EmailValidation.NameValidation(name);

            //ASSERT
            Assert.AreEqual(excepted, actual); ;//Checking wether my actual rasult and Excepted Results Matches or not
        }
        [TestMethod]
        [DataRow("varun?")]
        [DataRow("Chira?SF/")]
        [DataRow("anu..--raj")]
        public void ValidatingSadName(string name)//Valid Name
        {
            //AAA Methology
            //Arrange
            string excepted = "sad";
            Regex058assignment EmailValidation = new Regex058assignment();

            //ACT
            string actual = EmailValidation.NameValidation(name);

            //ASSERT
            Assert.AreEqual(excepted, actual); ;//Checking wether my actual rasult and Excepted Results Matches or not
        }
        [TestMethod]
        [DataRow("91 9834978189")]
        [DataRow("91 8805919424")]
        [DataRow("91 9921497032")]
        public void ValidatingHappyMobile(string number)//Valid Mobile Number
        {
            //AAA Methology

            //Arrange
            string excepted = "happy";
            Regex058assignment EmailValidation = new Regex058assignment();

            //ACT
            string actual = EmailValidation.MobileNumberValidation(number);

            //ASSERT
            Assert.AreEqual(excepted, actual); ;//Checking wether my actual rasult and Excepted Results Matches or not
        }
        [TestMethod]
        [DataRow("91 98349789")]
        [DataRow("91 880591424")]
        [DataRow("91 997032")]
        public void ValidatingSadMobile(string number)//Valid Mobile Number
        {
            //AAA Methology

            //Arrange
            string excepted = "sad";
            Regex058assignment EmailValidation = new Regex058assignment();

            //ACT
            string actual = EmailValidation.MobileNumberValidation(number);

            //ASSERT
            Assert.AreEqual(excepted, actual); ;//Checking wether my actual rasult and Excepted Results Matches or not
        }
        [TestMethod]
        [DataRow("91kxhk@123")]
        [DataRow("varun@123")]
        [DataRow("123@456")]
        public void ValidatingHappyPassword(string password)//Validating Correct PassWord
        {
            //AAA Methology
            //Arrange
            string excepted = "happy";
            Regex058assignment EmailValidation = new Regex058assignment();

            //ACT
            string actual = EmailValidation.PassWordValidation(password);

            //ASSERT
            Assert.AreEqual(excepted, actual); ;//Checking wether my actual rasult and Excepted Results Matches or not
        }
        [TestMethod]
        [DataRow("91kxhk123")]
        [DataRow("varun123")]
        [DataRow("12356")]
        public void ValidatingSadPassword(string password)//Validating Correct PassWord
        {
            //AAA Methology
            //Arrange
            string excepted = "sad";
            Regex058assignment EmailValidation = new Regex058assignment();

            //ACT
            string actual = EmailValidation.PassWordValidation(password);

            //ASSERT
            Assert.AreEqual(excepted, actual); ;//Checking wether my actual rasult and Excepted Results Matches or not
        }
    }
}