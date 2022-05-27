using _02_BLL.IRepositories;
using _02_BLL.Repositories;
using _03_DAL.Entity.Identity;
using _03_DAL.Persistance;
using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_BLL.Dto.User;

namespace ConsoleUI
{
    static public class Login
    {
        static public string Username { get; set; }
        static public string HashPassword { get; set; }

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
        static string GetUsername()
        {
            string username;
            Console.WriteLine("insert username:");
            username = Console.ReadLine();
            return username;
        }
        static string GetPassword()
        {
            string password;
            Console.WriteLine("insert Password:");
            password = Console.ReadLine();
            return password;
        }
        static public User VerifyUser(string username, string hashpassword)
        {
            IUserRepository userRepository = new UserRepository(new FileContext<User>("./"));
            return userRepository.CheckUser(username, hashpassword);
        }

        static public User SignIn()
        {
            string s1, s2;
            s1 = GetUsername();
            s2 = GetPassword();
            s2 = GetHash(s2);
            var res = VerifyUser(s1, s2);
            return res;
        }
        public static User SignUp()
        {
            CreateUserDto createUserDto = new CreateUserDto();
            Console.WriteLine("FirstName :");
            createUserDto.FirstName = Console.ReadLine();
            Console.WriteLine("LastName :");
            createUserDto.LastName = Console.ReadLine();
            Console.WriteLine("UserName :");
            createUserDto.Username = Console.ReadLine();
            //Console.WriteLine("BirthDay :");
            //createUserDto.BirthofDate = Console.ReadLine();
            Console.WriteLine("Email :");
            createUserDto.Email = Console.ReadLine();
            Console.WriteLine("Adress :");
            createUserDto.Adress = Console.ReadLine();
            Console.WriteLine("Password :");
            string Password = Console.ReadLine();
            Password = GetHash(Password);
            createUserDto.HashPassWord = Password;
            Console.WriteLine("Phone :");
            createUserDto.phone = Console.ReadLine();
            createUserDto.Role = (_03_DAL.Enums.Role)2;
            IUserRepository userRepository = new UserRepository(new FileContext<User>("./"));
            userRepository.Create(createUserDto);

            User user = new User()
            {
                FirstName = createUserDto.FirstName,
                LastName = createUserDto.LastName,
                Username = createUserDto.Username,
                Email = createUserDto.Email,
                Adress = createUserDto.Adress,
                HashPassWord = createUserDto.HashPassWord,
                //Id =CreateUserDto.Id
                phone = createUserDto.phone,
                Role = createUserDto.Role
            };
           
            return user;
        }
    }
}
