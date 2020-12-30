using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectroStore.Model
{
    public class Phones : ElectronicProducts
    {
        public int PhoneID { get; set; }  //aici poate vine id oiginal

        public string PhoneCPU { get; set; }

        public double Baterry_mAh { get; set; }

        public string Display { get; set; }

        public int Storage_GB { get; set; }

        public double Size_inches { get; set; }
    }
}
