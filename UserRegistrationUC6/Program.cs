using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationUC6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkvalue;
            string patt = "Acadamic";
            Patterns patterns = new Patterns();
            checkvalue = patterns.validPassword(patt);
            if (checkvalue)
            {
                Console.WriteLine("pattern matched");
            }
            else
            {
                Console.WriteLine("No matched");
            }
            Console.ReadKey();
        }
    }
}
