using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_BLL.Dto.Cpu;
using _03_DAL.Entity.Hardware;

namespace _02_BLL.IRepositories
{
    public interface ICpuRepository
    {
        List<Cpu> GetAll();
        List<Cpu> GetByCore(int corenumber);
        CpuDto Create(CreateCpuDto Cpu);
        CpuDto Update(CreateCpuDto Cpu); 
        bool Delete(int Cpu);
    }
}
