using _03_DAL.Persistance.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DAL.Persistance
{
    public class FileContext<T> : IContext<T> where T : class
    {
        private string _rootpath { get; set; }
        private ICollection<T> Context;
        public FileContext(string RootPath)
            {
            _rootpath = RootPath;
            Context = new List<T>();
            }

        void SaveChange()
        {
            var classname = typeof(T).Name;
        }

        T IContext<T>.Create(T entity)
        {
            var classname = entity.GetType().Name;
            Context.Add(entity);
            return null;
        }

        T IContext<T>.Delete(T entity)
        {
            throw new NotImplementedException();
        }

        ICollection<T> IContext<T>.GetAll()
        {
            throw new NotImplementedException();
        }

        T IContext<T>.Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
