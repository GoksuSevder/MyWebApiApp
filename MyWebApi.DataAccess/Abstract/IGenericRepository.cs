using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApi.DataAccess.Abstract
{
    public interface IGenericRepository<T>
    {
        T GetById(int id);
        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Create(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}
