using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bidder.Data.Entities;
using Bidder.Data.Interfaces;
using Bidder.Data.Specifications;

namespace Bidder.Business.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly BidderDataContext _context;
        public GenericRepository(BidderDataContext context)
        {
            _context = context;
        }

        public  T GetById(int id)
        {
            return  _context.Set<T>().Find(id);
        }

        public  IReadOnlyList<T> ListAll()
        {
            return  _context.Set<T>().ToList();
        }

        public  T GetEntityWithSpec(ISpecification<T> spec)
        {
            return  ApplySpecification(spec).FirstOrDefault();
        }

        public  IReadOnlyList<T> ListAllWithSpec(ISpecification<T> spec)
        {
            return  ApplySpecification(spec).ToList();
        }

        public  int CountAsync(ISpecification<T> spec)
        {
            return  ApplySpecification(spec).Count();
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_context.Set<T>().AsQueryable(), spec);
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
    }
}
