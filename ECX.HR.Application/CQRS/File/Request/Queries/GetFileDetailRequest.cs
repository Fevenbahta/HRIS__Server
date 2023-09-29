
using ECX.HR.Application.DTOs.Branchs;
using ECX.HR.Application.DTOs.File;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.File.Request.Queries
{
    public class GetFileDetailRequest :IRequest<byte[]>
    {
        public string file  { get; set; }
        public Guid id { get; }
    }
}
