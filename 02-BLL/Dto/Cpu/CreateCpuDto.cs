using _03_DAL.Entity.Hardware;
using _03_DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BLL.Dto.Cpu
{
    public class CreateCpuDto
    {
        public int Id { get; set; }
        public string HardwareName { get; set; }
        public Brand Brand { get; set; }
        public decimal Price { get; set; }
        public ushort Rate { get; set; }
        public int CoreNumber { get; set; }
        public MemoryType MemoryType { get; set; }
        public string Series { get; set; }
    }
}
