using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelzyChallenge.Domain.Entities.Base;

namespace WheelzyChallenge.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity, TPrimaryKey>
        where TEntity : Entity<TPrimaryKey>
    {

        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task SaveChangesAsync();
        Task<TEntity> GetAsync(TPrimaryKey id);
    }
}
