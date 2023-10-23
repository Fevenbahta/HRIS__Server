using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.CQRS.Attendance.Request.Command;
using ECX.HR.Application.CQRS.Attendance.Request.Command;
using ECX.HR.Application.DTOs.Attendance.Validator;

using ECX.HR.Application.Exceptions;

using ECX.HR.Application.Response;
using ECX.HR.Domain;
using MediatR;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Attendance.Handler.Command
{
    public class CreateAttendanceCommandHandler : IRequestHandler<CreateAttendanceCommand, BaseCommandResponse>
    {
        BaseCommandResponse response;
        private IAttendanceRepository _AttendanceRepository;
        private IMapper _mapper;
        public CreateAttendanceCommandHandler(IAttendanceRepository AttendanceRepository, IMapper mapper)
        {
            _AttendanceRepository = AttendanceRepository;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(CreateAttendanceCommand request, CancellationToken cancellationToken)
        {
            response = new BaseCommandResponse();
            var validator =new AttendanceDtoValidator();
            var validationResult =await validator.ValidateAsync(request.AttendanceDto);
            
            if(validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Faild";
                response.Errors= validationResult.Errors.Select(x => x.ErrorMessage).ToList();
            }
           
            var Attendance = _mapper.Map<Attendances>(request.AttendanceDto);
         
            var data =await _AttendanceRepository.Add(Attendance);
            response.Success = true;
            response.Message = "Creation Successfull";
            return response;
        }
    }
}
