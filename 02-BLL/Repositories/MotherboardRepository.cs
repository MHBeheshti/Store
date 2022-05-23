using _02_BLL.Dto.Motherboard;
using _02_BLL.IRepositories;
using _03_DAL.Entity.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BLL.Repositories
{
    public class MotherboardRepository : IMotherboardRepository
    {
        MotherboardDto IMotherboardRepository.Create(CreateMotherboardDto Motherboard)
        {
            throw new NotImplementedException();
        }

        bool IMotherboardRepository.Delete(int Id)
        {
            throw new NotImplementedException();
        }

        List<Motherboard> IMotherboardRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        MotherboardDto IMotherboardRepository.Update(CreateMotherboardDto Motherboard)
        {
            throw new NotImplementedException();
        }
    }
}
