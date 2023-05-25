using System;
using HR.LeaveManagement.Application.DTOs.Common;
using HR.LeaveManagement.Application.DTOs.LeaveType;

namespace HR.LeaveManagement.Application.DTOs;

public class LeaveTypeDto : BaseDto, ILeaveTypeDto
{
    public string Name { get; set; }
    public int DefaultDays { get; set; }
}


