using Newtonsoft.Json;
using System;

namespace InventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryManager inventoryDetails = new InventoryManager();

            DataModelClass dataModelClass = new DataModelClass();
            dataModelClass = inventoryDetails.Read("D:/Json/InventoryDetails.json");
            int totalInventoryPriceForRice = 0;
            int totalInventoryPriceForWheat = 0;
            int totalInventoryPriceForPulse = 0;

            for (int i = 0; i < dataModelClass.RiceList.Count; i++)
            {
                Console.WriteLine(dataModelClass.RiceList[i].name);
                Console.WriteLine(dataModelClass.RiceList[i].kg);
                Console.WriteLine(dataModelClass.RiceList[i].price);
                totalInventoryPriceForRice += dataModelClass.RiceList[i].kg * dataModelClass.RiceList[i].price;
            }
            Console.WriteLine("Total Price of Rice per Kg is: " + totalInventoryPriceForRice);

            Console.WriteLine("============Wheat============");
            for (int i = 0; i < dataModelClass.WheatList.Count; i++)
            {
                Console.WriteLine(dataModelClass.WheatList[i].name);
                Console.WriteLine(dataModelClass.WheatList[i].kg);
                Console.WriteLine(dataModelClass.WheatList[i].price);
                totalInventoryPriceForWheat += dataModelClass.WheatList[i].kg * dataModelClass.WheatList[i].price;
            }
            Console.WriteLine("Total Price of Wheat per Kg is: " + totalInventoryPriceForWheat);

            Console.WriteLine("============Pulses============");
            for (int i = 0; i < dataModelClass.PulseList.Count; i++)
            {
                Console.WriteLine(dataModelClass.PulseList[i].name);
                Console.WriteLine(dataModelClass.PulseList[i].kg);
                Console.WriteLine(dataModelClass.PulseList[i].price);
                totalInventoryPriceForPulse += dataModelClass.PulseList[i].kg * dataModelClass.PulseList[i].price;
            }
            Console.WriteLine("Total Price of Pulses per Kg is: " + totalInventoryPriceForPulse);
        }
    }
}
