using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationUC2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkvalue;
            string patt = "Rao";
            Patterns patterns = new Patterns();
            checkvalue = patterns.validLastName(patt);
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
