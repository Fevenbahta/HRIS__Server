﻿using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.CQRS.LeaveRequest.Request.Command;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.LeaveRequest.Handler.Command
{
    public class GetFileRequestCommandhandler : IRequestHandler<GetFileRequestCommand, byte[]>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public GetFileRequestCommandhandler(ILeaveRequestRepository leaveRequestRepository, IMapper Mapper)
        {
          _leaveRequestRepository = leaveRequestRepository;
            _mapper = Mapper;
        }

        public async Task<byte[]> Handle(GetFileRequestCommand request, CancellationToken cancellationToken)
        {
            try
            {
                // Assuming you have an entity representing files in your database
                var fileEntity = await _leaveRequestRepository.GetById(request.LeaveRequestId);
               
                if (fileEntity != null)
                {
                    string base64String = fileEntity.File;  
                    byte[] fileData = Convert.FromBase64String(base64String);
                    // Retrieve the file data (byte array) from the database entity
                   // string uniqueFileName = Guid.NewGuid().ToString() + ".pdf";

             
                    return fileData;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions related to database access
                // Logging, error handling, etc.
            }

            // Return null if the file is not found or an error occurs
            return null;
        }
    }
}
