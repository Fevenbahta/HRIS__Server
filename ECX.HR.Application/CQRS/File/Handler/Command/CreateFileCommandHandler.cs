using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.File.Request.Command;
using ECX.HR.Application.DTOs.File.Validator;
using ECX.HR.Application.Response;
using ECX.HR.Domain;
using MediatR;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.File.Handler.Command
{
    public class CreateFileCommandHandler : IRequestHandler<CreateFileCommand, BaseCommandResponse>
    {
        BaseCommandResponse response;
        private IFileRepository _FileRepository;
        private IMapper _mapper;
        public CreateFileCommandHandler(IFileRepository FileRepository, IMapper mapper)
        {
            _FileRepository = FileRepository;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(CreateFileCommand request, CancellationToken cancellationToken)
        {
            response = new BaseCommandResponse();
            var validator =new FileValidator();
            var validationResult =await validator.ValidateAsync(request.FileDto);
            
            if(validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Faild";
                response.Errors= validationResult.Errors.Select(x => x.ErrorMessage).ToList();
            }
           
            var File = _mapper.Map<Files>(request.FileDto);
            File.Id = Guid.NewGuid();
            var bra = File.Id;
            var data =await _FileRepository.Add(File);
            response.Success = true;
            response.Message = "Creation Successfull";
            response.Id = (Guid)bra;
            return response;
        }
    }
}
