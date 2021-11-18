using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(56);
            list.Add(30);
            list.Add(70);

            foreach(int item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
