using MyWebApiApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApiApp.Business.Abstract
{
    public interface IUserService
    {
        User GetById(int id);
        List<User> GetAll();
        User Create(User entity); 
        User Update(User entity);
        void Delete(User entity);
       
    }
}
