using _02_BLL.Dto.Motherboard;
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
    public class MotherboardRepository : IMotherboardRepository
    {
        private readonly IContext<Motherboard> _context;
        MotherboardDto IMotherboardRepository.Create(CreateMotherboardDto MotherboardDto)
        {
            Motherboard motherboard = new Motherboard()
            {
                Id = IdGenerator.Generate(),
                HardwareName = MotherboardDto.HardwareName,
                Brand = MotherboardDto.Brand,
                Price = MotherboardDto.Price,
                SlotCount = MotherboardDto.SlotCount,
                PciCount = MotherboardDto.PciCount,
                Type = MotherboardDto.Type,
                Rate = MotherboardDto.Rate,
                RaidSupport = MotherboardDto.RaidSupport,
                Created = DateTime.UtcNow,
                Modify = DateTime.UtcNow
            };
            _context.Create(motherboard);
            _context.SaveChange();


            MotherboardDto motherboarddto = new MotherboardDto();
            return motherboarddto;
        }

        public bool Delete(int Id)
        {
            var res = _context.GetAll().ToList().Find(x => x.Id == Id);
            _context.Delete(res);
            _context.SaveChange();

            return true;
        }

        public List<Motherboard> GetAll()
        {
            return _context.GetAll().ToList();
        }

        MotherboardDto IMotherboardRepository.Update(CreateMotherboardDto Motherboard)
        {
            throw new NotImplementedException();
        }
    }
}
