using Ardalis.Specification;
using Dmd.Domain.Entities;
using Dmd.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EFCore.BulkExtensions;

namespace Dmd.Infrastructure.Data.Repository
{
    public class GenericRepositoryAsync<T> : IGenericRepositoryAsync<T> where T : class
    {
        private readonly ApplicationContext _db;

        public GenericRepositoryAsync(ApplicationContext db)
        {
            _db = db;
        }

        public async void AddAsync(T entity)
        {
            BulkConfig bulkConfig = new BulkConfig {  SetOutputIdentity = true };
            await _db.BulkInsertAsync<T>(new List<T> { (T) entity }, bulkConfig);
        }

        public Task<int> CountAsync(ISpecification<T> spec)
        {
            throw new NotImplementedException();
        }


        public Task<T> FirstAsync(ISpecification<T> spec)
        {
            throw new NotImplementedException();
        }

        public Task<T> FirstOrDefaultAsync(ISpecification<T> spec)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _db.Set<T>().FindAsync(id).AsTask();
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _db.Set<T>().ToListAsync<T>();
        }

        public  Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<T>> ListAsync(Expression<Func<T, bool>> predicate)
        {
            
            return await _db.Set<T>().Where<T>(predicate).ToListAsync<T>();
        }


        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
        public async void Save()
        {
           await _db.SaveChangesAsync();
        }

        public async Task<T> FindAsync(int id)
        {
            return await _db.FindAsync<T>(id);
        }


    }
}
