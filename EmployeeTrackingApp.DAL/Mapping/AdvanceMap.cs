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
    public class AdvanceMap : IEntityTypeConfiguration<Advance>
    {
        void IEntityTypeConfiguration<Advance>.Configure(EntityTypeBuilder<Advance> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Amount).HasPrecision(9, 3).IsRequired(true);
            builder
               .HasOne(x => x.Employee)
               .WithMany(x => x.Advances)
               .HasForeignKey(x => x.EmployeeId);


        }
    }
}
