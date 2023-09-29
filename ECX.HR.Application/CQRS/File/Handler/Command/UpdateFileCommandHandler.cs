using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.CQRS.File.Request.Command;
using ECX.HR.Application.DTOs.File.Validator;
using ECX.HR.Application.Exceptions;

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.File.Handler.Command
{
    public class UpdateFileCommandHandler : IRequestHandler<UpdateFileCommand, Unit>
    {
        private IFileRepository _FileRepository;
        private IMapper _mapper;
        public UpdateFileCommandHandler(IFileRepository FileRepository, IMapper mapper)
        {
            _FileRepository = FileRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateFileCommand request, CancellationToken cancellationToken)
        {
            var validator = new FileValidator();
            var validationResult = await validator.ValidateAsync(request.FileDto);
            if (validationResult.IsValid == false)
                throw new ValidationException(validationResult);
            var File = await _FileRepository.GetById(request.FileDto.Id);
            _mapper.Map(request.FileDto, File);
            await _FileRepository.Update(File);
            return Unit.Value;
        }
    }
}
