using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.CQRS.File.Request.Queries;
using ECX.HR.Application.DTOs.File;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.File.Handler.Queries
{
    public class GetFileListRequestHandler : IRequestHandler<GetFileListRequest, List<FileDto>>
    {
        private IFileRepository _FileRepository;
        private IMapper _mapper;
        public GetFileListRequestHandler(IFileRepository FileRepository, IMapper mapper)
        {
            _FileRepository= FileRepository;
            _mapper = mapper;
        }
        public async Task<List<FileDto>> Handle(GetFileListRequest request, CancellationToken cancellationToken)
        {
            var File =await _FileRepository.GetAll();
            var activeFile = File.Where(File => File.Status == 0).ToList();
            return _mapper.Map<List<FileDto>>(activeFile);
        }
    }
}
