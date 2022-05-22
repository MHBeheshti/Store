using _02_BLL;
using _02_BLL.Dto.Cpu;
using _02_BLL.IRepositories;
using _02_BLL.Repositories;
using _03_DAL.Entity.Hardware;
using _03_DAL.Enums;
using _03_DAL.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Programs
    {
        static void Main(string[] args)
        {
            Brand brand = new Brand();
            brand.Id = 2; brand.Name = "AMD";
            CreateCpuDto createCpuDto = new CreateCpuDto();
            createCpuDto.HardwareName = "Cpu";
            createCpuDto.Brand = brand;
            createCpuDto.Price = 500;
            createCpuDto.Rate = 4;
            createCpuDto.Series = "I7 10050k";
            createCpuDto.CoreNumber = 4;
            createCpuDto.MemoryType = (MemoryType)2;
            ICpuRepository cpuRepository = new CpuRepository(new FileContext<Cpu>("./"));
            cpuRepository.Create(createCpuDto);
            //cpuRepository.Delete(24);
            var res = cpuRepository.GetAll();

            foreach (var item in res)
            {
                Console.WriteLine($"Id : {item.Id}");
                Console.WriteLine($"series : {item.Series}");
                Console.WriteLine($"HardwareName : {item.HardwareName}");
                Console.WriteLine("------------------------");
            }
            Console.ReadLine();
        }
    }
}
