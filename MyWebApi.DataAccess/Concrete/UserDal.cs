using Microsoft.EntityFrameworkCore;
using MyWebApi.DataAccess.Abstract;
using MyWebApiApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApi.DataAccess.Concrete
{
    public class UserDal : GenericRepository<User, MyWebApiAppContext>, IUserDal
    {
        public IEnumerable<User> GetAllUserInfo()
        {
            using (var context =new MyWebApiAppContext())
            {
                return context.Users
                    .Include(i => i.Company)       
                    .Include(i=>i.Address)
                    .ThenInclude(i=> i.Geo)                    
                    .ToList();                  
                    
            }
        }
    }
}
