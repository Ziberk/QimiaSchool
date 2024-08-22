using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QimiaSchool.Business.Implementations.Queries.Courses.Dtos
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int Credits { get; set; }
    }
}
