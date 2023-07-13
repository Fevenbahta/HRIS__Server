﻿using AutoMapper;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.Branch.Request.Queries;
using ECX.HR.Application.DTOs.Branch;

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Branch.Handler.Queries
{
    public class GetBranchListRequestHandler : IRequestHandler<GetBranchListRequest, List<BranchDto>>
    {
        private IBranchRepository _BranchRepository;
        private IMapper _mapper;
        public GetBranchListRequestHandler(IBranchRepository BranchRepository, IMapper mapper)
        {
            _BranchRepository= BranchRepository;
            _mapper = mapper;
        }
        public async Task<List<BranchDto>> Handle(GetBranchListRequest request, CancellationToken cancellationToken)
        {
            var Branch =await _BranchRepository.GetAll();
            return _mapper.Map<List<BranchDto>>(Branch);
        }
    }
}
