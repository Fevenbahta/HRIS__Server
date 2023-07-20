using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.Branch.Request.Queries;

using ECX.HR.Application.DTOs.Branchs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Branch.Handler.Queries
{
    public class GetBranchDetailRequestHandler : IRequestHandler<GetBranchDetailRequest, BranchDto>
    {
        private IBranchRepository _BranchRepository;
        private IMapper _mapper;
        public GetBranchDetailRequestHandler(IBranchRepository BranchRepository, IMapper mapper)
        {
            _BranchRepository = BranchRepository;
            _mapper = mapper;
        }
        public async Task<BranchDto> Handle(GetBranchDetailRequest request, CancellationToken cancellationToken)
        {
            var branch =await _BranchRepository.GetById(request.Id);
            return _mapper.Map<BranchDto>(branch);
        }
    }
}
