using Newtonsoft.Json;
using System;

namespace InventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================Rice============================");
            FetchJsonForRice fetchJsonForRice = new FetchJsonForRice();
            fetchJsonForRice.Read("D:/Json/Rice.json");
            string outputRice = JsonConvert.SerializeObject(fetchJsonForRice);

            Console.WriteLine("==========================Wheat===========================");
            FetchJsonForWheat fetchJsonForWheat = new FetchJsonForWheat();
            fetchJsonForWheat.Read("D:/Json/Wheat.json");
            string outputWheat = JsonConvert.SerializeObject(fetchJsonForWheat);

            Console.WriteLine("==========================Pulses==========================");
            FetchJsonForPulses fetchJsonForPulses = new FetchJsonForPulses();
            fetchJsonForPulses.Read("D:/Json/Pulses.json");
            string outputPulses = JsonConvert.SerializeObject(fetchJsonForPulses);
        }
    }
}
