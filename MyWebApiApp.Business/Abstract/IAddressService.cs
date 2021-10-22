using MyWebApiApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApiApp.Business.Abstract
{
    public interface IAddressService
    {
        Address GetById(int id);
        List<Address> GetAll();
        Address Create(Address entity);
        Address Update(Address entity);
        void Delete(Address entity);
    }
}
