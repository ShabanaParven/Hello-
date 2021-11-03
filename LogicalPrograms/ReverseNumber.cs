using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class ReverseNumber
    {
        public void printReverseNumber()
        {
            int number = 345;
            int remainder, revNumber = 0;

            while (number > 0)
            {
                remainder = number % 10;
                number = number / 10;
                revNumber = (revNumber * 10) + remainder;
            }
            Console.WriteLine("Reverse number is:" + revNumber);
        }
    }
}
