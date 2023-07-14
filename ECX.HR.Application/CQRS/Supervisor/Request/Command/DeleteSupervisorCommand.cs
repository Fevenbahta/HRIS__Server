﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Supervisor.Request.Command
{
    public class DeleteSupervisorCommand : IRequest
    {
        public int Id { get; set; }
    }
}