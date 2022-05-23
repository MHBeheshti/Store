using _02_BLL.Dto.GraphicsCard;
using _02_BLL.IRepositories;
using _03_DAL.Entity.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BLL.Repositories
{
    public class GraphicsCardRepository : IGraphicsCardRepository
    {
        GraphicsCardDto IGraphicsCardRepository.Create(CreateGraphicsCardDto GraphicsCard)
        {
            throw new NotImplementedException();
        }

        bool IGraphicsCardRepository.Delete(int Id)
        {
            throw new NotImplementedException();
        }

        List<GraphicsCard> IGraphicsCardRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        GraphicsCardDto IGraphicsCardRepository.Update(CreateGraphicsCardDto GraphicsCard)
        {
            throw new NotImplementedException();
        }
    }
}
