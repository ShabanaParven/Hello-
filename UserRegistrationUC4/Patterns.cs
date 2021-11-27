using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationUC4
{
    public class Patterns
    {
        public static string REGEX_MOBNUMBER = "^[+][9][1] [6-9]{1}[0-9]{9}$";

        public bool validMobNum(string mobNum)
        {
            return Regex.IsMatch(mobNum, REGEX_MOBNUMBER);
        }
    }
}
