using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationUC4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkvalue;
            string patt = "+91 6360132491";
            Patterns patterns = new Patterns();
            checkvalue = patterns.validMobNum(patt);
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
