﻿using ECX.HR.Application.DTOs.Leave;
using ECX.HR.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.LeaveType.Request.Command
{
    public class CreateLeaveTypeCommandv : IRequest<BaseCommandResponse>
    {
        public LeaveTypeDto leaveTypeDto { get; set; }
    }
}
