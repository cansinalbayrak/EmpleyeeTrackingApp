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
    public class PayrollMap : IEntityTypeConfiguration<Payroll>
    {
        void IEntityTypeConfiguration<Payroll>.Configure(EntityTypeBuilder<Payroll> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.SalaryAmount).HasPrecision(6, 2).IsRequired(true);
            builder
               .HasOne(x => x.Employee)
               .WithMany(x => x.Payrolls)
               .HasForeignKey(x => x.EmployeeId);



        }
    }
}
