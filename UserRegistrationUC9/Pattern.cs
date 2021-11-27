using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationUC9
{
   public class Pattern
    {
        public static string REGEX_EMAIL = "^[a][b][c][@][1][.][c][o][m]$";

        public bool validEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
    }
}
