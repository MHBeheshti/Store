using _03_DAL.Entity.Common;
using _03_DAL.Entity.Main;
using _03_DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DAL.Entity.Hardware
{
    public class Cpu : BaseHardware
    {
        public int CoreNumber { get; set; }
        public MemoryType MemoryType { get; set; }
        public string Series { get; set; }
    }
}
