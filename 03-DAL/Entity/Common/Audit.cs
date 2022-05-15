using _03_DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DAL.Entity.Common
{
    public class Audit
    {
        public string CreatedBy { get; set; }
        public DateTime Registered { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime LastModified { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
