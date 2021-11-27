using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationUC6
{
    public class Patterns
    {
        public static string REGEX_PASSWORD = "^[A-Z]{1}[a-z]{7}$";

        public bool validPassword(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
    }
}
