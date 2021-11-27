using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationUC2
{
    public class Patterns
    {
        public static string REGEX_LASTNAME = "^[A-Z][a-z]{2}$";

        public bool validLastName(string lastName)
        {
            return Regex.IsMatch(lastName, REGEX_LASTNAME);
        }
    }
}
