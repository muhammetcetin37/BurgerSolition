using Burger.DAL.Abstract;
using Burger.DAL.Contexts;
using Burger.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Burger.DAL.Concrete
{
    public class RepositoryBase<T> : IBaseRepository<T> where T : BaseEntity, new()
    {
        protected SqlDbContext db;
        public RepositoryBase()
        {
            db = new SqlDbContext();
        }
        public int Add(T input)
        {
            db.Set<T>().Add(input);
            return db.SaveChanges();
        }

        public int Delete(T input)
        {
            db.Set<T>().Remove(input);
            return db.SaveChanges();
        }

        public T Get(int id)
        {
            return db.Set<T>().Find(id);

        }

        public IList<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            if (filter == null)
            {
                return db.Set<T>().ToList();
            }
            else
            {
                return db.Set<T>().Where(filter).ToList();
            }
        }

        public IQueryable<T> GetAllInclude(Expression<Func<T, bool>> filter = null,
                                          params Expression<Func<T, object>>[] include)
        {
            var query = db.Set<T>().Where(filter);
            return include.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        public int Update(T input)
        {
            db.Set<T>().Update(input);
            return db.SaveChanges();
        }
    }
}
