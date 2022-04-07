using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Bidder.Data.Entities;
using Bidder.Data.Specifications;

namespace Bidder.Data.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        T GetById(int id);
        IReadOnlyList<T> ListAll();
        T GetEntityWithSpec(ISpecification<T> spec);
        IReadOnlyList<T> ListAllWithSpec(ISpecification<T> spec);
        int CountAsync(ISpecification<T> spec);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
