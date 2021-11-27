using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("read data from csv and write data to json");
            CsvHandler.Implement();

            Console.ReadKey();
        }
    }
}
