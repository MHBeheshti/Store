using _03_DAL.Entity.Common;
using _03_DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DAL.Entity.Hardware
{
    public class Ram : BaseHardware
    {
        //public int Id { get; set; }
        public int ModuleCount { get; set; }
        public MemoryType MemoryType { get; set; }
        public int Size { get; set; }
    }
}
