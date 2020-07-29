using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class SKU
    {
        public string UnitName { get; set; }
        public float UnitPrice { get; set; } 
    }
    public class SKULists
    {
        //public List<SKU> sKUs = new List<SKU>();

        public List<SKU> GetSkuList()
        {
            List<SKU> sKUs = new List<SKU>();
            sKUs.Add(new SKU { UnitName = "A", UnitPrice = 50f });
            sKUs.Add(new SKU { UnitName = "B", UnitPrice = 30f });
            sKUs.Add(new SKU { UnitName = "C", UnitPrice = 20f });
            sKUs.Add(new SKU { UnitName = "D", UnitPrice = 15f });
            return sKUs;
        }
    }
}
