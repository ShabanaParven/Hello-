using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Label: Console.WriteLine("1.print the percentage coin flip \n 2.given number is even or not \n 3.Leap year \n 4.Swapping of two numbers \n 5.Largest of three numbers \n 6.Given alphabet is vowel or consonent \n 7.Prime factor \n 8.Quotient and Remainder \n 9.Harmonic number \n 10.power of two");
            Console.WriteLine("Type the option");
            int i = int.Parse(Console.ReadLine());

            switch(i)
            {
                case 1:
                    Console.WriteLine("1.print the percentage coin flip");
                    PercentageOfHeadAndTail percentageOfHeadAndTail = new PercentageOfHeadAndTail();
                    percentageOfHeadAndTail.printHaidAndTail();
                    break;

                case 2:
                    Console.WriteLine("2.Given number is even or odd");
                    GivenNumIsEvenOrOdd givenNumIsEvenOrOdd = new GivenNumIsEvenOrOdd();
                    givenNumIsEvenOrOdd.printEvenOrOdd();
                    break;

                case 3:
                    Console.WriteLine("3.Leap year");
                    LeapYear leapYear = new LeapYear();
                    leapYear.printLeapYearOrNot();
                    break;

                case 4:
                    Console.WriteLine("4.Swapping of two numbers");
                    SwapTwoNumbers swapTwoNumbers = new SwapTwoNumbers();
                    swapTwoNumbers.swaping();
                    break;

                case 5:
                    Console.WriteLine("5.Largest of three numbers");
                    LargestOfThreeNumbers largestOfThreeNumbers = new LargestOfThreeNumbers();
                    largestOfThreeNumbers.largest();
                    break;

                case 6:
                    Console.WriteLine("6.Given alphabet is vowel or consonant");
                    AlphabetIsVowelOrConsonant alphabetIsVowelOrConsonant = new AlphabetIsVowelOrConsonant();
                    alphabetIsVowelOrConsonant.vowelOrConsonant();
                    break;

                case 7:
                    Console.WriteLine("7.Prime Factor");
                    PrimeFactor primeFactor = new PrimeFactor();
                    primeFactor.primeFactor();
                    break;

                case 8:
                    Console.WriteLine("8.Quotient and Remainder");
                    QuotientAndRemainder quotientAndRemainder = new QuotientAndRemainder();
                    quotientAndRemainder.calculateQuotientAndRemainder();
                    break;

                case 9:
                    Console.WriteLine("9.Harmonic number");
                    HarmonicNumber harmonicNumber = new HarmonicNumber();
                    harmonicNumber.harmonic();
                    break;

                case 10:
                    Console.WriteLine("10. power of two");
                    PowerOf2 powerOf2 = new PowerOf2();
                    powerOf2.power();
                    break;

                
                default:
                    Console.WriteLine("invalid option");
                    break;

            }
            Console.WriteLine("Do yoy want to continue,, y/n");
            if (Console.ReadKey().KeyChar.ToString() == "y");
            {
                goto Label;
            }
           
            Console.ReadKey();
        }
    }
}
