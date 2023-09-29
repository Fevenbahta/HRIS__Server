
using ECX.HR.Application.DTOs.Branchs;
using ECX.HR.Application.DTOs.File;
using ECX.HR.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.File.Request.Command
{
    public class CreateFileCommand : IRequest<BaseCommandResponse>
    {
        public FileDto FileDto { get; set; }
    }
}
