using AutoMapper;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.EmployeePosition.Request.Queries;
using ECX.HR.Application.DTOs.EmployeePosition;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.EmployeePosition.Handler.Queries
{
    public class GetEmployeePositionDetailRequestHandler : IRequestHandler<GetEmployeePositionDetailRequest, EmployeePositionDto>
    {
        private IEmployeePositionRepository _EmployeePositionRepository;
        private IMapper _mapper;
        public GetEmployeePositionDetailRequestHandler(IEmployeePositionRepository EmployeePositionRepository, IMapper mapper)
        {
            _EmployeePositionRepository = EmployeePositionRepository;
            _mapper = mapper;
        }
        public async Task<EmployeePositionDto> Handle(GetEmployeePositionDetailRequest request, CancellationToken cancellationToken)
        {
            var EmployeePosition =await _EmployeePositionRepository.GetById(request.Id);
            return _mapper.Map<EmployeePositionDto>(request);
        }
    }
}
