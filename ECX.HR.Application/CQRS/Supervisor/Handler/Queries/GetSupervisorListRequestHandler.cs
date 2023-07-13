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
    public class GetSupervisorListRequestHandler : IRequestHandler<GetSupervisorListRequest, List<SupervisorDto>>
    {
        private ISupervisorRepository _SupervisorRepository;
        private IMapper _mapper;
        public GetSupervisorListRequestHandler(ISupervisorRepository SupervisorRepository, IMapper mapper)
        {
            _SupervisorRepository= SupervisorRepository;
            _mapper = mapper;
        }
        public async Task<List<SupervisorDto>> Handle(GetSupervisorListRequest request, CancellationToken cancellationToken)
        {
            var Supervisor =await _SupervisorRepository.GetAll();
            return _mapper.Map<List<SupervisorDto>>(Supervisor);
        }
    }
}
