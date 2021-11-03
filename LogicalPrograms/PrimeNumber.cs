using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public void printPrimeNumber()
        {
            int num;
            bool isPrime = true;

            Console.WriteLine("Enter a number");
            num = int.Parse(Console.ReadLine());
            
            for(int i=2; i<=num/2; i++)
            {
                if(num%i == 0)
                {
                    isPrime = false;
                    //Console.WriteLine("its not a prime number");
                    break;
                }
                
            }
            if (isPrime)
            {
                Console.WriteLine("Number is prime");
            }
            else
            {
                Console.WriteLine("Number is not prime");
            }
            //Console.ReadKey();
        }
    }
}
