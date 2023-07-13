using AutoMapper;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.Supervisor.Request.Queries;
using ECX.HR.Application.DTOs.Supervisor;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Supervisor.Handler.Queries
{
    public class GetSupervisorDetailRequestHandler : IRequestHandler<GetSupervisorDetailRequest, SupervisorDto>
    {
        private ISupervisorRepository _SupervisorRepository;
        private IMapper _mapper;
        public GetSupervisorDetailRequestHandler(ISupervisorRepository SupervisorRepository, IMapper mapper)
        {
            _SupervisorRepository = SupervisorRepository;
            _mapper = mapper;
        }
        public async Task<SupervisorDto> Handle(GetSupervisorDetailRequest request, CancellationToken cancellationToken)
        {
            var Supervisor =await _SupervisorRepository.GetById(request.Id);
            return _mapper.Map<SupervisorDto>(request);
        }
    }
}
