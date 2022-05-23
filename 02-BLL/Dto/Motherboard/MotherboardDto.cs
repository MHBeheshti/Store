using _03_DAL.Entity.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BLL.Dto.Motherboard
{
    public class MotherboardDto
    {
        public int Id { get; set; }
        public string HardwareName { get; set; }
        public Brand Brand { get; set; }
        public decimal Price { get; set; }
        public ushort Rate { get; set; }
        public int Count { get; set; }
        public string Series { get; set; }
        public string Type { get; set; }
        public string RaidSupport { get; set; }
        public string SlotCount { get; set; }
        public string PciCount { get; set; }
    }
}
