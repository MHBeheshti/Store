using _03_DAL.Persistance.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DAL.Persistance
{
    public class FileContext<T> : IReadable<T>, IWriteable<T>
    {
        T IReadable<T>.Find<IdType>(IdType Id)
        {
            throw new NotImplementedException();
        }

        ICollection<T> IReadable<T>.ReadAll()
        {
            throw new NotImplementedException();
        }

        void IWriteable<T>.Write(T value)
        {
            throw new NotImplementedException();
        }

        void IWriteable<T>.WriteJson(string Json)
        {
            throw new NotImplementedException();
        }
    }
}
