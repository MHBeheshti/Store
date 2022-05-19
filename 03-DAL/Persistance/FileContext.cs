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
        private readonly string _rootpath;
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

            //////////////get entity name
            var filename = typeof(T).Name + ".json"; // Cpu.json



            // "./Entity/Cpu.json"
            string storagePath = Path.Combine(_rootpath, filename);

            if (!File.Exists(storagePath)) // EntityName.json not exists
            {
                var jsonResult = JsonConvert.SerializeObject(Context, Formatting.Indented); // convert data to json 
                File.WriteAllText(storagePath, jsonResult); // save data 
            }
            else
            {
                string content = File.ReadAllText(storagePath); // read data

                if (!string.IsNullOrEmpty(content))
                {
                    // we have data

                    List<T> res = JsonConvert.DeserializeObject<List<T>>(content); // read alredy data
                    res.AddRange(Context); // add new data to alredy data
                    var jsonResult = JsonConvert.SerializeObject(res, Formatting.Indented); // convert all data to json 
                    File.WriteAllText(storagePath, jsonResult); // save all data again 
                }
                else
                {
                    // we have not data

                    var jsonResult = JsonConvert.SerializeObject(Context, Formatting.Indented); // convert data to json 
                    File.WriteAllText(storagePath, jsonResult); // save data 
                }
            }
            Context.Clear();
        }
        public T Create(T entity)
        {
            Context.Add(entity);
            return null;
        }
        public T Delete(T entity)
        {
            var classname = typeof(T).Name + ".json"; // Cpu.json
            // "./Entity/Cpu.json"
            string storagePath = Path.Combine(_rootpath, classname);

            if (File.Exists(storagePath))
            {
                string content = File.ReadAllText(storagePath);

                if (!string.IsNullOrEmpty(content))
                {
                    var res = JsonConvert.DeserializeObject<List<T>>(content);

                    res.Remove(entity);

                    var jsonResult = JsonConvert.SerializeObject(res, Formatting.Indented);
                    File.WriteAllText(storagePath, jsonResult);
                }
            }
            return null;
        }
        public ICollection<T> GetAll()
        {
            var classname = typeof(T).Name + ".json"; // Cpu.json
            // "./Entity/Cpu.json"
            string storagePath = Path.Combine(_rootpath, classname);

            string content = File.ReadAllText(storagePath);

            if (!string.IsNullOrEmpty(content))
            {
                var res = JsonConvert.DeserializeObject<ICollection<T>>(content);
                return res;
            }

            return null;
        }
        public T Update(T entity)
        {
            var classname = typeof(T).Name + ".json"; // Cpu.json
            // "./Entity/Cpu.json"
            string storagePath = Path.Combine(_rootpath, classname);

            if (File.Exists(storagePath))
            {
                string content = File.ReadAllText(storagePath);

                if (!string.IsNullOrEmpty(content))
                {
                    var res = JsonConvert.DeserializeObject<List<T>>(content);

                    // Update

                    var jsonResult = JsonConvert.SerializeObject(res, Formatting.Indented);
                    File.WriteAllText(storagePath, jsonResult);
                }
            }
            return null;
        }

    }
}
