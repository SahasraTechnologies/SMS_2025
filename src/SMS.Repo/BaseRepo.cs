using Microsoft.EntityFrameworkCore;
using SMS.Core;
using SMS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Repo
{
    public class BaseRepo<TEntity> : IBaseRepo<TEntity> where TEntity : class
    {
        protected readonly SmsContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public BaseRepo(SmsContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public async Task<SmsResponseDto<TEntity>> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                IQueryable<TEntity> query = _dbSet.AsNoTracking() // Add NoTracking here
                                                  .Where(predicate);

                var result = await query.FirstOrDefaultAsync();

                if(result != null)
                {
                    return SmsResponseDto<TEntity>.Success(result);
                }
                else
                {
                    return SmsResponseDto<TEntity>.Fail($"NO data returned");
                }
            }
            catch (Exception ex)
            {
                return SmsResponseDto<TEntity>.Fail($"Query failed: {ex.Message}");
            }
            
        }
    }

}
