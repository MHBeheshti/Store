using _02_BLL.Dto.Ram;
using _02_BLL.IRepositories;
using _03_DAL.Entity.Hardware;
using _03_DAL.Persistance.Interfaces;
using _03_DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BLL.Repositories
{
    public class RamRepository : IRamRepository
    {
        private readonly IContext<Ram> _context;
        RamDto IRamRepository.Create(CreateRamDto RamDto)
        {
            Ram ram = new Ram()
            {
                Id = IdGenerator.Generate(),
                HardwareName = RamDto.HardwareName,
                Brand = RamDto.Brand,
                Price = RamDto.Price,
                Rate = RamDto.Rate,
                MemoryType = RamDto.MemoryType,
                Created = DateTime.UtcNow,
                Modify = DateTime.UtcNow,
                ModuleCount = RamDto.ModuleCount,
                Size = RamDto.Size,
            };
            _context.Create(ram);
            _context.SaveChange();


            RamDto ramdto = new RamDto();
            return ramdto;

        }

        public bool Delete(int Id)
        {
            var res = _context.GetAll().ToList().Find(x => x.Id == Id);
            _context.Delete(res);
            _context.SaveChange();

            return true;
        }

        List<Ram> IRamRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        RamDto IRamRepository.Update(CreateRamDto Ram)
        {
            throw new NotImplementedException();
        }
    }
}
