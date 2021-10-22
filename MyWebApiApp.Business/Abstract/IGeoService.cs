using MyWebApiApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApiApp.Business.Abstract
{
    public interface IGeoService
    {
        Geo GetById(int id);
        List<Geo> GetAll();
        Geo Create(Geo entity);       
        Geo Update(Geo entity); 
        void Delete(Geo entity);
    }
}
