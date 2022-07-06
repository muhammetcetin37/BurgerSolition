using Burger.BL.Abstract;
using Burger.DAL.Abstract;
using Burger.DAL.Concrete;
using Burger.Entities;
using System.Linq.Expressions;

namespace Burger.BL.Concrete
{
    public class ManagerBase<T> : IManagerBase<T> where T : BaseEntity, new()
    {
        protected IBaseRepository<T> repository;
        public ManagerBase()
        {
            repository = new RepositoryBase<T>();
        }
        public virtual int Add(T input)
        {
            return repository.Add(input);
        }

        public virtual int Delete(T input)
        {
            return repository.Delete(input);
        }

        public virtual T Get(int id)
        {
            return repository.Get(id);
        }

        public virtual IList<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return repository.GetAll(null);
        }

        public virtual IQueryable<T> GetAllInclude(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] include)
        {
            return repository.GetAllInclude(filter, include);
        }

        public virtual int Update(T input)
        {
            return repository.Update(input);
        }

    }
}
