﻿using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.EmergencyContact.Request.Queries;

using ECX.HR.Application.DTOs.EmergencyContacts;
using ECX.HR.Application.Exceptions;
using ECX.HR.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.EmergencyContact.Handler.Queries
{
    public class GetEmergencyContactDetailRequestHandler : IRequestHandler<GetEmergencyContactDetailRequest, EmergencyContactDto>
    {
        private IEmergencyContactRepository _EmergencyContactRepository;
        private IMapper _mapper;
        public GetEmergencyContactDetailRequestHandler(IEmergencyContactRepository EmergencyContactRepository, IMapper mapper)
        {
            _EmergencyContactRepository = EmergencyContactRepository;
            _mapper = mapper;
        }
        public async Task<EmergencyContactDto> Handle(GetEmergencyContactDetailRequest request, CancellationToken cancellationToken)
        {
            var emergencyContact =await _EmergencyContactRepository.GetById(request.Id);
          
            if (emergencyContact == null)
                throw new NotFoundException(nameof(emergencyContact), request.Id);

            else
                return _mapper.Map<EmergencyContactDto>(emergencyContact);
        }
    }
}
