﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.DepositAutorization.Request.Command
{
    public class DeleteDepositAutorizationCommand : IRequest
    {
        public int Id { get; set; }
    }
}
