using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<SKU> ListsKUs = new SKULists().GetSkuList();

            List<Promoption> Listpromoptions = new PromoptionList().GetPromptionsList();

            Console.WriteLine("------------------------------ScenarioA Start-------------------------------------------");
            Dictionary<string, List<string>> _scenarioA = ScenarioA(Listpromoptions, ListsKUs);
            foreach (var v in _scenarioA)
            {
                Console.WriteLine("UnitName:" + v.Key);
                 
                foreach (var action in v.Value)
                {
                    Console.WriteLine("UnitPrice:" + action);

                }
            }
            Console.WriteLine("------------------------------ScenarioA End-------------------------------------------");
            Console.WriteLine("------------------------------ScenarioB Start-------------------------------------------");
            Dictionary<string, List<int>> _scenariob = ScenarioB(Listpromoptions, ListsKUs);
            int offer = 0;
            int actual = 0;

            foreach (var v1 in _scenariob)
            {
                 if(v1.Key== "Offer1:")
                {
                    offer = offer + Convert.ToInt32(v1.Value[0]);
                }
                if (v1.Key == "Offer2:")
                {
                    offer = offer + Convert.ToInt32(v1.Value[0]);
                }
                if (v1.Key == "ActualPrice3")
                {
                    offer = offer + Convert.ToInt32(v1.Value[0]);
                }
                if (v1.Key == "ActualPrice1")
                {
                    actual = actual + Convert.ToInt32(v1.Value[0]);
                }
                if (v1.Key == "ActualPrice2")
                {
                    actual = actual + Convert.ToInt32(v1.Value[0]);
                }
                if (v1.Key == "ActualPrice3")
                {
                    actual = actual + Convert.ToInt32(v1.Value[0]);
                }
            }
            Console.WriteLine("Offer price:"+offer);
            Console.WriteLine("order Total:" + actual);
            Console.WriteLine("------------------------------ScenarioB End-------------------------------------------");
           // Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
        static Dictionary<string, List<string>> ScenarioA(List<Promoption> Listpromoptions, List<SKU> ListsKUs)
        {
            Dictionary<string, List<string>> innerDictionary = new Dictionary<string, List<string>>();
            foreach (var a in ListsKUs)
            {
                innerDictionary.Add(a.UnitName, new List<string>() { Convert.ToDecimal(a.UnitPrice).ToString() });
            }
            return innerDictionary;
        }
        static Dictionary<string, List<int>> ScenarioB(List<Promoption> Listpromoptions, List<SKU> ListsKUs)
        {
            Dictionary<string, List<int>> innerDictionary = new Dictionary<string, List<int>>();

            foreach (var v in Listpromoptions)
            {
                if (v.UnitName == "A")
                {
                    if(v.UnitCount>=3)
                    {
                        innerDictionary.Add("Offer1:", new List<int>() {   v.Discount + getA(ListsKUs,v.UnitName) });

                        innerDictionary.Add("ActualPrice1", new List<int>() { getA1(ListsKUs, v.UnitName) });
                    }
                    //innerDictionary.Add(v.UnitName, new List<string>() { "OfferPrice:" + Convert.ToDecimal(v.Discount).ToString(), "ActualPrice:" + 2 * ListsKUs.Select(m => m.UnitPrice).FirstOrDefault() });
                }
                if (v.UnitName == "B")
                {
                    innerDictionary.Add("Offer2:", new List<int>() { v.Discount +v.Discount + getB(ListsKUs,v.UnitName)});

                    innerDictionary.Add("ActualPrice2", new List<int>() { getA1(ListsKUs, v.UnitName) });
                }
                if (v.UnitName == "C")
                {
                    innerDictionary.Add("ActualPrice3", new List<int>() { getB(ListsKUs, v.UnitName) });
                }
            }

            return innerDictionary;
        }
        static int getA(List<SKU> ListsKUs,string unitName)
        {
            foreach(var v in ListsKUs)
            {
                if(unitName==v.UnitName)
                {
                    return Convert.ToInt32(v.UnitPrice + v.UnitPrice);
                }
            }
            return 0;
        }
        static int getA1(List<SKU> ListsKUs, string unitName)
        {
            foreach (var v in ListsKUs)
            {
                if (unitName == v.UnitName)
                {
                    return Convert.ToInt32(v.UnitPrice *5);
                }
            }
            return 0;
        }
        static int getB(List<SKU> ListsKUs, string unitName)
        {
            foreach (var v in ListsKUs)
            {
                if (unitName == v.UnitName)
                {
                    return Convert.ToInt32(v.UnitPrice);
                }
            }
            return 0;
        }
    }
}
