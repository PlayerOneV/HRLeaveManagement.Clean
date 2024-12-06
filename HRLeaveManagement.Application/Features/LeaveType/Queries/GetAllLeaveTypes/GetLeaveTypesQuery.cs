using MediatR;

namespace HRLeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes
{
    public class GetLeaveTypesQuery : IRequest<IEnumerable<LeaveTypeDto>>
    {
    }
}
