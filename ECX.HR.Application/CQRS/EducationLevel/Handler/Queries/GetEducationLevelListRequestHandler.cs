﻿using AutoMapper;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.EducationLevel.Request.Queries;
using ECX.HR.Application.DTOs.EducationLevel;

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.EducationLevel.Handler.Queries
{
    public class GetEducationLevelListRequestHandler : IRequestHandler<GetEducationLevelListRequest, List<EducationLevelDto>>
    {
        private IEducationLevelRepository _EducationLevelRepository;
        private IMapper _mapper;
        public GetEducationLevelListRequestHandler(IEducationLevelRepository EducationLevelRepository, IMapper mapper)
        {
            _EducationLevelRepository= EducationLevelRepository;
            _mapper = mapper;
        }
        public async Task<List<EducationLevelDto>> Handle(GetEducationLevelListRequest request, CancellationToken cancellationToken)
        {
            var EducationLevel =await _EducationLevelRepository.GetAll();
            return _mapper.Map<List<EducationLevelDto>>(EducationLevel);
        }
    }
}
