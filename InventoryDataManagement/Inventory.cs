using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataManagement
{
    public class Inventory
    {
        public List<TypeOfRice> typeOfRice;
        public List<TypeOfPulses> typeOfPulses;
        public List<TypeOfWheat> typeOfWheat;
    }

    public class TypeOfRice
    {
        public string name { get; set; }
        public int weight { get; set; }
        public int price { get; set; }

    }

    public class TypeOfPulses
    {
        public string name { get; set; }
        public int weight { get; set; }
        public int price { get; set; }

    }

    public class TypeOfWheat
    {
        public string name { get; set; }
        public int weight { get; set; }
        public int price { get; set; }

    }
}
