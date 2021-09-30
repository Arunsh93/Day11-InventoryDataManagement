using Newtonsoft.Json;
using System;

namespace InventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalInventoryPriceForWheat = 0;
            int totalInventoryPriceForRice = 0;
            int totalInventoryPriceForPulses = 0;
            InventoryManager inventoryDetails = new InventoryManager();

            DataModelClass dataModelClass = new DataModelClass();
            dataModelClass = inventoryDetails.Read("D:/Json/InventoryDetails.json");

            foreach (var item in dataModelClass.RiceList)
            {

                Console.WriteLine($"Name : {item.name}\nWeight : {item.kg}\nPrice per Kg: {item.price}");
                int totalPriceForRice = item.kg * item.price;
                Console.WriteLine($"Total value of {item.name} = " + totalPriceForRice);

                totalInventoryPriceForRice += totalPriceForRice;
            }
            Console.WriteLine("Total Bill For Rice is: " + totalInventoryPriceForRice);
            

            Console.WriteLine("============Wheat============");
            foreach (var item in dataModelClass.WheatList)
            {
                Console.WriteLine($"Name : {item.name}\nWeight : {item.kg}\nPrice per Kg: {item.price}");
                int totalPriceForWheat = item.kg * item.price;
                Console.WriteLine($"Total value of {item.name} = " + totalPriceForWheat);

                totalInventoryPriceForWheat += totalPriceForWheat;
            }
            Console.WriteLine("Total Bill For Wheat is: " + totalInventoryPriceForWheat);

            Console.WriteLine("============Pulses============");
            foreach (var item in dataModelClass.PulseList)
            { 
                Console.WriteLine($"Name : {item.name}\nWeight : {item.kg}\nPrice per Kg: {item.price}");
                int totalPriceForPulse = item.kg * item.price;
                Console.WriteLine($"Total value of {item.name} = " + totalPriceForPulse);

                totalInventoryPriceForPulses += totalPriceForPulse;
            }
            Console.WriteLine("Total Bill For Wheat is: " + totalInventoryPriceForPulses);
        }
    }
}
