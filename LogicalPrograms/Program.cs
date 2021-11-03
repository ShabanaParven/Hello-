using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Label: Console.WriteLine(" 1.Fibonacci series \n 2.Perfect number \n 3.Prime number \n 4.Reverse number");
            Console.WriteLine("Type the option");
            int i = int.Parse(Console.ReadLine());

            switch(i)
            {
                case 1:
                    Console.WriteLine("1.Fibonacci series");
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    fibonacciSeries.fibonacci();
                    break;

                case 2:
                    Console.WriteLine("2.Perfect number");
                    PerfectNumber perfectNumber = new PerfectNumber();
                    perfectNumber.printPerfectNumber();
                    break;

                case 3:
                    Console.WriteLine("3.Prime number");
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.printPrimeNumber();
                    break;

                case 4:
                    Console.WriteLine("4.reverse number");
                    ReverseNumber reverseNumber = new ReverseNumber();
                    reverseNumber.printReverseNumber();
                    break;

                default:
                    Console.WriteLine("invalid option");
                    break;
            }
            Console.WriteLine("Do you want to continue.....y/n");
            if (Console.ReadKey().KeyChar.ToString() == "y") ;
            {
                goto Label;
            }

            Console.ReadKey();
        }
    }
}
