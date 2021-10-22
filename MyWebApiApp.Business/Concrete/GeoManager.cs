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
    public class GeoManager : IGeoService
    {
        IGeoDal _geoDal;
        public GeoManager(IGeoDal geoDal)
        {
            _geoDal = geoDal;
        }
        public Geo Create(Geo entity)
        {
          return  _geoDal.Create(entity);
        }

        public void Delete(Geo entity)
        {
            _geoDal.Delete(entity);
        }

        public Geo GetById(int id)
        {
            return _geoDal.GetById(id);
        }

        public List<Geo> GetAll()
        {
            return _geoDal.GetAll().ToList();
        }

        public Geo Update(Geo entity)
        {
           return _geoDal.Update(entity);
        }
    }
}
