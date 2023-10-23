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
    public class EducationMap : IEntityTypeConfiguration<Education>
    {
        void IEntityTypeConfiguration<Education>.Configure(EntityTypeBuilder<Education> builder)
        {
            builder.HasKey(f => f.Id);
            builder
                .HasOne(x => x.Employee)
                .WithMany(x => x.Educations)
                .HasForeignKey(x => x.EmployeeId);


        }
    }
}
