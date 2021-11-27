using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationUC3
{
    public class Patterns
    {
        public static string REGEX_Email = "^[a][b][c][.][a-z]{3}[@][b][l][.][c][o][.][a-z]{2}$";

        public bool validEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_Email);
        }
    }
}
