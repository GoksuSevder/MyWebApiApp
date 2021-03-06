using MyWebApiApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApi.DataAccess.Abstract
{
    public interface IUserDal : IGenericRepository<User>
    {
        IEnumerable<User> GetAllUserInfo();
    }
}
