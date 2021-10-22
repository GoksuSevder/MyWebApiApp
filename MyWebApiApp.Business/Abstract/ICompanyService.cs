using MyWebApiApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApiApp.Business.Abstract
{
    public interface ICompanyService
    {
        Company GetById(int id);
        List<Company> GetAll();
        Company Create(Company entity);       
        Company Update(Company entity);
        void Delete(Company entity);
    }
}
