using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.CQRS.LeaveBalance.Request.Command;
using ECX.HR.Application.CQRS.LeaveBalance.Request.Queries;
using ECX.HR.Application.DTOs.LeaveBalance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.LeaveBalance.Handler.Queries
{
    public class GetLeaveBalanceListRequestHandler : IRequestHandler<GetLeaveBalanceListRequest, List<AnnualLeaveBalanceDto>>
    {
        private ILeaveBalanceRepository _LeaveBalanceRepository;
        private IMapper _mapper;
        public GetLeaveBalanceListRequestHandler(ILeaveBalanceRepository LeaveBalanceRepository, IMapper mapper)
        {
            _LeaveBalanceRepository = LeaveBalanceRepository;
            _mapper = mapper;
        }
        public async Task<List<AnnualLeaveBalanceDto>> Handle(GetLeaveBalanceListRequest request, CancellationToken cancellationToken)
        {
            var leaveBalances = await _LeaveBalanceRepository.GetAll();

            var activeLeaveBalances = leaveBalances.Where(leaveBalance => leaveBalance.Status == 0).ToList();


         

           

            return _mapper.Map<List<AnnualLeaveBalanceDto>>(activeLeaveBalances);
        }
    }
}