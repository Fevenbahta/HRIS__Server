using AutoMapper;
using ECX.HR.Application.CQRS.File.Request.Command;
using ECX.HR.Application.Exceptions;
using ECX.HR.Application.Contracts.Persistent;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECX.HR.Application.Contracts.Persistence;


namespace ECX.HR.Application.CQRS.File.Handler.Command
{
    public class DeleteFileCommandHandler : IRequestHandler<DeleteFileCommand>
    {
        private IFileRepository _FileRepository;
        private IMapper _mapper;
        public DeleteFileCommandHandler(IFileRepository FileRepository, IMapper mapper)
        {
            _FileRepository = FileRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteFileCommand request, CancellationToken cancellationToken)
        {
            var File = await _FileRepository.GetById(request.Id);
            await _FileRepository.Delete(File);
            return Unit.Value;
        }

        async Task IRequestHandler<DeleteFileCommand>.Handle(DeleteFileCommand request, CancellationToken cancellationToken)
        {
            var File = await _FileRepository.GetById(request.Id);
            if(File == null) 
                throw new NotFoundException(nameof(File), request.Id);
            File.Status = 1;
            await _FileRepository.Update(File);
        }
    }
}
