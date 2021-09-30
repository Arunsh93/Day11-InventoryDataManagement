using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement
{
    public class DataModelClass
    {
        public List<Rice> RiceList;
        public List<Wheat> WheatList;
        public List<Pulses> PulseList;
        public class Rice
        {
            public string name;
            public int price;
            public int kg;
        }

        public class Wheat
        {
            public string name;
            public int price;
            public int kg;
        }

        public class Pulses
        {
            public string name;
            public int price;
            public int kg;
        }
    }
}
