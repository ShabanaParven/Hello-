using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationUC9
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool checkvalue;
            string patt = "abc@1.com";
            Pattern patterns = new Pattern();
            checkvalue = patterns.validEmail(patt);
            if (checkvalue)
            {
                Console.WriteLine("pattern matched");
                Console.WriteLine("Clear email sample");
            }
            else
            {
                Console.WriteLine("No matched");
            }
            Console.ReadKey();
        }
    }
}
