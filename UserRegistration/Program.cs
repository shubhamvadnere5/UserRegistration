﻿using System;
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
                string inputs = "abc@yahoo.com";
                Regex058assignment name = new Regex058assignment(inputs);
                name.EmailValidation();
                Console.ReadLine();
            }
        }
    }
