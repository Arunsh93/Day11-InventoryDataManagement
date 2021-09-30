using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InventoryManagement
{
    class FetchJsonForRice
    {
        public DataModelClass Read(string Path)
        {
            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    var searializerSettings = new JsonSerializerSettings
                    {
                        //ContractResolver = new CamelCasePropertyNamesContractResolver()
                    };
                    Console.WriteLine(json);
                    return JsonConvert.DeserializeObject<DataModelClass>(json, searializerSettings);
                }

                catch (Exception e)
                {
                    Console.WriteLine("Problem Reading File {0}", e);
                    return null;
                }
            }
        }
    }
}
