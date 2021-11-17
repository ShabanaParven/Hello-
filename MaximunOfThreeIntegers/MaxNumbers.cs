using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximunOfThreeIntegers
{
   public class MaxNumbers
    {
        public static void maxNumbers()
        {
            int num1 = 28;
            int num2 =73;
            int num3 = 40;

            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0 ||
               num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) > 0 ||
                num1.CompareTo(num2) > 0 && num1.CompareTo(num3) >= 0)
            {
                Console.WriteLine("num 1 is greater " + num1);
            }

            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0 ||
               num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) > 0 ||
                num2.CompareTo(num1) > 0 && num2.CompareTo(num3) >= 0)
            {
                Console.WriteLine("num 2 is greater " + num2);
            }

            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0 ||
               num3.CompareTo(num1) >= 0 && num3.CompareTo(num2) > 0 ||
                num3.CompareTo(num1) > 0 && num3.CompareTo(num2) >= 0)
            {
                Console.WriteLine("num 3 is greater " + num3);
            }
            Console.ReadKey();
        }
    }
}
