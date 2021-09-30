using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InventoryManagement
{
    class InventoryManager
    {
        public DataModelClass Read(string path)
        {
            try
            {
                using (StreamReader file = new StreamReader(path))
                {

                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<DataModelClass>(json);

                };
            }
            catch (Exception e)
            {
                Console.WriteLine("Problem Reading File {0}", e);
                return null;
            }
        }
    }
}
