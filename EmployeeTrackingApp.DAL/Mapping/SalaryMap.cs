using EmployeeTrackingApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingApp.DAL.Mapping
{
    public class SalaryMap : IEntityTypeConfiguration<Salary>
    {
        void IEntityTypeConfiguration<Salary>.Configure(EntityTypeBuilder<Salary> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Amount).HasPrecision(6, 2).IsRequired(true);
            builder
               .HasOne(x => x.Employee)
               .WithMany(x => x.Salaries)
               .HasForeignKey(x => x.EmployeeId);

        }
    }
}
