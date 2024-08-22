using AutoMapper;
using QimiaSchool.DataAccess.Entities;
using QimiaSchool.Business.Implementations.Queries.Enrollments.Dtos;
using QimiaSchool.Business.Implementations.Queries.Student.Dtos;
using QimiaSchool.Business.Implementations.Queries.Courses.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QimiaSchool.Business.Implementations.MapperProfiles
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            CreateMap<Enrollment, EnrollmentDto>()
                ;

            CreateMap<Student,StudentDto>()
                .ForMember(dest => dest.Enrollments, opt => opt.MapFrom(src => src.Enrollments))
                ;
            CreateMap<Course, CourseDto>()
            ;

        }
    }
}
