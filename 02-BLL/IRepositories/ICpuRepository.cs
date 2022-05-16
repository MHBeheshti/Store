using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_DAL.Entity.Hardware;

namespace _02_BLL.IRepositories
{
    public interface ICpuRepository
    {
        Cpu Create { get; set; }
        Cpu Update { get; set; }
        bool Delete { get; set; }
    }
}
