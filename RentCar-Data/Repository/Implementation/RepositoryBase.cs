using Microsoft.EntityFrameworkCore;
using RentCar_Data.DContext;
using RentCar_Data.Repository.Signatures;
using RentCar_Model.Models;

namespace RentCar_Data.Repository.Implementation
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class

    {
        protected RentCarContext RentCarContext;
       
        public RepositoryBase(RentCarContext _RentCarContext)
        {
            this.RentCarContext = _RentCarContext;
        }

       public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ?
              RentCarContext.Set<T>()
                .AsNoTracking() :
              RentCarContext.Set<T>();

        public IQueryable<T> FindByCondition(System.Linq.Expressions.Expression<Func<T, bool>> expression,
            bool trackChanges) =>
            !trackChanges ?
              RentCarContext.Set<T>()
                .Where(expression)
                .AsNoTracking() :
              RentCarContext.Set<T>()
                .Where(expression);
      

        public void Create(T entity) => RentCarContext.Set<T>().Add(entity);

        public void CreateRange(IList<T> entities) => RentCarContext.Set<T>().AddRange(entities);

        public void Update(T entity) => RentCarContext.Set<T>().Update(entity);

        public void Delete(T entity) => RentCarContext.Set<T>().Remove(entity);
        public void DeleteRange(ICollection<T> entities) => RentCarContext.Set<T>().RemoveRange(entities);

    }
}
