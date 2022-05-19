using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DAL.Persistance.Interfaces
{
    public interface IContext<T> where T : class
    {
        void SaveChange();
        T Create(T entity);
        ICollection<T> GetAll();
        T Update(T entity);
        T Delete(T entity);
    }
}