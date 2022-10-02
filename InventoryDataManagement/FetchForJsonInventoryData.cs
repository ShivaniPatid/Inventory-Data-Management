using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace InventoryDataManagement
{
    internal class FetchForJsonInventoryData
    {
        public Inventory Read(string path)
        {
            using(StreamReader file=new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Inventory>(json);

                }
                catch(Exception)
                {
                    return null;
                }
            }
        }
    }
}
