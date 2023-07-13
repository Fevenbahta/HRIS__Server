﻿using AutoMapper;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.Level.Request.Queries;
using ECX.HR.Application.DTOs.Level;

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Level.Handler.Queries
{
    public class GetLevelListRequestHandler : IRequestHandler<GetLevelListRequest, List<LevelDto>>
    {
        private ILevelRepository _LevelRepository;
        private IMapper _mapper;
        public GetLevelListRequestHandler(ILevelRepository LevelRepository, IMapper mapper)
        {
            _LevelRepository= LevelRepository;
            _mapper = mapper;
        }
        public async Task<List<LevelDto>> Handle(GetLevelListRequest request, CancellationToken cancellationToken)
        {
            var Level =await _LevelRepository.GetAll();
            return _mapper.Map<List<LevelDto>>(Level);
        }
    }
}
