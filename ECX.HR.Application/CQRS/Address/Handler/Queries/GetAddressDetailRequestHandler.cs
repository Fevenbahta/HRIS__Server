using AutoMapper;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.Addresss.Request.Queries;
using ECX.HR.Application.DTOs.Address;
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
        private IAddressRepository _AddressRepository;
        private IMapper _mapper;
        public GetAddressDetailRequestHandler(IAddressRepository AddressRepository, IMapper mapper)
        {
            _AddressRepository = AddressRepository;
            _mapper = mapper;
        }
        public async Task<AddressDto> Handle(GetAddressDetailRequest request, CancellationToken cancellationToken)
        {
            var Address =await _AddressRepository.GetById(request.Id);
            return _mapper.Map<AddressDto>(request);
        }
    }
}
