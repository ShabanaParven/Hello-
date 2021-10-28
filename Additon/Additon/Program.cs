using System;

namespace Additon
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Add ojcAdd = new Add();
            Console.WriteLine("total value="+ ojcAdd.isSum(40,30));
            Console.ReadKey();
        }
    }
}
