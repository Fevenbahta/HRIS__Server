using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.CQRS.File.Request.Queries;
using ECX.HR.Application.DTOs.File;
using ECX.HR.Application.Exceptions;
using ECX.HR.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.File.Handler.Queries
{
    public class GetFileDetailRequestHandler : IRequestHandler<GetFileDetailRequest, byte[]>
    {
        private IFileRepository _FileRepository;
        private IMapper _mapper;
        public GetFileDetailRequestHandler(IFileRepository FileRepository, IMapper mapper)
        {
            _FileRepository = FileRepository;
            _mapper = mapper;
        }
        public async Task<byte[]> Handle(GetFileDetailRequest request, CancellationToken cancellationToken)
        {
            var File =await _FileRepository.GetByFile(request.file);
            string base64String = File.FileData;
            byte[] fileData = Convert.FromBase64String(base64String);
            if (fileData == null || File.Status != 0)
                throw new NotFoundException(nameof(File), request.file);

            else
                return fileData;
        }
    }
}
