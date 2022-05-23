using _03_DAL.Entity.Hardware;
using _03_DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BLL.Dto.Ram
{
    public class CreateRamDto
    {
        public int Id { get; set; }
        public string HardwareName { get; set; }
        public Brand Brand { get; set; }
        public decimal Price { get; set; }
        public ushort Rate { get; set; }
        public string Series { get; set; }
        public int ModuleCount { get; set; }
        public MemoryType MemoryType { get; set; }
        public int Size { get; set; }
    }
}
