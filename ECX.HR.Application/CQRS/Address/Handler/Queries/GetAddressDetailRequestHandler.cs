﻿using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.Addresss.Request.Queries;

using ECX.HR.Application.DTOs.Addresss;
using ECX.HR.Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Addresss.Handler.Queries
{
    public class GetAddressDetailRequestHandler : IRequestHandler<GetAddressDetailRequest, AddressDto>
    {
        private IAdressRepository _AddressRepository;
        private IMapper _mapper;
        public GetAddressDetailRequestHandler(IAdressRepository AddressRepository, IMapper mapper)
        {
            _AddressRepository = AddressRepository;
            _mapper = mapper;
        }
        public async Task<AddressDto> Handle(GetAddressDetailRequest request, CancellationToken cancellationToken)
        {
            var address =await _AddressRepository.GetById(request.Id);
            
            if (address == null)
                throw new NotFoundException(nameof(address), request.Id);
           
            else
                return _mapper.Map<AddressDto>(address);
        }
    }
}
