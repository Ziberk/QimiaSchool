using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using QimiaSchool.Business.Abstractions;
using QimiaSchool.Business.Implementations.Commands.Students;
using QimiaSchool.Business.Implementations.Queries.Enrollments.Dtos;
using QimiaSchool.DataAccess.Entities;


namespace QimiaSchool.Business.Implementations.Handlers.Students.Commands
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, int>
    {
        private readonly IStudentManager _studentManager;
        public CreateStudentCommandHandler(IStudentManager studentManager)
        {
            _studentManager = studentManager;
        }
        public async Task<int> Handle(CreateStudentCommand request,CancellationToken cancellationToken)
        {
            var student= new Student
            {
                FirstName = request.Student.FirstMidName,
                LastName = request.Student.LastName,
                EnrollmentDate = DateTime.Now,
            };
            await _studentManager.CreateStudentAsync(student, cancellationToken);

            return student.Id;
        }
    }
}
