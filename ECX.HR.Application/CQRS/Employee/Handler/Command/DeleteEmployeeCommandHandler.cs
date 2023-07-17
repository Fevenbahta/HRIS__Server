using AutoMapper;
using ECX.HR.Application.CQRS.Employee.Request.Command;
using ECX.HR.Application.Exceptions;
using ECX.HR.Application.Contracts.Persistent;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECX.HR.Application.Contracts.Persistence;

namespace ECX.HR.Application.CQRS.Employee.Handler.Command
{
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand>
    {
        private IEmployeeRepository _EmployeeRepository;
        private IMapper _mapper;
        public DeleteEmployeeCommandHandler(IEmployeeRepository EmployeeRepository, IMapper mapper)
        {
            _EmployeeRepository = EmployeeRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var Employee = await _EmployeeRepository.GetById(request.EmpId);
            await _EmployeeRepository.Delete(Employee);
            return Unit.Value;
        }

        async Task IRequestHandler<DeleteEmployeeCommand>.Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var Employee = await _EmployeeRepository.GetById(request.EmpId);
            if(Employee == null) 
                throw new NotFoundException(nameof(Employee), request.EmpId);
            await _EmployeeRepository.Delete(Employee);
        }
    }
}
