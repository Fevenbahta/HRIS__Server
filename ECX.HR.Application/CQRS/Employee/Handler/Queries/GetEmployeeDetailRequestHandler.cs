using AutoMapper;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.Employee.Request.Queries;
using ECX.HR.Application.DTOs.Employee;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Employee.Handler.Queries
{
    public class GetEmployeeDetailRequestHandler : IRequestHandler<GetEmployeeDetailRequest, EmployeeDto>
    {
        private IEmployeeRepository _EmployeeRepository;
        private IMapper _mapper;
        public GetEmployeeDetailRequestHandler(IEmployeeRepository EmployeeRepository, IMapper mapper)
        {
            _EmployeeRepository = EmployeeRepository;
            _mapper = mapper;
        }
        public async Task<EmployeeDto> Handle(GetEmployeeDetailRequest request, CancellationToken cancellationToken)
        {
            var Employee =await _EmployeeRepository.GetById(request.Id);
            return _mapper.Map<EmployeeDto>(request);
        }
    }
}
