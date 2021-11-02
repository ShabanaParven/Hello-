using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgram
{
    class PrimeFactor
    {
        public void primeFactor()
        {
            int a, b;
            Console.WriteLine("enter the integer");
            a = Convert.ToInt32(Console.ReadLine());

            for (b=1; b<=a; b++)
            {
                if (a % b == 0)
                {
                    Console.WriteLine(b + "is a factor of " + a);
                }
            }
            


        }
    }
}
