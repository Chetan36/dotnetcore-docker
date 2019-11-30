using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Demo.DL.Entities;
using Demo.Service;

namespace Demo.Service.Implementations
{
    public class UserService : IUserService
    {
        public List<User> FindAll()
        {
            List<User> users = new List<User>();
            users.Add(new User(1, "Priyabrata Pati", "priyabrata@pati.com", "9988776655"));
            users.Add(new User(2, "Chetan", "priya@brata.pati", "8877664455"));
            users.Add(new User(3, "Priya", "chetan@priya.brata", "3355233266"));

            return users;
        }

        public User FindById(int id)
        {
            return new User(id, "Priyabrata Pati", "priyabrata@pati.com", "9988776655");
        }
    }
}
