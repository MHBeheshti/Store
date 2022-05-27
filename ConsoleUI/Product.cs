using _02_BLL.IRepositories;
using _02_BLL.Repositories;
using _03_DAL.Entity.Hardware;
using _03_DAL.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Product
    {
        public void ShowProduct(int a)
        {
            switch (a)
            {
                case 1:
                    ShowCpu();
                    break;
                case 2:
                    ShowRam();
                    break;
                case 3:
                    ShowMotherboard();
                    break;
                case 4:
                    ShowGraphicsCard();
                    break;
                default:
                    Console.WriteLine("wrong input !!!");
                    a = int.Parse(Console.ReadLine());
                    ShowProduct(a);
                    break;
            }
        }
        public void ShowCpu()
        {
            ICpuRepository cpuRepository = new CpuRepository(new FileContext<Cpu>("./"));
            var res = cpuRepository.GetAll();
            foreach (var item in res)
            {
                Console.WriteLine($"Id : {item.Id}");
                Console.WriteLine($"series : {item.Series}");
                Console.WriteLine($"HardwareName : {item.HardwareName}");
                Console.WriteLine($"CoreNumber : {item.CoreNumber}");
                Console.WriteLine($"Brand : {item.Brand}");
                Console.WriteLine($"Rate : {item.Rate}");
                Console.WriteLine($"Off : {item.Off}");
                Console.WriteLine($"Count : {item.Count}");
                Console.WriteLine($"Status : {item.Status}");
                Console.WriteLine($"Price : {item.Price}");
                Console.WriteLine($"MemoryType : {item.MemoryType}");
                Console.WriteLine("------------------------");
            }
        }
        public void ShowRam()
        {
            IRamRepository ramRepository = new RamRepository(new FileContext<Ram>("./"));
            var res = ramRepository.GetAll();
            foreach (var item in res)
            {
                Console.WriteLine($"Id : {item.Id}");
                Console.WriteLine($"Size : {item.Size}");
                Console.WriteLine($"ModuleCount : {item.ModuleCount}");
                Console.WriteLine($"HardwareName : {item.HardwareName}");
                Console.WriteLine($"Brand : {item.Brand}");
                Console.WriteLine($"Rate : {item.Rate}");
                Console.WriteLine($"Off : {item.Off}");
                Console.WriteLine($"Count : {item.Count}");
                Console.WriteLine($"Status : {item.Status}");
                Console.WriteLine($"Price : {item.Price}");
                Console.WriteLine($"MemoryType : {item.MemoryType}");
                Console.WriteLine("------------------------");
            }
        }
        public void ShowGraphicsCard()
        {
            IGraphicsCardRepository graphicsCardRepository = new GraphicsCardRepository(new FileContext<GraphicsCard>("./"));
            var res = graphicsCardRepository.GetAll();
            foreach (var item in res)
            {
                Console.WriteLine($"Id : {item.Id}");
                Console.WriteLine($"HtmiPorts : {item.HtmiPorts}");
                Console.WriteLine($"HardwareName : {item.HardwareName}");
                Console.WriteLine($"Brand : {item.Brand}");
                Console.WriteLine($"Rate : {item.Rate}");
                Console.WriteLine($"Off : {item.Off}");
                Console.WriteLine($"Count : {item.Count}");
                Console.WriteLine($"Status : {item.Status}");
                Console.WriteLine($"Price : {item.Price}");
                Console.WriteLine($"MemoryType : {item.MemoryType}");
                Console.WriteLine("------------------------");
            }
        }
        public void ShowMotherboard()
        {
            IMotherboardRepository motherboardRepository = new MotherboardRepository(new FileContext<Motherboard>("./"));
            var res = motherboardRepository.GetAll();
            foreach (var item in res)
            {
                Console.WriteLine($"Id : {item.Id}");
                Console.WriteLine($"PciCount : {item.PciCount}");
                Console.WriteLine($"RaidSupport : {item.RaidSupport}");
                Console.WriteLine($"HardwareName : {item.HardwareName}");
                Console.WriteLine($"Brand : {item.Brand}");
                Console.WriteLine($"Rate : {item.Rate}");
                Console.WriteLine($"Off : {item.Off}");
                Console.WriteLine($"Count : {item.Count}");
                Console.WriteLine($"Status : {item.Status}");
                Console.WriteLine($"Price : {item.Price}");
                Console.WriteLine($"Type : {item.Type}");
                Console.WriteLine($"SlotCount : {item.SlotCount}");
                Console.WriteLine("------------------------");
            }
        }
        public void EditProduct()
        {
            Console.WriteLine("Choose product : \n 1.CPU        2.RAM       3.Motherboard       4.GraphicsCard");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    EditCpu();
                    break;
                case 2:
                    EditRam();
                    break;
                case 3:
                    EditMotherboard();
                    break;
                case 4:
                    EditGraphicsCard();
                    break;
                default:
                    Console.WriteLine("wrong input !!!");
                    a = int.Parse(Console.ReadLine());
                    ShowProduct(a);
                    break;
            }
        }

        private void EditGraphicsCard()
        {
            throw new NotImplementedException();
        }

        private void EditMotherboard()
        {
            throw new NotImplementedException();
        }

        private void EditRam()
        {
            throw new NotImplementedException();
        }

        private void EditCpu()
        {
            Cpu cpu = new Cpu();
            throw new NotImplementedException();
        }
    }
}
