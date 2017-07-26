using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiServer.Infrastructure.Repository
{
    public interface IRepository<TEntity>:IDisposable where TEntity:class
    {
        TEntity FindById(int id);
        IQueryable<TEntity> Get();
        TEntity AddEntity(TEntity entity);
        TEntity Get(Func<TEntity, bool> predicate);
        bool UpdateEntity(TEntity entity);
        bool DeleteEntity(TEntity entity);
    }
}
