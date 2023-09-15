using ECX.HR.Application.DTOs.Addresss;
using ECX.HR.Application.DTOs.Department;
using ECX.HR.Application.DTOs.Division;
using ECX.HR.Application.DTOs.Education;
using ECX.HR.Application.DTOs.EmergencyContacts;
using ECX.HR.Application.DTOs.EmployeePositions;
using ECX.HR.Application.DTOs.Leave;
using ECX.HR.Application.DTOs.LeaveBalance;
using ECX.HR.Application.DTOs.Spouses;
using ECX.HR.Application.DTOs.Trainings;
using ECX.HR.Application.DTOs.WorkExperiences;
using ECX.HR.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.DTOs.Employees
{
    public class CombinedEmployeeDataDto
    {
        public EmployeeDto Employee { get; set; }
        public AddressDto Addresses { get; set; }
        public List<EmergencyContactDto> EmergencyContacts { get; set; }

        public List<SpouseDto> Spouse { get; set; }
        public EmployeePositionDto EmployeePostion { get; set; }
        public List<EducationDto> Education { get; set; }
        public List<TrainingDto> Training { get; set; }
        public List<LeaveRequestDto> LeaveRequest { get; set; }
        public AnnualLeaveBalanceDto AnnualLeaveBalance { get; set; }
        public OtherLeaveBalanceDto OtherLeaveBalanceDtos { get; set; }
        public List<WorkExperienceDto> WorkExperienceDtos { get; set; }

    }
}
