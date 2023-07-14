using ECX.HR.Application.DTOs.Salaries;
using FluentValidation;


namespace ECX.HR.Application.DTOs.Salary.Validator
{
    public class SalaryDtoValidators : AbstractValidator<SalaryDto>
    {
        public SalaryDtoValidators()
        {
            RuleFor(p => p.BasicSalary)
               .NotEmpty().WithMessage("{PropertyName} is requiered.")
               .NotNull();
            RuleFor(p => p.Currency)
               .NotEmpty().WithMessage("{PropertyName} is requiered.")
               .NotNull();
            
        }
    }
}
