using QimiaSchool.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QimiaSchool.DataAccess.Repository.Abstractions
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<IEnumerable<T>> GetByConditionAsync(Expression<Func<T, bool>> expression);
        Task<T> GetByIdAsync(int id,CancellationToken cancellationToken=default);
        Task DeleteByIdAsync(int id, CancellationToken cancellationToken = default);
        Task CreateAsync(T entity,CancellationToken cancellationToken= default);
        Task UpdateAsync(T entity,CancellationToken cancellationToken=default);
        Task DeleteAsync(T entity, CancellationToken cancellationToken);
        Task<IEnumerable<Student>> GetByConditionAsync(Expression<Func<Student, bool>> expression);
    }
}
