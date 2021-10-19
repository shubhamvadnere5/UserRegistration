using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssignment
{
    public class Regex058assignment
    {
        String emailPattern = "^[a-zA-Z0-9]+[._+]{0,1}[a-zA-Z0-9]*@[a-zA-Z0-9]{1,10}.[a-zA-Z]{2,10}[.]*[a-zA-Z]*$";
        string namePattern = "^[A-Z]{1}[a-z]{3,}$";
        string mobilePattern = "^[0-9]{2}[ ]*[0-9]{10}$";
        string PasswordPattern = "^[a-zA-Z0-9]{1,}[@&*?_-]{1}[a-zA-Z0-9]*$";
        /// <summary>
        /// Validation this instance.
        /// </summary>
        ///
        public string EmailValidation(string mail)
        {
            Regex regrex1 = new Regex(emailPattern);//validating Pattern
            Console.WriteLine("Validating User Email ID : ");
            try
            {
                bool result = regrex1.IsMatch(mail);//matching our input to pattern
                if (result)
                {
                    Console.WriteLine(" It is --->" + "Valid");
                    return "happy";
                }
                else
                {
                    Console.WriteLine(" It is --->" + "Invalid");
                    return "sad";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public string NameValidation(string name)
        {
            Regex regrex2 = new Regex(namePattern);//validating Pattern
            Console.WriteLine("Validating User Email ID : ");
            try
            {
                bool result = regrex2.IsMatch(name);//matching our input to pattern
                if (result)
                {
                    Console.WriteLine(" It is --->" + "Valid");
                    return "happy";
                }
                else
                {
                    Console.WriteLine(" It is --->" + "Invalid");
                    return "sad";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        //}
        public string MobileNumberValidation(string number)
        {
            Regex regex3 = new Regex(mobilePattern);//validating Pattern
            Console.WriteLine("Validating User Email ID : ");
            try
            {
                bool result = regex3.IsMatch(number);//matching our input to pattern
                if (result)
                {
                    Console.WriteLine(" It is --->" + "Valid");
                    return "happy";
                }
                else
                {
                    Console.WriteLine(" It is --->" + "Invalid");
                    return "sad";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
        public string PassWordValidation(string password)
        {
            Regex regex3 = new Regex(PasswordPattern);//validating Pattern
            Console.WriteLine("Validating User Email ID : ");
            try
            {
                bool result = regex3.IsMatch(password);//matching our input to pattern
                if (result)
                {
                    Console.WriteLine(" It is --->" + "Valid");
                    return "happy";
                }
                else
                {
                    Console.WriteLine(" It is --->" + "Invalid");
                    return "sad";
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

    }
}