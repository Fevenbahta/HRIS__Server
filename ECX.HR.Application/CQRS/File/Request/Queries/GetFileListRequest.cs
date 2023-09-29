
using ECX.HR.Application.DTOs.File;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.File.Request.Queries
{
    public class GetFileListRequest :IRequest<List<FileDto>>
    {
       
    }
}
