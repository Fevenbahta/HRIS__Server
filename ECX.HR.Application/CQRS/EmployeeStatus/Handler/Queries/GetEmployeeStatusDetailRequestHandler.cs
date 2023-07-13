using AutoMapper;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.EmployeeStatus.Request.Queries;
using ECX.HR.Application.DTOs.EmployeeStatus;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.EmployeeStatus.Handler.Queries
{
    public class GetEmployeeStatusDetailRequestHandler : IRequestHandler<GetEmployeeStatusDetailRequest, EmployeeStatusDto>
    {
        private IEmployeeStatusRepository _EmployeeStatusRepository;
        private IMapper _mapper;
        public GetEmployeeStatusDetailRequestHandler(IEmployeeStatusRepository EmployeeStatusRepository, IMapper mapper)
        {
            _EmployeeStatusRepository = EmployeeStatusRepository;
            _mapper = mapper;
        }
        public async Task<EmployeeStatusDto> Handle(GetEmployeeStatusDetailRequest request, CancellationToken cancellationToken)
        {
            var EmployeeStatus =await _EmployeeStatusRepository.GetById(request.Id);
            return _mapper.Map<EmployeeStatusDto>(request);
        }
    }
}
