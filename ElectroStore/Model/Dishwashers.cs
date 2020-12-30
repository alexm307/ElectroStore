using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectroStore.Model
{
    public class Dishwashers : ElectronicProducts
    {
        public int NoOfPrograms { get; set; }

        public int StepsOfTemperature { get; set; }

        public string LoadingCapacity { get; set; }
    }
}
