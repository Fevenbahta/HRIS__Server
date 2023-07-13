using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.OrganizationalProfile.Request.Command
{
    public class DeleteOrganizationalProfileCommand : IRequest
    {
        public int Id { get; set; }
    }
}
