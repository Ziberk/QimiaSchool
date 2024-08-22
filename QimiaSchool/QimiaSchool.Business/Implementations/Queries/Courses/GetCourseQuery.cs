using MediatR;
using QimiaSchool.Business.Implementations.Queries.Courses.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QimiaSchool.Business.Implementations.Queries.Courses
{
    public class GetCourseQuery : IRequest<CourseDto>
    {
        public int Id { get; }
        public GetCourseQuery(int id) {
            Id = id;

        }
    }
}
