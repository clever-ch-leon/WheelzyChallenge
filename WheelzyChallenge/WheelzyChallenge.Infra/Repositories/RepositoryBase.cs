using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelzyChallenge.Domain.Entities.Base;
using WheelzyChallenge.Domain.Interfaces.Repositories;

namespace WheelzyChallenge.Infra.Repositories
{
    public abstract class RepositoryBase<TContext, TEntity, TPrimaryKey> : IRepositoryBase<TEntity, TPrimaryKey>
        where TContext : DbContext
        where TEntity : Entity<TPrimaryKey>
    {
        public virtual TContext DbContext { get; }


        public RepositoryBase(TContext dbContextSocioContrato)
        {
            DbContext = dbContextSocioContrato;
        }


        public TEntity Add(TEntity entity)
        {
            try
            {
                var entry = DbContext.Set<TEntity>().Add(entity);

                return entry.Entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public TEntity Update(TEntity entity)
        {
            try
            {
                var entry = DbContext.Set<TEntity>().Update(entity);

                return entry.Entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public virtual async Task DeleteAsync(TEntity entity)
        {
            try
            {
                await Task.FromResult(DbContext.Set<TEntity>().Remove(entity));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual Task SaveChangesAsync()
        {
            try
            {
                return DbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual async Task<TEntity> GetAsync(TPrimaryKey id)
        {
            try
            {
                var query = DbContext.Set<TEntity>().AsQueryable();

                TEntity entity = null;

                entity = await query.FirstOrDefaultAsync(e => e.Id.Equals(id));

                return entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
