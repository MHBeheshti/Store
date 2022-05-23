using _02_BLL.Dto.GraphicsCard;
using _03_DAL.Entity.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BLL.IRepositories
{
    public interface IGraphicsCardRepository
    {
        List<GraphicsCard> GetAll();
        GraphicsCardDto Create(CreateGraphicsCardDto GraphicsCard);
        GraphicsCardDto Update(CreateGraphicsCardDto GraphicsCard);
        bool Delete(int Id);
    }
}
