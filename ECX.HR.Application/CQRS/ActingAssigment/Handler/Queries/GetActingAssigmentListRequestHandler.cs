using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.CQRS.ActingAssigment.Request.Queries;
using ECX.HR.Application.DTOs.ActingAssigment;
using ECX.HR.Application.DTOs.Addresss;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.ActingAssigment.Handler.Queries
{
    public class GetActingAssigmentListRequestHandler : IRequestHandler<GetAcctingAssigmentListRequest, List<ActingAssigmentDto>>
    {
        private readonly IActingAssigmentRepository _actingAssigmentRepository;
        private readonly IMapper _mapper;

        public GetActingAssigmentListRequestHandler()
        {
        }

        public GetActingAssigmentListRequestHandler(IActingAssigmentRepository actingAssigmentRepository, IMapper Mapper)
        {
            _actingAssigmentRepository = actingAssigmentRepository;
            _mapper = Mapper;
        }
        public async Task<List<ActingAssigmentDto>> Handle(GetAcctingAssigmentListRequest request, CancellationToken cancellationToken)
        {
            var acting = await _actingAssigmentRepository.GetAll();

            var actings = acting.Where(acting => acting.Status == 0).ToList();

            return _mapper.Map<List<ActingAssigmentDto>>(actings);
        }
    }
}
