using MyWebApi.DataAccess.Abstract;
using MyWebApiApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApi.DataAccess.Concrete
{
    public class GeoDal : GenericRepository<Geo, MyWebApiAppContext>, IGeoDal
    {
    }
}
