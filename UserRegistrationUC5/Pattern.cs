using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationUC5
{
    public class Pattern
    {
        public static string REGEX_PASSWORD = "^[a-z]{8}$";

        public bool validPassword(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
    }
}
