using _03_DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BLL.Dto.User
{
    public class CreateUserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public DateTime BirthofDate { get; set; }
        public Role Role { get; set; }
        public bool IsActive { get; set; } = true;
        public string Email { get; set; }
        public string phone { get; set; }
        public string Adress { get; set; }
        public string HashPassWord { get; set; }
    }
}
