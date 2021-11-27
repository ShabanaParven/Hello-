using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationUC8
{
    public class Pattern
    {
        public static string REGEX_PASSWORD = "^[A-Z]{1}[0-9]{1}[@][a-z]{5}$";

        public bool validPassword(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
    }
}
