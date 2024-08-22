using MediatR;
using QimiaSchool.Business.Implementations.Queries.Enrollments.Dtos;

namespace QimiaSchool.Business.Implementations.Queries.Enrollments;
public class GetEnrollmentsQuery : IRequest<List<EnrollmentDto>>
{
}

