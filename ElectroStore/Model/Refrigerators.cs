using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectroStore.Model
{
    public class Refrigerators : KitchenAppliances
    {
        public string Volume { get; set; }

        public string SpecialCompartiments { get; set; }

        public int NoOfShelves { get; set; }
    }
}
