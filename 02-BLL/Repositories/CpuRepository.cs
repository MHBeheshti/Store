using _02_BLL.Dto.Cpu;
using _02_BLL.IRepositories;
using _03_DAL.Entity.Hardware;
using _03_DAL.Persistance.Interfaces;
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
                Id = CpuDto.Id,
                Count = CpuDto.Count,
                Price = CpuDto.Price,
                MemoryType = CpuDto.MemoryType,
                Created = DateTime.UtcNow,
                Modify = DateTime.UtcNow
            };
            var res = _context.Create(cpu);
            _context.SaveChange();

            CpuDto cpudto = new CpuDto();
            /*
             * mapping 
            */

            return cpudto;
        }

        bool ICpuRepository.Delete(int Cpu)
        {
            throw new NotImplementedException();
        }

        List<CpuDto> ICpuRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        List<CpuDto> ICpuRepository.GetByCore(int corenumber)
        {
            throw new NotImplementedException();
        }

        CpuDto ICpuRepository.Update(CreateCpuDto Cpu)
        {
            throw new NotImplementedException();
        }
    }
}
