using QimiaSchool.Business.Abstractions;
using QimiaSchool.DataAccess.Entities;
using QimiaSchool.DataAccess.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QimiaSchool.Business.Implementations
{
    public class StudentManager : IStudentManager
    {
        private readonly IStudentRepository _studentRepository;
        public StudentManager(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public Task CreateStudentAsync(Student student, CancellationToken cancellationToken)
        {
            student.Id = default;
            return _studentRepository.CreateAsync(student, cancellationToken);
        }
        public Task<Student> GetStudentByIdAsync(int studentId, CancellationToken cancellationToken)
        {
            return _studentRepository.GetByIdAsync(studentId, cancellationToken);
        }
        public async Task DeleteStudentByIdAsync(int studentId, CancellationToken cancellationToken)
        {
            await _studentRepository.DeleteByIdAsync(studentId, cancellationToken);
        }
        public async Task UpdateStudentAsync(Student student, CancellationToken cancellationToken)
        {
            await _studentRepository.UpdateAsync(student, cancellationToken);
        }
        public Task<IEnumerable<Student>> GetAllStudentsAsync(CancellationToken cancellationToken)
        {
            return _studentRepository.GetAllAsync(cancellationToken);
        }
        public Task<IEnumerable<Student>> GetByConditionAsync(Expression<Func<Student, bool>> expression)
        {
            return _studentRepository.GetByConditionAsync(expression);
        }
    }
}
