using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApiServer.Infrastructure.Context;

namespace WebApiServer.Infrastructure.Repository
{
    public class CabinetRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        CabinetContext context;
        DbSet<TEntity> dbSet;

        public CabinetRepository(CabinetContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }

        public TEntity AddEntity(TEntity entity)
        {
            try
            {
                var addedEntity = dbSet.Add(entity);
                context.SaveChanges();
                return addedEntity;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public bool DeleteEntity(TEntity entity)
        {
            try
            {
                dbSet.Remove(entity);
                context.SaveChanges();
                return true; 
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public TEntity FindById(int id)
        {
            try
            {
                return dbSet.Find(id);
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public IQueryable<TEntity> Get()
        {
            return dbSet.AsNoTracking();
        }

        public TEntity Get(Func<TEntity, bool> predicate)
        {
            try
            {
                return dbSet.AsNoTracking().FirstOrDefault(predicate);
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public bool UpdateEntity(TEntity entity)
        {
            try
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public void Dispose()
        {
        }
    }
}