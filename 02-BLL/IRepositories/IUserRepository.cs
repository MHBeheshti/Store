using _02_BLL.Dto.User;
using _03_DAL.Entity.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BLL.IRepositories
{
    public interface IUserRepository
    {
        List<User> GetAll();
        UserDto Create(CreateUserDto User);
        User Update(CreateUserDto User);
        bool Delete(int user);
        User CheckUser(string Username, string Password);
    }
}
