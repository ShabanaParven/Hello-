using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Div ojcDiv = new Div();
            Console.WriteLine("total values="+ ojcDiv.isDivision(10, 5));
            Console.ReadKey();
        }
    }
}
