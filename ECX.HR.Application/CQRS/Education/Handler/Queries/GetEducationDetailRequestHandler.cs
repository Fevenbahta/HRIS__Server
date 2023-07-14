using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.Education.Request.Queries;
using ECX.HR.Application.DTOs.Education;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Education.Handler.Queries
{
    public class GetEducationDetailRequestHandler : IRequestHandler<GetEducationDetailRequest, EducationDto>
    {
        private IEducationRepository _EducationRepository;
        private IMapper _mapper;
        public GetEducationDetailRequestHandler(IEducationRepository EducationRepository, IMapper mapper)
        {
            _EducationRepository = EducationRepository;
            _mapper = mapper;
        }
        public async Task<EducationDto> Handle(GetEducationDetailRequest request, CancellationToken cancellationToken)
        {
            var Education =await _EducationRepository.GetById(request.Id);
            return _mapper.Map<EducationDto>(request);
        }
    }
}
