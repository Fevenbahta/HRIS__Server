using ECX.HR.Domain;
using ECX.HR.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Persistence
{
    public class ECXHRDbContext :DbContext    
    {
        public ECXHRDbContext(DbContextOptions<ECXHRDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ECXHRDbContext).Assembly);

            modelBuilder.Entity<Employees>()
            .HasMany(e => e.WorkExperiences)
            .WithOne(ex => ex.Employees)
            .HasForeignKey(e => e.EmpId);

            modelBuilder.Entity<Employees>()
            .HasMany(e => e.Educations)
            .WithOne(ex => ex.Employees)
            .HasForeignKey(e => e.EmpId);

            modelBuilder.Entity<Employees>()
            .HasMany(e => e.Trainings)
            .WithOne(ex => ex.Employees)
            .HasForeignKey(e => e.EmpId);

            modelBuilder.Entity<Employees>()
           .HasMany(e => e.EmergencyContacts)
           .WithOne(ex => ex.Employees)
           .HasForeignKey(e => e.EmpId);


            modelBuilder.Entity<Employees>()
            .HasMany(e => e.Spouses)
            .WithOne(ex => ex.Employees)
            .HasForeignKey(e => e.EmpId);

            modelBuilder.Entity<Department>()
            .HasMany(e => e.Divisions)
            .WithOne(ex => ex.Departments)
            .HasForeignKey(e => e.DepartmentId);

            modelBuilder.Entity<Divisions>()
            .HasMany(e => e.Positions)
            .WithOne(ex => ex.Divisions)
            .HasForeignKey(e => e.DivisionId);

            modelBuilder.Entity<Levels>()
            .HasMany(e => e.Steps)
            .WithOne(ex => ex.Levels)
            .HasForeignKey(e => e.LevelId);






            //  modelBuilder.Entity<Employee>()
            //.HasRequired<WorkExperience>(s => s.WorkExperiences)
            //.WithMany(g => g.WorkExperiences)
            //.HasForeignKey<int>(s => s.EmpId);

        }
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            foreach (var entity in ChangeTracker.Entries<BaseDomainEntity>())
            {
                entity.Entity.UpdatedDate = DateTime.Now;
                if(entity.State ==EntityState.Added)
                {
                    entity.Entity.CreatedDate = DateTime.Now;
                }
            }
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
        public DbSet<Adress> Adress { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Allowancee> Allowance { get; set; }
        public DbSet<Branches> Branch { get; set; }
        public DbSet<DepositAutorizations> DepositAutorizations { get; set; }
        public DbSet<Divisions> Division { get; set; }
        public DbSet<Educations> Education { get; set; }
        public DbSet<EducationLevels> EduactionLevel { get; set; }
        public DbSet<EmergencyContacts> EmergencyContact { get; set; }
        public DbSet<Employees> Employee { get; set; }
        public DbSet<EmployeePositions> EmployeePosition { get; set; }
        public DbSet<EmployeeStatuss> EmploeeStatus { get; set; }
        public DbSet<Levels> Level { get; set; }
        public DbSet<Positions> Job { get; set; }
       
        public DbSet<SalaryTypes> SalaryType { get; set; }
        public DbSet<Spouses> Spouse { get; set; }
        public DbSet<Steps> Step { get; set; }
        public DbSet<Supervisors> Supervisor { get; set; }
        public DbSet<Trainings> Training { get; set; }
        public DbSet<WorkExperiences> WorkExperiences { get; set; }

    }
}
