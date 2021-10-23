using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebApiApp.Business.Abstract;
using MyWebApiApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWepApiApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IUserService _userService;
        public ValuesController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public List<User> Get()
        {
            return _userService.GetAllUserInfo();

        }
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _userService.GetById(id);

        }
        [HttpPost]
        public User Post([FromBody]User user)
        {
            return _userService.Create(user);
        }
        [HttpPut]
        public User Put([FromBody] User user)
        {
            return _userService.Update(user);
        }
        [HttpDelete]
        public void Delete([FromBody] User user)
        {
            _userService.Delete(user);
        }
    }
}
