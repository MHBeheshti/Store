using _03_DAL.Entity.Common;
//using _03_DAL.Entity.Main;
using _03_DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DAL.Entity.Hardware
{
    public class BaseHardware : Audit
    {
        public int Id { get; set; }
        public string HardwareName { get; set; }
        public Brand Brand { get; set; }
        public decimal Price { get; set; }
        public ICollection<HardwarePhoto> HardwarePhoto { get; set; }
        public ushort Rate { get; set; }
        public int Count { get; set; }
        public Off Off { get; set; }
        public PostStatus Status { get; set; }
    }
}
