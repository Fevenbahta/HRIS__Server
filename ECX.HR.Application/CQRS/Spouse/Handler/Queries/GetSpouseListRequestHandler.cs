﻿using AutoMapper;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.Spouse.Request.Queries;
using ECX.HR.Application.DTOs.Spouse;

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Spouse.Handler.Queries
{
    public class GetSpouseListRequestHandler : IRequestHandler<GetSpouseListRequest, List<SpouseDto>>
    {
        private ISpouseRepository _SpouseRepository;
        private IMapper _mapper;
        public GetSpouseListRequestHandler(ISpouseRepository SpouseRepository, IMapper mapper)
        {
            _SpouseRepository= SpouseRepository;
            _mapper = mapper;
        }
        public async Task<List<SpouseDto>> Handle(GetSpouseListRequest request, CancellationToken cancellationToken)
        {
            var Spouse =await _SpouseRepository.GetAll();
            return _mapper.Map<List<SpouseDto>>(Spouse);
        }
    }
}
