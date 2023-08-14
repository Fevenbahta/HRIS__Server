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
        private IAdressRepository _AddressRepository; 
         private IEmergencyContactRepository  _EmergencyContactRepository;
        private ISpouseRepository _SpouseRepository;
        IEducationRepository _EducationRepository;
        private IWorkExperienceRepository _WorkExperienceRepository;
        private IDepositAutorizationRepository _DepositAutorizationRepository;
        private IEmployeePositionRepository _EmployeePositionRepository;
        private ITrainingRepository _TrainingRepository;

        private IMapper _mapper;
        public DeleteEmployeeCommandHandler(IEmployeeRepository EmployeeRepository, 
            IAdressRepository AddressRepository,
            IEmergencyContactRepository EmergencyContactRepository, 
            ISpouseRepository SpouseRepository, 
            IEducationRepository EducationRepository,
            IWorkExperienceRepository WorkExperienceRepository,
            IDepositAutorizationRepository DepositAutorizationRepository,
            IEmployeePositionRepository EmployeePositionRepository,
            ITrainingRepository TrainingRepository,

            IMapper mapper)
        {
            _EmployeeRepository = EmployeeRepository;
            _AddressRepository= AddressRepository;
            _EmergencyContactRepository = EmergencyContactRepository;
            _SpouseRepository = SpouseRepository;
            _EducationRepository = EducationRepository;
            _WorkExperienceRepository = WorkExperienceRepository;
            _DepositAutorizationRepository = DepositAutorizationRepository;
            _EmployeePositionRepository = EmployeePositionRepository;
            _TrainingRepository = TrainingRepository;

            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var Employee = await _EmployeeRepository.GetById(request.EmpId);
            Employee.Status = 1;

            await _EmployeeRepository.Update(Employee);


            var address = await _AddressRepository.GetByEmpId(request.EmpId);
            // Assuming '1' represents the 'Deleted' status
            address.Status = 1;

            await _AddressRepository.Update(address);

            var EmergencyContact = await _EmergencyContactRepository.GetByEmpId(request.EmpId);
            foreach (var emergencyContact in EmergencyContact)
            {
                emergencyContact.Status = 1;
                await _EmergencyContactRepository.Update(emergencyContact);
            }

       


            var Spouse = await _SpouseRepository.GetByEmpId(request.EmpId);
            foreach (var spouse in Spouse)
            {
                spouse.Status = 1;
                await _SpouseRepository.Update(spouse);
            }

            var Education = await _EducationRepository.GetByEmpId(request.EmpId);
            foreach (var education in Education)
            {
                education.Status = 1;
                await _EducationRepository.Update(education);
            }

            var WorkExperience = await _WorkExperienceRepository.GetByEmpId(request.EmpId);
            foreach (var workExperience in WorkExperience)
            {
                workExperience.Status = 1;
                await _WorkExperienceRepository.Update(workExperience);
            }

            var DepositAutorization = await _DepositAutorizationRepository.GetByEmpId(request.EmpId);
            DepositAutorization.Status = 1;
            await _DepositAutorizationRepository.Update(DepositAutorization);

            var EmployeePosition = await _EmployeePositionRepository.GetByEmpId(request.EmpId);
            EmployeePosition.Status = 1;
            await _EmployeePositionRepository.Update(EmployeePosition);

            var Training = await _TrainingRepository.GetByEmpId(request.EmpId);
            foreach (var training in Training)
            {
                training.Status = 1;
                await _TrainingRepository.Update(training);
}
                return Unit.Value;
            
        }

        async Task IRequestHandler<DeleteEmployeeCommand>.Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var Employee = await _EmployeeRepository.GetById(request.EmpId);
            if (Employee == null) 
                throw new NotFoundException(nameof(Employee), request.EmpId);
            Employee.Status = 1;
            await _EmployeeRepository.Update(Employee);

            var address = await _AddressRepository.GetByEmpId(request.EmpId);

            if (address == null)
                throw new NotFoundException(nameof(address), request.EmpId);
            address.Status = 1;

            await _AddressRepository.Update(address);


            var EmergencyContact = await _EmergencyContactRepository.GetByEmpId(request.EmpId);
            if (EmergencyContact == null)
                throw new NotFoundException(nameof(EmergencyContact), request.EmpId);
            foreach (var emergencyContact in EmergencyContact)
            {
                emergencyContact.Status = 1;
                await _EmergencyContactRepository.Update(emergencyContact);
            }



            var Spouse = await _SpouseRepository.GetByEmpId(request.EmpId);
            if (Spouse == null)
                throw new NotFoundException(nameof(Spouse), request.EmpId);
            foreach (var spouse in Spouse)
            {
                spouse.Status = 1;
                await _SpouseRepository.Update(spouse);
            }

            var Education = await _EducationRepository.GetByEmpId(request.EmpId);
            if (Education == null)
                throw new NotFoundException(nameof(Education), request.EmpId);
            foreach (var education in Education)
            {
                education.Status = 1;
                await _EducationRepository.Update(education);
            }

            var WorkExperience = await _WorkExperienceRepository.GetByEmpId(request.EmpId);
            if (WorkExperience == null)
                throw new NotFoundException(nameof(WorkExperience), request.EmpId);
            foreach (var workExperience in WorkExperience)
            {
                workExperience.Status = 1;
                await _WorkExperienceRepository.Update(workExperience);
            }

            var DepositAutorization = await _DepositAutorizationRepository.GetByEmpId(request.EmpId);
            if (DepositAutorization == null)
                throw new NotFoundException(nameof(DepositAutorization), request.EmpId);
            DepositAutorization.Status = 1;
            await _DepositAutorizationRepository.Update(DepositAutorization);

            var EmployeePosition = await _EmployeePositionRepository.GetByEmpId(request.EmpId);
            if (EmployeePosition == null)
                throw new NotFoundException(nameof(EmployeePosition), request.EmpId);
            EmployeePosition.Status = 1;
            await _EmployeePositionRepository.Update(EmployeePosition);

            var Training = await _TrainingRepository.GetByEmpId(request.EmpId);
            if (Training == null)
                throw new NotFoundException(nameof(Training), request.EmpId);

            foreach (var training in Training)
            {
                training.Status = 1;
                await _TrainingRepository.Update(training);

              
            }



        }
    }
}
