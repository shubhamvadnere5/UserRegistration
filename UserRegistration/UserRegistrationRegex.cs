using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{/// <summary>
/// UC3 creating regular expression for validating Email
/// </summary>
    class UserRegistrationRegex
    {

        string pattern = "^[0-9]{2}[ ]*[0-9]{10}$";
        //writing the valid pattern
        string[] inputs = { "903464352", "91 9834471126", "S792479017134", "56 740921740", "Bfg24124 Gk25125ajx", "abc@1.com", "Shubham" };//Validating some Example

        /// <summary>
        /// Validation this instance.
        /// </summary>
        public void Validation()
        {
            Regex regrex1 = new Regex(pattern);
            Console.WriteLine("Validating User mobileNumber: ");
            ItarateLoop(inputs, regrex1);
        }
        public void ItarateLoop(string[] arr, Regex regrex1)
        {
            for (int i = 0; i < arr.Length; i++)//validation Loop
            {
                bool result = regrex1.IsMatch(arr[i]);
                if (result)
                {
                    Console.WriteLine(arr[i] + " It is --->" + "Valid");
                }
                else
                {
                    Console.WriteLine(arr[i] + " It is --->" + "Invalid");
                }
            }
        }



    }
}