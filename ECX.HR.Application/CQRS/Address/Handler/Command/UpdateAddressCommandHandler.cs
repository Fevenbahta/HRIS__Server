using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.Addresss.Request.Command;
using ECX.HR.Application.DTOs.Addresss.Validator;
using ECX.HR.Application.Exceptions;

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Addresss.Handler.Command
{
    public class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommand, Unit>
    {
        private IAdressRepository _AddressRepository;
        private IMapper _mapper;
        public UpdateAddressCommandHandler(IAdressRepository AddressRepository, IMapper mapper)
        {
            _AddressRepository = AddressRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateAddressCommand request, CancellationToken cancellationToken)
        {
            var validator = new AdressDtoValidator();
            var validationResult = await validator.ValidateAsync(request.AddressDto);
            if (validationResult.IsValid == false)
                throw new ValidationException(validationResult);
            var Address = await _AddressRepository.GetById(request.AddressDto.Id);
            _mapper.Map(request.AddressDto, Address);
            await _AddressRepository.Update(Address);
            return Unit.Value;
        }
    }
}
