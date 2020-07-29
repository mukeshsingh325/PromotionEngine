using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Promoption
    {
        public string UnitName { get; set; }
        public int Discount { get; set; }

        public int UnitCount { get; set; } 
    }
    public class PromoptionList
    {
        //public List<Promoption> sKUs = new List<Promoption>();
        public List<Promoption> GetPromptionsList()
        {
            List<Promoption> sKUs = new List<Promoption>();
            sKUs.Add(new Promoption { UnitName = "A", Discount = 130, UnitCount = 3 });
            sKUs.Add(new Promoption { UnitName = "B", Discount = 45, UnitCount = 2 });
            sKUs.Add(new Promoption { UnitName = "C", Discount = 15, UnitCount = 1 });
            sKUs.Add(new Promoption { UnitName = "D", Discount = 15, UnitCount = 1 });
            return sKUs;
        }
    }
}
