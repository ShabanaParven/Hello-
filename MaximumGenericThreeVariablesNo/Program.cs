using System;

namespace MaximumGenericThreeVariablesMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {  54, 89, 45 };
            GenericMaximum<int> generic = new GenericMaximum<int>(arr);
            generic.PrintMaxValue();
            Console.ReadKey();
        }
    }
}