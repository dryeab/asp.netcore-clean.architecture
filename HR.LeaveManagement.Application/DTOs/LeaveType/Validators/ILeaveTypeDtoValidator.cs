using System;
using FluentValidation;

namespace HR.LeaveManagement.Application.DTOs.LeaveType.Validators
{
    public class ILeaveTypeDtoValidator : AbstractValidator<ILeaveTypeDto>
    {
        public ILeaveTypeDtoValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("{Property Name} is required.").NotNull().MaximumLength(50).WithMessage
("{Propery Name} must not exceed {Comparison Value} characters.");

            RuleFor(p => p.DefaultDays).NotEmpty().WithMessage("{Property Name} is required.").NotNull()
                .GreaterThan(0).WithMessage("{Property Name} must be at least 1.")
                .LessThan(100).WithMessage("{Property Name} must be less than {Comparison Value}.");
        }
    }
}

