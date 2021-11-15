using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataManagement
{
   public class InventoryManagementModel
    {
        public List<Rice> Rice;
        public List<Pulses> Pulses;
        public List<Wheat> Wheat;
    }

    public class Rice
    {
        public string name;
        public string Weight;
        public int Price;
    }

    public class Pulses
    {
        public string name;
        public string Weight;
        public int Price;
    }
    public class Wheat
    {
        public string name;
        public string Weight;
        public int Price;
    }
}
