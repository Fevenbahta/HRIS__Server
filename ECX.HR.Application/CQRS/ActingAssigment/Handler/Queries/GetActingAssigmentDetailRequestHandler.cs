using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.CQRS.ActingAssigment.Request.Queries;
using ECX.HR.Application.DTOs.ActingAssigment;
using ECX.HR.Application.DTOs.Addresss;
using ECX.HR.Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.ActingAssigment.Handler.Queries
{
    public class GetActingAssigmentDetailRequestHandler : IRequestHandler<GetAcctingAssigmentDetailRequest, ActingAssigmentDto>
    {
        private readonly IActingAssigmentRepository _actingAssigmentRepository;
        private readonly IMapper _mapper;

        public GetActingAssigmentDetailRequestHandler(IActingAssigmentRepository ActingAssigmentRepository, IMapper Mapper)
        {
            _actingAssigmentRepository = ActingAssigmentRepository;
            _mapper = Mapper;
        }
        public async Task<ActingAssigmentDto> Handle(GetAcctingAssigmentDetailRequest request, CancellationToken cancellationToken)
        {
            var Acting = await _actingAssigmentRepository.GetById(request.Id);

            if (Acting == null || Acting.Status != 0)
                throw new NotFoundException(nameof(Acting), request.Id);

            return _mapper.Map<ActingAssigmentDto>(Acting);
        }
    }
}
