using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.PromotionRelation.Request.Queries;
using ECX.HR.Application.DTOs.PromotionRelation;
using ECX.HR.Application.Exceptions;
using ECX.HR.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.PromotionVacancy.Handler.Queries
{
    public class GetPromotionRelationDetailRequestHandler : IRequestHandler<GetPromotionRelationDetailRequest, PromotionRelationDto>
    {
        private IPromotionRelationRepository _PromotionVacancyRepository;
        private IMapper _mapper;
        public GetPromotionRelationDetailRequestHandler(IPromotionRelationRepository PromotionVacancyRepository, IMapper mapper)
        {
            _PromotionVacancyRepository = PromotionVacancyRepository;
            _mapper = mapper;
        }
        public async Task<PromotionRelationDto> Handle(GetPromotionRelationDetailRequest request, CancellationToken cancellationToken)
        {
            var PromotionVacancy =await _PromotionVacancyRepository.GetByEmpId(request.empId);

            if (PromotionVacancy == null || !PromotionVacancy.Any(we => we.Status == 0))
                throw new NotFoundException(nameof(PromotionVacancy), request.empId);

            else
                return _mapper.Map<PromotionRelationDto>(PromotionVacancy);
        }
    }
}
