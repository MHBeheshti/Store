using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DAL.Services
{
    public static class IdGenerator
    {
        private static string path = "./IdGenerator.txt";
        private static int Id = 0;
        public static int Generate()
        {
            if (Id != 0)
            {
                File.WriteAllText(path,Id++.ToString());

            }else
            {
                if (!File.Exists(path))
                {
                    File.WriteAllText(path, (++Id).ToString());
                }
                else
                {
                    Id = Convert.ToInt32(File.ReadAllText(path));
                    File.WriteAllText(path, (++Id).ToString());
                }
            }

            return Id;
        }
    }
}
