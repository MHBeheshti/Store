using _03_DAL.Persistance.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
            Context = new List<T>();
            _rootpath = Path.Combine(RootPath, "Entity");
            if (!Directory.Exists(_rootpath))
                Directory.CreateDirectory(_rootpath);
            }

        void IContext<T>.SaveChange()
        {
            var classname = typeof(T).Name + ".json"; // Cpu.json
            //"./Entity/Cpu.json"
            string storagePath = Path.Combine(_rootpath, classname);
            
            
            if (!File.Exists(storagePath))
            {
                var jsonResult = JsonConvert.SerializeObject(Context, Formatting.Indented);
                File.WriteAllText(storagePath, jsonResult);
            }
            else
            {
                string content = File.ReadAllText(storagePath);
                if (!string.IsNullOrEmpty(content))
                {
                    var res = JsonConvert.DeserializeObject<List<T>>(content);
                    res.AddRange(Context);
                    var jsonResult = JsonConvert.SerializeObject(Context, Formatting.Indented);
                    File.WriteAllText(storagePath, jsonResult);
                }else
                {
                    var jsonResult = JsonConvert.SerializeObject(Context, Formatting.Indented);
                    File.WriteAllText(storagePath, jsonResult);
                }

                //FileStream fsOut = File.OpenWrite(storagePath);
                //fsOut.Write(Encoding.UTF8.GetBytes("," + jsonResult), (int)fsOut.Length - 2, ("," + jsonResult).Length);
                //fsOut.Close();
            }   
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

        public ICollection<T> GetAll()
        {
            var classname = typeof(T).Name + ".json"; // Cpu.json
            //"./Entity/Cpu.json"
            string storagePath = Path.Combine(_rootpath, classname);

            string content = File.ReadAllText(storagePath);

            if (!string.IsNullOrEmpty(content))
            {
                var res = JsonConvert.DeserializeObject<ICollection<T>>(content);
                return res;
            }
            return null;
        }

        T IContext<T>.Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
