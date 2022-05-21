using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DAL.Entity.Hardware
{
    public class Motherboard
    {
        public string Type { get; set; }
        public string RaidSupport { get; set; }
        public string SlotCount { get; set; }
        public string PciCount { get; set; }
    }
}
