﻿using _02_BLL.Dto.Ram;
using _02_BLL.IRepositories;
using _03_DAL.Entity.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BLL.Repositories
{
    public class RamRepository : IRamRepository
    {
        RamDto IRamRepository.Create(CreateRamDto Ram)
        {
            throw new NotImplementedException();
        }

        bool IRamRepository.Delete(int Id)
        {
            throw new NotImplementedException();
        }

        List<Ram> IRamRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        RamDto IRamRepository.Update(CreateRamDto Ram)
        {
            throw new NotImplementedException();
        }
    }
}
