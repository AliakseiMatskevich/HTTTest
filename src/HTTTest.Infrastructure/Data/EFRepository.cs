using HTTTest.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HTTTest.Infrastructure.Data
{
    public sealed class EFRepository<T> : IRepository<T> where T : class
    {
        HTTTestContext _dbContext;

        public EFRepository(HTTTestContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<T>> GetListAsync(Expression<Func<T, bool>>? predicate = null, 
                Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, 
                Func<IQueryable<T>, IIncludableQueryable<T, object>>? includes = null)
        {
            IQueryable<T> query = _dbContext.Set<T>();

            if (predicate is not null)
            {
                query = query.Where(predicate);
            }

            if (includes is not null)
            {
                query = includes(query);
            }

            return orderBy is null ? await query.ToListAsync() : await orderBy(query).ToListAsync();
        }
    }
}
