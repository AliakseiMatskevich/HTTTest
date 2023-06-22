using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HTTTest.ApplicationCore.Interfaces
{
    public interface IRepository<T>  where T : class
    {
        Task<IList<T>> GetListAsync(Expression<Func<T, bool>>? predicate = null,
                Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                Func<IQueryable<T>, IIncludableQueryable<T, object>>? includes = null);
    }
}
