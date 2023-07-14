﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.DTOs.Division.Validator
{
    public class DivisionValidator : AbstractValidator<DivisionDto>
    {
        public DivisionValidator()
        {

            RuleFor(p => p.Name)
                    .NotEmpty().WithMessage("{PropertyName} is requiered.")
                    .NotNull();
            RuleFor(p => p.Name)
                  .NotEmpty().WithMessage("{PropertyName} is requiered.")
                  .NotNull();
        }
    }
}