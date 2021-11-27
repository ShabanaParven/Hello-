using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCodes
{
    public class CsvHandler
    {
        public static void Implement()
        {
            string importPath = @"C:\Users\pc\source\repos\Fellowship Program\Hello-\IndianStatesCodes\IndianStatesCodes\StateCodeInfo.csv";
            string exportPath = @"C:\Users\pc\source\repos\Fellowship Program\Hello-\IndianStatesCodes\IndianStatesCodes\StateCodeInfoFromCsv.json";
            //reading from csv
            using (var reader = new StreamReader(importPath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Rread data successfully from address.csv");
                foreach (AddressData addressData in records)
                {
                    Console.Write(" " + addressData.SerialNo);
                    Console.Write(" " + addressData.State);
                    Console.Write(" " + addressData.Code);

                    Console.Write("\n");
                }
                Console.WriteLine("\n **Now reading from csv file and write to csv file**");
                //writing to csv
                //using (var writer = new StreamWriter(exportPath))
                //    using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                //{
                //    csvExport.WriteRecords(records);
                //}

                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(exportPath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, records);
                }
            }
        }
    }
}
