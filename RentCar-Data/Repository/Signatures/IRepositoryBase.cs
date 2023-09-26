using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RentCar_Data.Repository.Signatures
{
   public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
        void Create(T entity);
        void CreateRange(IList<T> entities);
        void Update(T entity);
        void Delete(T entity);
        void DeleteRange(ICollection<T> entities);
    }
}
