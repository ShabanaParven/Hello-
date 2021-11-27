using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationUC1
{
    public class Patterns
    {
        public static string REGEX_FIRSTNAME = "^[A-Z][a-z]{2}$";

        public bool validFirstName(string firstName)
        
        {
           
            return Regex.IsMatch(firstName, REGEX_FIRSTNAME);
        }
    }
}
