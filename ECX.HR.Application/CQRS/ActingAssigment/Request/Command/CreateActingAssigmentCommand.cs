using ECX.HR.Application.DTOs.ActingAssigment;
using ECX.HR.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.ActingAssigment.Request.Command
{
    public class CreateActingAssigmentCommand : IRequest<BaseCommandResponse>
    {
        public ActingAssigmentDto ActingAssigmentDto { get; set; }
    }
}
