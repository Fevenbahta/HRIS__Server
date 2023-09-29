using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.File.Request.Command
{
    public class DeleteFileCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
