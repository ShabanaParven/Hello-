using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationUC5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkvalue;
            string patt = "publishh";
            Pattern pattern = new Pattern();
            checkvalue = pattern.validPassword(patt);
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
