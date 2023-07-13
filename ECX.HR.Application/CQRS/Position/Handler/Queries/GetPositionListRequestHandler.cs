using AutoMapper;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.Position.Request.Queries;
using ECX.HR.Application.DTOs.Position;

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Position.Handler.Queries
{
    public class GetPositionListRequestHandler : IRequestHandler<GetPositionListRequest, List<PositionDto>>
    {
        private IPositionRepository _PositionRepository;
        private IMapper _mapper;
        public GetPositionListRequestHandler(IPositionRepository PositionRepository, IMapper mapper)
        {
            _PositionRepository= PositionRepository;
            _mapper = mapper;
        }
        public async Task<List<PositionDto>> Handle(GetPositionListRequest request, CancellationToken cancellationToken)
        {
            var Position =await _PositionRepository.GetAll();
            return _mapper.Map<List<PositionDto>>(Position);
        }
    }
}
