using _02_BLL;
using _02_BLL.Dto.Cpu;
using _02_BLL.Dto.GraphicsCard;
using _02_BLL.Dto.User;
using _02_BLL.IRepositories;
using _02_BLL.Repositories;
using _03_DAL.Entity.Hardware;
using _03_DAL.Entity.Identity;
using _03_DAL.Enums;
using _03_DAL.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Programs
    {
        private static string GetHash(string text)
        {
            // SHA512 is disposable by inheritance.  
            using (var sha256 = SHA256.Create())
            {
                // Send a sample text to hash.  
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));
                // Get the hashed string.  
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        
        static void Main(string[] args)
        {

            int a = 1;
            string s;
            User user = new User();

            Console.WriteLine("Welcome !!!");
            Console.WriteLine("1.sign in     2.sign up");

            while(true)
            {
                a = int.Parse(Console.ReadLine());

                if (a == 1)
                {
                    user = Login.SignIn();
                    if (user == null)
                    {
                        Console.WriteLine("user dosnt exist !");
                    }else
                    {
                        Console.WriteLine($"welcome {user.FirstName}");
                        break;
                    }
                }
                else if (a == 2)
                {
                    Login.SignUp();
                    Console.WriteLine($"welcome {user.FirstName} ");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Input !!!");
                }
                Console.WriteLine("1.sign in     2.sign up");
            }
            while (true)
            {
                if (user.Role == (Role)0)
                {
                    //do somthing
                }
                else if (user.Role == (Role)1)
                {
                    //do somthing
                }
                else if (user.Role == (Role)2)
                {
                    s = "Select the desired option : \n 1.Edit profile      2.Buy product";

                }
                else
                    Console.WriteLine("wrong input !");

            }











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
            CreateGraphicsCardDto createGraphicsCardDto = new CreateGraphicsCardDto();
            createGraphicsCardDto.HardwareName = "blah blah blah";
            Console.ReadLine();
        }
    }
}
