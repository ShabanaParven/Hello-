using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationUC1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkvalue;
            string patt = "Sha";
            Patterns patterns = new Patterns();
            checkvalue = patterns.validFirstName(patt);
            if (checkvalue)
            {
                Console.WriteLine("Pattern matched");
            }
            else
            {
                Console.WriteLine("Pattern Not matched");
            }
            Console.ReadKey();
        }
    }
}
