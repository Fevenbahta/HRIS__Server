using ECX.HR.Application.DTOs.Supervisor;
using ECX.HR.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Supervisor.Request.Command
{
    public class CreateSupervisorCommand : IRequest<BaseCommandResponse>
    {
        public SupervisorDto SupervisorDto { get; set; }
    }
}
