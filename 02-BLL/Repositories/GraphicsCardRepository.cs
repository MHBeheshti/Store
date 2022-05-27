using _02_BLL.Dto.GraphicsCard;
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
    public class GraphicsCardRepository : IGraphicsCardRepository
    {
        private readonly IContext<GraphicsCard> _context;
        public GraphicsCardRepository(IContext<GraphicsCard> context)
        {
            _context = context;
        }
        GraphicsCardDto IGraphicsCardRepository.Create(CreateGraphicsCardDto GraphicsCardDto)
        {
            GraphicsCard graphicscard = new GraphicsCard()
            {
                Id = IdGenerator.Generate(),
                HardwareName = GraphicsCardDto.HardwareName,
                Brand = GraphicsCardDto.Brand,
                Price = GraphicsCardDto.Price,
                Rate = GraphicsCardDto.Rate,
                HtmiPorts = GraphicsCardDto.HtmiPorts,
                MemoryType = GraphicsCardDto.MemoryType,
                Created = DateTime.UtcNow,
                Modify = DateTime.UtcNow
            };
            _context.Create(graphicscard);
            _context.SaveChange();


            GraphicsCardDto graphicscarddto = new GraphicsCardDto(); 
            return graphicscarddto;
        }

        public bool Delete(int Id)
        {
            var res = _context.GetAll().ToList().Find(x => x.Id == Id);
            _context.Delete(res);
            _context.SaveChange();

            return true; 
        }

        public List<GraphicsCard> GetAll()
        {
            return _context.GetAll().ToList(); 
        }

        GraphicsCardDto IGraphicsCardRepository.Update(CreateGraphicsCardDto GraphicsCard)
        {
            throw new NotImplementedException();
        }
    }
}
