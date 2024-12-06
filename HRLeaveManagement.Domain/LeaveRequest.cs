using HRLeaveManagement.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRLeaveManagement.Domain;

public class LeaveRequest : BaseEntity
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime DateRequested { get; set; }
    public string? RequestComments { get; set; }
    public bool? IsApproved { get; set; }
    public bool IsCancelled { get; set; }
    public string? RequestingEmployeeId { get; set; }
    
    
    [ForeignKey("LeaveTypeId")]
    public LeaveType? LeaveType { get; set; }
    public int LeaveTypeId { get; set; }
}
