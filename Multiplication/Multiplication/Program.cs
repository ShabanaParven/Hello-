using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Multiply ojcMultiply = new Multiply();
            Console.WriteLine("total values=" + ojcMultiply.isMul(4,2));
            Console.ReadKey();
        }
    }
}
