using _02_BLL.Dto.User;
using _02_BLL.IRepositories;
using _03_DAL.Entity.Identity;
using _03_DAL.Persistance.Interfaces;
using _03_DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BLL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IContext<User> _context;
        public UserRepository(IContext<User> context)
        {
            _context = context;
        }
        public UserDto Create(CreateUserDto UserDto)
        {
            User user = new User()
            {
                Id = IdGenerator.Generate(),
                FirstName = UserDto.FirstName,
                LastName = UserDto.LastName,
                Username = UserDto.Username,
                Email = UserDto.Email,
                BirthofDate = UserDto.BirthofDate,
                Adress = UserDto.Adress,
                phone = UserDto.phone,
                Create = DateTime.UtcNow,
                Role = UserDto.Role,
                IsActive = UserDto.IsActive,
                HashPassWord = UserDto.HashPassWord
            };
            _context.Create(user);
            _context.SaveChange();

            UserDto userdto = new UserDto();
            return userdto;
        }

        public bool Delete(int Id)
        {
            var res = _context.GetAll().ToList().Find(x => x.Id == Id);
            _context.Delete(res);
            _context.SaveChange();

            return true;
        }

        public List<User> GetAll()
        {
            return _context.GetAll().ToList();
        }

        public User Update(CreateUserDto User)
        {
            throw new NotImplementedException();
        }
        public User CheckUser(string Username, string Password )
        {
            if (!((_context.GetAll().ToList().Exists(x => x.Username == Username)) && (_context.GetAll().ToList().Exists(x => x.HashPassWord == Password))))
            {
                return null;
            }else
            {
                var users = _context.GetAll().ToList().FindAll(x => x.Username == Username);
                var res = users.Find(x => x.HashPassWord == Password);
                return res;
            }

        }
    }
}
