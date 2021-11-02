using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgram
{
    public class SwapTwoNumbers
    {
        public void swaping()
        {
            int num1;
            int num2;
            int temp;

            Console.WriteLine("enter the num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the num2");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping num1 = {0} and num2 = {1}", num1, num2);

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After swapping num1 = {0} and num2 = {1}", num1, num2);


        }
    }
}
