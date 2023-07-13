using AutoMapper;
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
    public class GetLevelDetailRequestHandler : IRequestHandler<GetLevelDetailRequest, LevelDto>
    {
        private ILevelRepository _LevelRepository;
        private IMapper _mapper;
        public GetLevelDetailRequestHandler(ILevelRepository LevelRepository, IMapper mapper)
        {
            _LevelRepository = LevelRepository;
            _mapper = mapper;
        }
        public async Task<LevelDto> Handle(GetLevelDetailRequest request, CancellationToken cancellationToken)
        {
            var Level =await _LevelRepository.GetById(request.Id);
            return _mapper.Map<LevelDto>(request);
        }
    }
}
