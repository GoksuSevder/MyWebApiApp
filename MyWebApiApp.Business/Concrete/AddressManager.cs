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
    public class AddressManager : IAddressService
    {
        IAddressDal _addressDal;
        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }
        public Address Create(Address entity)
        {
           return _addressDal.Create(entity);
        }

        public void Delete(Address entity)
        {
            _addressDal.Delete(entity);
        }

        public Address GetById(int id)
        {
            return _addressDal.GetById(id);
        }

        public List<Address> GetAll()
        {
            return _addressDal.GetAll().ToList();
        }

        public Address Update(Address entity)
        {
          return  _addressDal.Update(entity);
        }
    }
}
