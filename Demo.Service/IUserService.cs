using System;
using System.Collections.Generic;
using System.Text;
using Demo.DL.Entities;

namespace Demo.Service
{
    public interface IUserService
    {
        List<User> FindAll();
        User FindById(int id);
    }
}
