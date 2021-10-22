using Microsoft.EntityFrameworkCore;
using MyWebApi.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApi.DataAccess.Concrete
{
    public class GenericRepository<T,TContext> : IGenericRepository<T>
        where T : class
        where TContext : DbContext, new()
    {
        public T GetById(int id)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().Find(id);
            }
        }
        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<T>().ToList()
                    : context.Set<T>().Where(filter).ToList();
            }
        }      
        public T Create(T entity)
        {
            using (var context = new TContext())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
                return entity;
            }
        }
        public T Update(T entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State=EntityState.Modified;
                context.SaveChanges();
                return entity;
            }
        }
        public void Delete(T entity)
        {
            using (var context = new TContext())
            {
                context.Set<T>().Remove(entity);
                context.SaveChanges();
            }
        }
    }
}
