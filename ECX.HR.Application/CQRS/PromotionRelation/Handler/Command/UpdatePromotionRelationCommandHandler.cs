using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.CQRS.PromotionRelation.Request.Command;
using ECX.HR.Application.DTOs.PromotionRelation.Validator;
using ECX.HR.Application.Exceptions;

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.PromotionRelation.Handler.Command
{
    public class UpdatePromotionRelationCommandHandler : IRequestHandler<UpdatePromotionRelationCommand, Unit>
    {
        private IPromotionRelationRepository _PromotionRelationRepository;
        private IMapper _mapper;
        public UpdatePromotionRelationCommandHandler(IPromotionRelationRepository PromotionRelationRepository, IMapper mapper)
        {
            _PromotionRelationRepository = PromotionRelationRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdatePromotionRelationCommand request, CancellationToken cancellationToken)
        {
            var validator = new PromotionRelationDtoValidator();
            var validationResult = await validator.ValidateAsync(request.PromotionRelationDto);
            if (validationResult.IsValid == false)
                throw new ValidationException(validationResult);
            var PromotionRelation = await _PromotionRelationRepository.GetById(request.PromotionRelationDto.Id);
            _mapper.Map(request.PromotionRelationDto, PromotionRelation);
            await _PromotionRelationRepository.Update(PromotionRelation);
            return Unit.Value;
        }
    }
}
