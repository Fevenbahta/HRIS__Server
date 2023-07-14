using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.DTOs.OrganizationalProfiles.Validator
{
    public class LevelDtoValidators : AbstractValidator<EmployeeStatusDto>
    {
        public LevelDtoValidators()
        {
            RuleFor(p => p.Id)
               .NotEmpty().WithMessage("{PropertyName} is requiered.")
               .NotNull();
            RuleFor(p => p.Name)
               .NotEmpty().WithMessage("{PropertyName} is requiered.")
               .NotNull();
            
        }
    }
}
