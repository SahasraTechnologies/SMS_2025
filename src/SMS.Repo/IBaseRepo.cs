using SMS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Repo
{
    public interface IBaseRepo<TEntity> where TEntity : class
    {
        Task<SmsResponseDto<TEntity>> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

    }
}
