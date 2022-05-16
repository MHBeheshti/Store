using _03_DAL.Entity.Identity;
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
        public User CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public User ModifiedBy { get; set; }
        public DateTime Modify { get; set; }
    }
}
