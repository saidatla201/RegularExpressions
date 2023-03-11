using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    public  class RegexEmail
    {
        public static void Pattern()
        {
            string Pattern=  "^([a-z0-9]){3,}?([-,.,+][a-z0-9]{1,})*@([a-z0-9]){1,}[.][a-z]{2,}?([.][a-z]{2,})?$";
            string[] Email = {"abc@yahoo.com","abc-100@yahoo.com","abc.100@yahoo.com","abc111@abc.com",
                              "abc-100@abc.net","abc.100@abc.com.au","abc@1.com","abc@gmail.com.com","abc+100@gmail.com","abc.1@yahoo.co",
                              "abc","abc@.com.my","abc123@gmail.a","abc123@.com","abc123@.com.com",".abc@abc.com","abc()*@gmail.com",
                              "abc@%*.com","abc..2002@gmail.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a","abc@gmail.com.aa.au"};
            foreach (string Value in Email )
            {
                if(Regex.IsMatch (Value ,Pattern ))
                {
                    Console.WriteLine("{0} is a valid Email", Value );
                }
                else
                {
                    Console.WriteLine("{0} is Invalid Email", Value  );
                }
            }
        }
    }
}
