using AutoMapper;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.Step.Request.Queries;
using ECX.HR.Application.DTOs.Step;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Step.Handler.Queries
{
    public class GetStepDetailRequestHandler : IRequestHandler<GetStepDetailRequest, StepDto>
    {
        private IStepRepository _StepRepository;
        private IMapper _mapper;
        public GetStepDetailRequestHandler(IStepRepository StepRepository, IMapper mapper)
        {
            _StepRepository = StepRepository;
            _mapper = mapper;
        }
        public async Task<StepDto> Handle(GetStepDetailRequest request, CancellationToken cancellationToken)
        {
            var Step =await _StepRepository.GetById(request.Id);
            return _mapper.Map<StepDto>(request);
        }
    }
}
