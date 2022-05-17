using _03_DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BLL.Dto.Cpu
{
    //For Read
    public class CpuDto
    {
        public int Id { get; set; }
        public string HardwareName { get; set; }
        public decimal Price { get; set; }
        public ushort Rate { get; set; }
        public int Count { get; set; }
        public int CoreNumber { get; set; }
        public MemoryType MemoryType { get; set; }
        public string Series { get; set; }
    }
}
