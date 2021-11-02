using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgram
{
    public class LargestOfThreeNumbers
    {
        public void largest()
        {
            int n1, n2, n3, largest;
            Console.WriteLine("Enter the first number");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2 && n1 >n3)
            {
                Console.WriteLine("largest = n1");
            }
            else if  (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("largest = n2");
            }
            else
            {
                Console.WriteLine("largest = n3");
            }

        }
    }
}
