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
    public class CompanyManager : ICompanyService
    {
        ICompanyDal _companyDal;
        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }
        public Company Create(Company entity)
        {
            return _companyDal.Create(entity);
        }

        public void Delete(Company entity)
        {
            _companyDal.Delete(entity);
        }

        public Company GetById(int id)
        {
            return _companyDal.GetById(id);
        }

        public List<Company> GetAll()
        {
            return _companyDal.GetAll().ToList();
        }

        public Company Update(Company entity)
        {
            return _companyDal.Update(entity);
        }
    }
}
