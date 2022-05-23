using _02_BLL.Dto.Ram;
using _03_DAL.Entity.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BLL.IRepositories
{
    public interface IRamRepository
    {
        List<Ram> GetAll();
        RamDto Create(CreateRamDto Ram);
        RamDto Update( CreateRamDto Ram);
        bool Delete(int Id);
    }
}
