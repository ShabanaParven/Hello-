using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgram
{
    public class LeapYear
    {
        public void printLeapYearOrNot()
        {
            int year;

            Console.WriteLine("Enter the year");
            year = Convert.ToInt32(Console.ReadLine());

            if((year % 400 == 0) || (year % 4 == 0) && (year % 100 != 0))
            {
                Console.WriteLine("its as LeapYear year");
            }
            else
            {
                Console.WriteLine("its not a leap year");
            }
         
        }
           
    }
}
