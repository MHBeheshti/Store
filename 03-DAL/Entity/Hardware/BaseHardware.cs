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
    public class BaseHardware : Audit
    {
        public Brand Brand { get; set; }
        public decimal Price { get; set; }
        public bool IsExist { get; set; }
        public short Rate { get; set; }
        public string[] Photos { get; set; }
        public PostStatus Status { get; set; }
    }
}
