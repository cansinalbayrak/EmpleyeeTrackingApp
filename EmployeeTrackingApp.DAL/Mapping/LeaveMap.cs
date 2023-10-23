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
    public class LeaveMap : IEntityTypeConfiguration<Leave>
    {
        void IEntityTypeConfiguration<Leave>.Configure(EntityTypeBuilder<Leave> builder)
        {
            builder.HasKey(f => f.Id);
            builder
               .HasOne(x => x.Employee)
               .WithMany(x => x.Leaves)
               .HasForeignKey(x => x.EmployeeId);

        }
    }
}
