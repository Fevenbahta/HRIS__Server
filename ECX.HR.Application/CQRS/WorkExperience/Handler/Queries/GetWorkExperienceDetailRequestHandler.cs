using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;

using ECX.HR.Application.CQRS.WorkExperience.Request.Queries;

using ECX.HR.Application.DTOs.WorkExperiences;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.WorkExperience.Handler.Queries
{
    public class GetWorkExperienceDetailRequestHandler : IRequestHandler<GetWorkExperienceDetailRequest, WorkExperienceDto>
    {
        private IWorkExperienceRepository _WorkExperienceRepository;
        private IMapper _mapper;
        public GetWorkExperienceDetailRequestHandler(IWorkExperienceRepository WorkExperienceRepository, IMapper mapper)
        {
            _WorkExperienceRepository = WorkExperienceRepository;
            _mapper = mapper;
        }
        public async Task<WorkExperienceDto> Handle(GetWorkExperienceDetailRequest request, CancellationToken cancellationToken)
        {
            var WorkExperience =await _WorkExperienceRepository.GetById(request.Id);
            return _mapper.Map<WorkExperienceDto>(request);
        }
    }
}
