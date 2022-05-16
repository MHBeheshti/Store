using _03_DAL.Persistance.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DAL.Persistance
{
    public class FileContext<T> : IContex<T> where T : class
    {
        private readonly string _rootpath { get; set; }
        public FileContext(string RootPath)
            {
                _rootpath = Rootpath;
            }
        T IContex<T>.Create(T entity)
        {
            var classname = entity.GetType().Name;
            return null;
        }

        T IContex<T>.Delete(T entity)
        {
            throw new NotImplementedException();
        }

        ICollection<T> IContex<T>.GetAll()
        {
            throw new NotImplementedException();
        }

        T IContex<T>.Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
