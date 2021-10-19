using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRegistrationRegex user = new UserRegistrationRegex();
            user.Validation();
            Console.ReadLine();
        }
    }
}