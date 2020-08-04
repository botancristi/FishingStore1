using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OnlineFishingStore.Interfaces
{
    public interface IRepository<TEntity> where TEntity: class
    {
        void Delete(TEntity entityToDelete);

        void Delete(object id);

        IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProprieties = "");

        TEntity GetByID(object id);

        IEnumerable<TEntity> GetWithRawSql(string query,
            params object[] parameters);

        void Insert(TEntity entity);
        void Update(TEntity entityToUpdate);
    }
}
