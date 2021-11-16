using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substraction
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Sub ojcSub = new Sub();
            Console.WriteLine("total values=" + ojcSub.isdif(50, 10));
            Console.ReadKey();
        }
    }
}
