using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DAL.Persistance.Interfaces
{
    public interface IContex<T> where T : class
    {
        T Create(T entity);
        ICollection<T> GetAll();
        T Update(T entity);
        T Delete(T entity);

    }
}
