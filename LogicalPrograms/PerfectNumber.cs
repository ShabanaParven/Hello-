using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public void printPerfectNumber()
        {
            int n, sum = 0;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            
            for (int i=1;i<n;i++)
            {
                if (n%i==0)
                {
                    sum = sum + i;
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine("sum of dividors are {0} ", sum);
            if(sum==n)
            {
                Console.WriteLine("Number is perfect number");
            }
            else
            {
                Console.WriteLine("Number is not a perfect number");
            }
        }
    }
}
