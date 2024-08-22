using QimiaSchool.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QimiaSchool.Business.Abstractions
{
    public interface IStudentManager
    {
        public Task CreateStudentAsync(Student student, CancellationToken cancellationToken);

        public Task<Student> GetStudentByIdAsync(int studentId, CancellationToken cancellationToken);

        public Task UpdateStudentAsync(Student student, CancellationToken cancellationToken);

        public Task DeleteStudentByIdAsync(int studentId, CancellationToken cancellationToken);

        public Task<IEnumerable<Student>> GetAllStudentsAsync(CancellationToken cancellationToken);
        public Task<IEnumerable<Student>> GetByConditionAsync(Expression<Func<Student, bool>> expression);
    }
}
