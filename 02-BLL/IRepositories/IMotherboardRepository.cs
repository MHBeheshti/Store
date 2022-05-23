using _02_BLL.Dto.Motherboard;
using _03_DAL.Entity.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BLL.IRepositories
{
    public interface IMotherboardRepository
    {
        List<Motherboard> GetAll();
        MotherboardDto Create( CreateMotherboardDto Motherboard);
        MotherboardDto Update(CreateMotherboardDto Motherboard);
        bool Delete(int Id);
    }
}
