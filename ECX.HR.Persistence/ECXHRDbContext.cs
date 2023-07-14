﻿using ECX.HR.Domain;
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

            modelBuilder.Entity<Employee>()
            .HasMany(e => e.WorkExperiences)
            .WithOne(ex => ex.Employees)
            .HasForeignKey(e => e.EmpId);

            modelBuilder.Entity<Employee>()
            .HasMany(e => e.Educations)
            .WithOne(ex => ex.Employees)
            .HasForeignKey(e => e.EmpId);

            modelBuilder.Entity<Employee>()
            .HasMany(e => e.Trainings)
            .WithOne(ex => ex.Employees)
            .HasForeignKey(e => e.EmpId);

            modelBuilder.Entity<Employee>()
           .HasMany(e => e.EmergencyContacts)
           .WithOne(ex => ex.Employees)
           .HasForeignKey(e => e.EmpId);


            modelBuilder.Entity<Employee>()
            .HasMany(e => e.Spouses)
            .WithOne(ex => ex.Employees)
            .HasForeignKey(e => e.EmpId);

            modelBuilder.Entity<Department>()
            .HasMany(e => e.Divisions)
            .WithOne(ex => ex.Departments)
            .HasForeignKey(e => e.DepartmentId);

            modelBuilder.Entity<Division>()
            .HasMany(e => e.Positions)
            .WithOne(ex => ex.Divisions)
            .HasForeignKey(e => e.DivisionId);

            modelBuilder.Entity<Level>()
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
        public DbSet<Adress> adress { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Allowance> allowance { get; set; }
        public DbSet<Branch> branch { get; set; }
        public DbSet<DepositAutorization> depositAutorizations { get; set; }
        public DbSet<Division> division { get; set; }
        public DbSet<Education> education { get; set; }
        public DbSet<EducationLevel> eduactionLevel { get; set; }
        public DbSet<EmergencyContact> emergencyContact { get; set; }
        public DbSet<Employee> employee { get; set; }
        public DbSet<EmployeePosition> employeePosition { get; set; }
        public DbSet<EmployeeStatus> emploeeStatus { get; set; }
        public DbSet<Level> level { get; set; }
        public DbSet<Position> job { get; set; }
       
        public DbSet<Salary> salary { get; set; }
        public DbSet<Spouses> spouse { get; set; }
        public DbSet<Steps> step { get; set; }
        public DbSet<Supervisors> supervisor { get; set; }
        public DbSet<Trainings> training { get; set; }
        public DbSet<WorkExperiences> WorkExperiences { get; set; }

    }
}
