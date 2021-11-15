using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = "D:/B1.Json/Inventory.json";
            Console.WriteLine("welcom to the inventort data management");

            ReadingInventoryData readingInventoryData = new ReadingInventoryData();
            InventoryManagementModel data = readingInventoryData.Read(Path);

            Console.WriteLine("Rice Details");
            for (int i = 0; i < data.Rice.Count; i++)
            {
                Console.WriteLine("Rice Details");
                Console.WriteLine("Name: " + data.Rice[i].name + "Weight: " + data.Rice[i].Weight + "price: " + data.Rice[i].Price);
                Console.WriteLine("-------------------------");
            }
            Console.WriteLine("Pulses Details");
            for (int i = 0; i < data.Pulses.Count; i++)
            {
                
                Console.WriteLine("Name: " + data.Pulses[i].name + "Weight: " + data.Pulses[i].Weight + "price: " + data.Pulses[i].Price); ;
                Console.WriteLine("-------------------------");
            }
            Console.WriteLine("Wheat Details");
            for (int i = 0; i < data.Wheat.Count; i++)
            {
               
                Console.WriteLine("Name: " + data.Wheat[i].name + "Weight: " + data.Wheat[i].Weight + "price: " + data.Wheat[i].Price);
                Console.WriteLine("-------------------------");
            }
            Console.ReadKey();
        }
    }
}
