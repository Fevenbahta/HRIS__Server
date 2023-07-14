using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.Training.Request.Queries;

using ECX.HR.Application.DTOs.Trainings;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Training.Handler.Queries
{
    public class GetTrainingDetailRequestHandler : IRequestHandler<GetTrainingDetailRequest, TrainingDto>
    {
        private ITrainingRepository _TrainingRepository;
        private IMapper _mapper;
        public GetTrainingDetailRequestHandler(ITrainingRepository TrainingRepository, IMapper mapper)
        {
            _TrainingRepository = TrainingRepository;
            _mapper = mapper;
        }
        public async Task<TrainingDto> Handle(GetTrainingDetailRequest request, CancellationToken cancellationToken)
        {
            var Training =await _TrainingRepository.GetById(request.Id);
            return _mapper.Map<TrainingDto>(request);
        }
    }
}
