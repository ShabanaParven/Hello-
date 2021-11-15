using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataManagement
{
    public class ReadingInventoryData
    {
        public InventoryManagementModel Read(string Path)
        {
            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<InventoryManagementModel>(json);
                }
                catch(Exception e)
                {
                    Console.WriteLine("problem in getting data {0}, e");
                    return null;
                }
            }
        }
    }
}
