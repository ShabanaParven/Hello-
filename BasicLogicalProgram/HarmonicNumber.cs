using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgram
{
    class HarmonicNumber
    {
        public void harmonic()
        {
            Console.WriteLine("enter the number");
            double num = int.Parse(Console.ReadLine());
            double harmonicNum = 0;

            for (double i = 1; i <= num; i++)
            {
                harmonicNum += (1 / i);
                Console.WriteLine("1/" + i + "=" + (1 / i));
            }
            Console.WriteLine("The " + num + " harmonic number is=" + harmonicNum);
    
        }
   
    }
}
