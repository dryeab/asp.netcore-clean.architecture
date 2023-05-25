using System;
using HR.LeaveManagement.Application.DTOs;
using HR.LeaveManagement.Application.DTOs.LeaveAllocation;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands
{
    public class CreateLeaveAllocationCommand : IRequest<LeaveAllocationDto>
    {
        public CreateLeaveAllocationDto CreateLeaveAllocationDto { get; set; }
    }
}

