﻿using AutoMapper;
using ECX.HR.Application.CQRS.Division.Request.Command;
using ECX.HR.Application.Exceptions;
using ECX.HR.Application.Contracts.Persistent;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Division.Handler.Command
{
    public class DeleteDivisionCommandHandler : IRequestHandler<DeleteDivisionCommand>
    {
        private IDivisionRepository _DivisionRepository;
        private IMapper _mapper;
        public DeleteDivisionCommandHandler(IDivisionRepository DivisionRepository, IMapper mapper)
        {
            _DivisionRepository = DivisionRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteDivisionCommand request, CancellationToken cancellationToken)
        {
            var Division = await _DivisionRepository.GetById(request.Id);
            await _DivisionRepository.Delete(Division);
            return Unit.Value;
        }

        async Task IRequestHandler<DeleteDivisionCommand>.Handle(DeleteDivisionCommand request, CancellationToken cancellationToken)
        {
            var Division = await _DivisionRepository.GetById(request.Id);
            if(Division == null) 
                throw new NotFoundException(nameof(Division), request.Id);
            await _DivisionRepository.Delete(Division);
        }
    }
}
