using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Demo.Service;
using Demo.DL.Entities;

namespace Demo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userservice;

        public UserController(IUserService userService)
        {
            _userservice = userService;
        }

        [HttpGet]
        public List<User> FindAllUsers()
        {
            return _userservice.FindAll();
        }

        [HttpGet("{id}")]
        public User FindUserById(int id)
        {
            return _userservice.FindById(id);
        }
    }
}