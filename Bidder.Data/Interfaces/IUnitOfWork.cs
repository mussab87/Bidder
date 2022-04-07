using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Bidder.Data.Entities;

namespace Bidder.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity;
        int Complete();
    }
}
