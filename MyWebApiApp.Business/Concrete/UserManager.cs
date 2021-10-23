using MyWebApi.DataAccess.Abstract;
using MyWebApiApp.Business.Abstract;
using MyWebApiApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApiApp.Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public User Create(User entity)
        {
           return _userDal.Create(entity);
        }

        public void Delete(User entity)
        {
            _userDal.Delete(entity);
        }

        public User GetById(int id)
        {
           return _userDal.GetById(id);
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll().ToList();
        }

        public User Update(User entity)
        {
          return  _userDal.Update(entity);
        }

        public List<User> GetAllUserInfo()
        {
            return _userDal.GetAllUserInfo().ToList();
        }
    }
}
