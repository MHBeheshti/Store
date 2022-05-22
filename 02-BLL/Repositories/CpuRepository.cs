using _02_BLL.Dto.Cpu;
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
    public class CpuRepository : ICpuRepository
    {
        private readonly IContext<Cpu> _context;
        public CpuRepository(IContext<Cpu> context)
        {
            _context = context;
        }
        CpuDto ICpuRepository.Create(CreateCpuDto CpuDto)
        {
            Cpu cpu = new Cpu()
            {
                Series = CpuDto.Series,
                CoreNumber = CpuDto.CoreNumber,
                Rate = CpuDto.Rate,
                HardwareName = CpuDto.HardwareName,
                Id = IdGenerator.Generate(),
                Brand = CpuDto.Brand,
                //Count = CpuDto.Count,
                Price = CpuDto.Price,
                MemoryType = CpuDto.MemoryType,
                Created = DateTime.UtcNow,
                Modify = DateTime.UtcNow
            };


            CpuDto cpudto = new CpuDto()
            {
                // 
            };
            _context.Create(cpu);
            _context.Delete(cpu);
            _context.SaveChange();

            return cpudto;
        }

        public bool Delete(int Id)
        {
            var res = _context.GetAll().ToList().Find(x => x.Id == Id);
            _context.Delete(res);
            _context.SaveChange();

            return true;
        }

        public List<Cpu> GetAll()
        {
            return _context.GetAll().ToList();
        }

        public List<Cpu> GetByCore(int corenumber)
        {
            var res = _context.GetAll().ToList().FindAll(x => x.CoreNumber == corenumber);
            return res;
        }

        CpuDto ICpuRepository.Update(CreateCpuDto Cpu)
        {
            throw new NotImplementedException();
        }
    }
}
