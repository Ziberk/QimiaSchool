using QimiaSchool.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QimiaSchool.Business.Implementations.Queries.Enrollments.Dtos
{
    public class EnrollmentDto
    {
        public int Id { get; set; }
        public int courseID { get; set; }
        public int studentID { get; set; }
        public Grade? grade { get; set; }
    }
}
