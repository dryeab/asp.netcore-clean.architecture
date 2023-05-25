using System;
using FluentValidation;
using HR.LeaveManagement.Application.Contracts.Persistence;

namespace HR.LeaveManagement.Application.DTOs.LeaveRequest.Validators
{
    public class ILeaveRequestDtoValidator : AbstractValidator<ILeaveRequestDto>
    {
        public ILeaveRequestDtoValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            RuleFor(p => p.StartDate).
            LessThan(p => p.EndDate).WithMessage("{Propery Name} must be before {ComparisonValue}");
            RuleFor(p => p.EndDate).
               GreaterThan(p => p.StartDate).WithMessage("{Propery Name} must be after {ComparisonValue}");

            RuleFor(p => p.LeaveTypeId).
                GreaterThan(0)
                .MustAsync(async (int id, CancellationToken token) =>
                {
                    var exists = await leaveTypeRepository.Exists(id);
                    return !exists;

                }).WithMessage("{Propety Name} does not exist.");
        }
    }
}

