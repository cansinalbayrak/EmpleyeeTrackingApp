using EmployeeTrackingApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingApp.DAL.Mapping
{
    public class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        void IEntityTypeConfiguration<Employee>.Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(x => x.Photo).IsRequired(false);

            builder
                 .HasOne(e => e.SystemUser)
                 .WithOne(su => su.Employee)
                 .HasForeignKey<SystemUser>(su => su.EmployeeId);
            builder
                .HasOne(e => e.EmployeeProfile)
                .WithOne(su => su.Employee)
                .HasForeignKey<EmployeeProfile>(e => e.EmployeeId);
            builder
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentId);
            builder
               .HasOne(e => e.Seniority)
               .WithMany(d => d.Employees)
               .HasForeignKey(e => e.SeniorityId);

        }
    }
}
