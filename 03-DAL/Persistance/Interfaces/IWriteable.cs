using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;

namespace _03_DAL.Persistance.Interfaces
{
    public interface IWriteable <T>
    {
        void Write (T value);
        void WriteJson(string Json);
    }
}
