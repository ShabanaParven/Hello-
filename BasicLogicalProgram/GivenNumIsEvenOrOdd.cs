using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgram
{
    public class GivenNumIsEvenOrOdd
    {
        public void printEvenOrOdd()
        {
            int num, remainder;
           
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());

            remainder = num % 2;
         
            if(remainder == 0)
            {
                Console.WriteLine("given number is even");
            }
            else
            {
                Console.WriteLine("given number is odd");
            }

        }
    }
}
