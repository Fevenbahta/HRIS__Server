
using ECX.HR.Application.DTOs.LeaveBalance;
using ECX.HR.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.LeaveBalance.Request.Command
{
    public class CreateLeaveBalanceCommand : IRequest<BaseCommandResponse>
    {
        public LeaveBalanceDto LeaveBalanceDto { get; set; }

        public CreateLeaveBalanceCommand(LeaveBalanceDto leaveBalanceDto)
        {
            LeaveBalanceDto = leaveBalanceDto;
        }
        public CreateLeaveBalanceCommand()
        {
            // Empty constructor
        }

    }
}
