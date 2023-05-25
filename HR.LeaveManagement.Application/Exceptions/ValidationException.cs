using System;
using FluentValidation.Results;

namespace HR.LeaveManagement.Application.Exceptions
{
    public class ValidationException : ApplicationException
    {
        public List<String> errors { get; set; }

        public ValidationException(ValidationResult result)
        {
            foreach (var error in result.Errors)
                errors.Add(error.ErrorMessage);
        }
    }
}

