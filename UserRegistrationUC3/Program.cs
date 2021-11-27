using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationUC3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkvalue;
            string patt = "abc.sha@bl.co.in";
            Patterns patterns = new Patterns();
            checkvalue = patterns.validEmail(patt);
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
