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
           /* DateTime date1 = new DateTime(1380, 05, 06);
            IUserRepository userRepository = new UserRepository(new FileContext<User>("./"));
            CreateUserDto createUserDto = new CreateUserDto();
            createUserDto.FirstName = "Mohammad Hassan";
            createUserDto.LastName = "Beheshti";
            createUserDto.Username = "MHB";
            createUserDto.BirthofDate = date1;
            createUserDto.Email = "shahedmbeheshti110@gmail.com";
            createUserDto.Adress = "Iran, Tehran, Narmak";
            string Password = "1";
            Password = GetHash(Password);
            createUserDto.HashPassWord = Password;
            createUserDto.phone = "012345678910";
            createUserDto.Role = 0;
            userRepository.Create(createUserDto);
            */
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
                if (user.Role == 0)// general manager 
                {
                    s = "Select the desired option : \n 1.Edit profile      2.Show product      3.Add/Delete Admin      4.Edit Product";
                    Console.WriteLine(s);
                    a = int.Parse(Console.ReadLine());
                    GeneralManager generalManager = new GeneralManager();
                    generalManager.GeneralManagerAccess(a);
                }
                else if (user.Role == (Role)1)// manager
                {
                    //do somthing
                }
                else if (user.Role == (Role)2)// normal user
                {
                    s = "Select the desired option : \n 1.Edit profile      2.Show product";
                    Console.WriteLine(s);
                    a = int.Parse(Console.ReadLine());
                    if (a == 1) 
                    {
                        //do somthing
                    }else if (a == 2) 
                    {
                        Console.WriteLine("Choose product : \n 1.CPU        2.RAM       3.Motherboard       4.GraphicsCard");
                        a = int.Parse(Console.ReadLine());
                        Product product = new Product();
                        product.ShowProduct(a);
                    }
                    else
                        Console.WriteLine("Wrong Input !!!");
                }
                else
                    Console.WriteLine("wrong input !!!");
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
