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
            modelBuilder.Entity<Adress>().Property(c => c.PId).UseIdentityColumn().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<Allowancee>().Property(c => c.PId).UseIdentityColumn().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<Branches>().Property(c => c.PId).UseIdentityColumn().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<Department>().Property(c => c.PId).UseIdentityColumn().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<DepositAutorizations>().Property(c => c.PId).UseIdentityColumn().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<Divisions>().Property(c => c.PId).UseIdentityColumn().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<EducationLevels>().Property(c => c.PId).UseIdentityColumn().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<Educations>().Property(c => c.PId).UseIdentityColumn().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<EmergencyContacts>().Property(c => c.PId).UseIdentityColumn().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<EmployeePositions>().Property(c => c.PId).UseIdentityColumn().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<Employees>().Property(c => c.PId).UseIdentityColumn().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<EmployeeStatuss>().Property(c => c.PId).UseIdentityColumn().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<Levels>().Property(c => c.PId).UseIdentityColumn().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<OrganizationalProfiles>().Property(c => c.PId).UseIdentityColumn().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<Positions>().Property(c => c.PId).UseIdentityColumn().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<SalaryTypes>().Property(c => c.PId).UseIdentityColumn().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<Spouses>().Property(c => c.PId).UseIdentityColumn().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<Steps>().Property(c => c.PId).UseIdentityColumn().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<Supervisors>().Property(c => c.PId).UseIdentityColumn().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<Trainings>().Property(c => c.PId).UseIdentityColumn().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<WorkExperiences>().Property(c => c.PId).UseIdentityColumn().ValueGeneratedOnAddOrUpdate();
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(BaseDomainEntity).IsAssignableFrom(entityType.ClrType))
                {
                    modelBuilder.Entity(entityType.ClrType)
                        .Property(nameof(BaseDomainEntity.CreatedDate))
                        .HasDefaultValue(DateTime.UtcNow);

                    modelBuilder.Entity(entityType.ClrType)
                        .Property(nameof(BaseDomainEntity.UpdatedDate))
                        .HasDefaultValue(DateTime.UtcNow);
                }
            }

            modelBuilder.Entity<Employees>()
            .HasMany(e => e.WorkExperiences)
            .WithOne(ex => ex.Employees)
            .HasForeignKey(e => e.EmpId)
             .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Employees>()
            .HasMany(e => e.Educations)
            .WithOne(ex => ex.Employees)
            .HasForeignKey(e => e.EmpId)
              .OnDelete(DeleteBehavior.Cascade); ;

            modelBuilder.Entity<Employees>()
            .HasMany(e => e.Trainings)
            .WithOne(ex => ex.Employees)
            .HasForeignKey(e => e.EmpId)
              .OnDelete(DeleteBehavior.Cascade); ;

            modelBuilder.Entity<Employees>()
           .HasMany(e => e.EmergencyContacts)
           .WithOne(ex => ex.Employees)
           .HasForeignKey(e => e.EmpId)
             .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Employees>()
            .HasMany(e => e.Spouses)
            .WithOne(ex => ex.Employees)
            .HasForeignKey(e => e.EmpId)
              .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Department>()
            .HasMany(e => e.Divisions)
            .WithOne(ex => ex.Departments)
            .HasForeignKey(e => e.DepartmentId)
              .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Divisions>()
            .HasMany(e => e.Positions)
            .WithOne(ex => ex.Divisions)
            .HasForeignKey(e => e.DivisionId)
              .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Levels>()
            .HasMany(e => e.Steps)
            .WithOne(ex => ex.Levels)
            .HasForeignKey(e => e.LevelId)
              .OnDelete(DeleteBehavior.Cascade);



            modelBuilder.Entity<Steps>()
            .Property(p => p.Salary)
            .HasColumnType("decimal(18,8)");



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
       public DbSet<OrganizationalProfiles> OrganizationalProfile { get; set; }
        public DbSet<Positions> Job { get; set; }
       
        public DbSet<SalaryTypes> SalaryType { get; set; }
        public DbSet<Spouses> Spouse { get; set; }
        public DbSet<Steps> Step { get; set; }
        public DbSet<Supervisors> Supervisor { get; set; }
        public DbSet<Trainings> Training { get; set; }
        public DbSet<WorkExperiences> WorkExperiences { get; set; }

    }
}
