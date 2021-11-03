using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        public void fibonacci()
        {
            int number, t1 = 0, t2 = 1, nextterm;
            Console.WriteLine("enter the number of terms");
            number = Convert.ToInt32(Console.ReadLine());

            for( int counter = 1; counter <= number; counter++)
            {
                Console.WriteLine("{0} ", t1);
                nextterm = t1 + t2;
                t1 = t2;
                t2 = nextterm;
            }
        }

        
    }
}
