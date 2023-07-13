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
    public class GetAddressListRequestHandler : IRequestHandler<GetAddressListRequest, List<AddressDto>>
    {
        private IAddressRepository _AddressRepository;
        private IMapper _mapper;
        public GetAddressListRequestHandler(IAddressRepository AddressRepository, IMapper mapper)
        {
            _AddressRepository= AddressRepository;
            _mapper = mapper;
        }
        public async Task<List<AddressDto>> Handle(GetAddressListRequest request, CancellationToken cancellationToken)
        {
            var Address =await _AddressRepository.GetAll();
            return _mapper.Map<List<AddressDto>>(Address);
        }
    }
}
