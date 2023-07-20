using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.Salary.Request.Queries;
using ECX.HR.Application.DTOs.Salaries;

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Salary.Handler.Queries
{
    public class GetSalaryDetailRequestHandler : IRequestHandler<GetSalaryDetailRequest, SalaryTypeDto>
    {
        private ISalaryRepository _SalaryRepository;
        private IMapper _mapper;
        public GetSalaryDetailRequestHandler(ISalaryRepository SalaryRepository, IMapper mapper)
        {
            _SalaryRepository = SalaryRepository;
            _mapper = mapper;
        }
        public async Task<SalaryTypeDto> Handle(GetSalaryDetailRequest request, CancellationToken cancellationToken)
        {
            var salary =await _SalaryRepository.GetById(request.Id);
            return _mapper.Map<SalaryTypeDto>(salary);
        }
    }
}
