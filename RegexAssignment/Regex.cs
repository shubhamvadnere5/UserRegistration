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
        public string inputs;

        public Regex058assignment(string inputs)
        {
            this.inputs = inputs;
        }
        public string EmailValidation()
        {
            Regex regrex1 = new Regex(emailPattern);
            Console.WriteLine("Validating User Email ID : ");
            try
            {
                for (int i = 0; i < inputs.Length; i++)//validation Loop
                {
                    bool result = regrex1.IsMatch(inputs);
                    if (result)
                    {
                        Console.WriteLine(inputs + " It is --->" + "Valid");
                        return "happy";
                    }
                    else
                    {
                        Console.WriteLine(inputs + " It is --->" + "Invalid");
                        return "sad";
                    }
                }
                return null;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public string NameValidation()
        {
            Regex regrex2 = new Regex(namePattern);
            Console.WriteLine("Validating User Email ID : ");
            try
            {
                for (int i = 0; i < inputs.Length; i++)//validation Loop
                {
                    bool result = regrex2.IsMatch(inputs);
                    if (result)
                    {
                        Console.WriteLine(inputs + " It is --->" + "Valid");
                        return "happy";
                    }
                    else
                    {
                        Console.WriteLine(inputs + " It is --->" + "Invalid");
                        return "sad";
                    }
                }
                return null;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
        public string MobileNumberValidation()
        {
            Regex regex3 = new Regex(mobilePattern);
            Console.WriteLine("Validating User Email ID : ");
            try
            {
                for (int i = 0; i < inputs.Length; i++)//validation Loop
                {
                    bool result = regex3.IsMatch(inputs);
                    if (result)
                    {
                        Console.WriteLine(inputs + " It is --->" + "Valid");
                        return "happy";
                    }
                    else
                    {
                        Console.WriteLine(inputs + " It is --->" + "Invalid");
                        return "sad";
                    }
                }
                return null;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
        public string PassWordValidation()
        {
            Regex regex3 = new Regex(PasswordPattern);
            Console.WriteLine("Validating User Email ID : ");
            try
            {
                for (int i = 0; i < inputs.Length; i++)//validation Loop
                {
                    bool result = regex3.IsMatch(inputs);
                    if (result)
                    {
                        Console.WriteLine(inputs + " It is --->" + "Valid");
                        return "happy";
                    }
                    else
                    {
                        Console.WriteLine(inputs + " It is --->" + "Invalid");
                        return "sad";
                    }
                }
                return null;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

    }
}