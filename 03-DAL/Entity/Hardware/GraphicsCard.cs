using _03_DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DAL.Entity.Hardware
{
    public class GraphicsCard
    {
        public int HtmiPorts { get; set; }
        public MemoryType MemoryType { get; set; }
    }
}
