﻿using ECX.HR.Application.DTOs.EmergencyContact;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.EmergencyContact.Request.Queries
{
    public class GetEmergencyContactDetailRequest :IRequest<EmergencyContactDto>
    {
        public int Id { get; set; }
    }
}
