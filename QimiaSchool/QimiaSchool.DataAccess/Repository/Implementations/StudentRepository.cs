using QimiaSchool.DataAccess.Entities;
using QimiaSchool.DataAccess.Repository.Abstractions;
using System.Linq.Expressions;

namespace QimiaSchool.DataAccess.Repository.Implementations
{
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository(QimiaSchoolDbContext dbContext) : base(dbContext)
        {
        }

        public Task<IEnumerable<Student>> GetByConditionAsync(Expression<Func<Student, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }

}
