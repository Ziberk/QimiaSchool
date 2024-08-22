using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using QimiaSchool.DataAccess.Repository.Abstractions.Exceptions;
using System.Text;
using System.Threading.Tasks;

namespace QimiaSchool.DataAccess.Repository.Abstractions
{
    public abstract class RepositoryBase<T> where T : class
    {
        protected QimiaSchoolDbContext DbContext { get; set; }

        private readonly DbSet<T> DbSet;
        protected RepositoryBase(QimiaSchoolDbContext dbContext)
        {
            DbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            DbSet = dbContext.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await DbContext.Set<T>().AsNoTracking().ToListAsync(cancellationToken);
        }
        public async Task<IEnumerable<T>> GetByConditionAsync(
            Expression<Func<T,bool>> expression,
            CancellationToken cancellationToken = default)
        {
            return await DbSet.Where(expression).ToListAsync(cancellationToken);
        }
        public async Task<T> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await DbSet.FindAsync(
            id,
            cancellationToken) ??
            throw new EntityNotFoundException<T>(id);

        }
        public async Task DeleteByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var entity= await GetByIdAsync(id, cancellationToken);
            DbContext.Remove(entity);
            await DbContext.SaveChangesAsync(cancellationToken);
        }
        public async Task CreateAsync(T entity, CancellationToken cancellationToken = default)
        {
            await DbSet.AddAsync(entity, cancellationToken);
            await DbContext.SaveChangesAsync(cancellationToken);

        }
        public async Task UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            DbSet.Update(entity);
            await DbContext.SaveChangesAsync(cancellationToken) ;

        }
        public async Task DeleteAsync(T entity, CancellationToken cancellationToken = default)
        {
            DbSet.Remove(entity);
            await DbContext.SaveChangesAsync(cancellationToken);
        }

    }
}
