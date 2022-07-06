using Burger.DAL.Abstract;
using Burger.DAL.Contexts;
using Burger.Entities;
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
            throw new NotImplementedException();
        }

        public int Delete(T input)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAllInclude(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] include)
        {
            throw new NotImplementedException();
        }

        public int Update(T input)
        {
            throw new NotImplementedException();
        }
    }
}
